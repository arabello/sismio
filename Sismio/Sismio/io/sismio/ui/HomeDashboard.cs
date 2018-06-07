using System;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using MaterialSkin;
using Sismio.io.sismio.analisi;
using Sismio.io.sismio.eventi;
using Sismio.io.sismio.sensore;
using Sismio.io.sismio.sorgente;
using Sismio.io.sismio.stazione;

namespace Sismio.io.sismio.ui
{
    public partial class HomeDashboard : UserControl
    {
        public SorgenteFactory Factory { get; set; }
        public GestoreEventi GestoreEventi { get; set; }

        private BlockingCollection<double> codaMagnitudo = new BlockingCollection<double>();
        private BlockingCollection<double> codaFrequenza = new BlockingCollection<double>();

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
          IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();

        private ISorgente sorgente;
        private IAnalisi magnitudo;
        private IAnalisi frequenza;
        private Thread threadSorgente;
        private bool staFacendoLogout = false;

        private Thread magnitudoCodaThread;
        private Thread frequenzaCodaThread;

        Font robotoMonoBold;

        private int ALLERTA_TIME_MULTIPLIER = 3;

        public HomeDashboard()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = SismioColor.Scheme;

            //
            // Load Font
            // 
            byte[] fontData = Properties.Resources.RobotoMono_Bold;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.RobotoMono_Bold.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.RobotoMono_Bold.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            robotoMonoBold = new Font(fonts.Families[0], 16.0f);

            this.title.Font = robotoMonoBold;

            this.BackColor = SismioColor.BackColor;

            // Default values for init cahrts
            double[] _values = new double[100];

            /**
             * Set up chart Frequenza
             **/
            this.chartFrequenza.DisableAnimations = true;
            this.chartFrequenza.DataTooltip = null;
            this.chartFrequenza.Hoverable = false;
            this.chartFrequenza.AxisX.Add(new Axis
            {
                Title = "Orario",
                LabelFormatter = value => new System.DateTime((long)(DateTime.Now.Ticks + (value * TimeSpan.FromMinutes(1).Ticks))).ToString("t") // Divido l'asse x discretamente ai minuti
            });

            this.chartFrequenza.AxisY.Add(new Axis
            {
                Title = "Scosse/minuto"
            });
            this.chartFrequenza.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Frequenza",
                    Stroke = System.Windows.Media.Brushes.CornflowerBlue,
                    Fill = System.Windows.Media.Brushes.Transparent,
                    PointGeometry = null,
                     Values = new ChartValues<double>(_values)
                }
            };

            /**
             * Set up chart Magnitudo
             **/
            this.chartMagnitudo.DisableAnimations = true;
            this.chartMagnitudo.DataTooltip = null;
            this.chartMagnitudo.Hoverable = false;
            this.chartMagnitudo.AxisX.Add(new Axis
            {
                Title = "Orario",
                LabelFormatter = value => new DateTime((long)(DateTime.Now.Ticks + (value * TimeSpan.FromMinutes(1).Ticks))).ToString("t") // Divido l'asse x discretamente ai minuti
            });

            this.chartMagnitudo.AxisY.Add(new Axis
            {
                Title = "Intensità",
                MinValue = 0,
                MaxValue = 10,
            });
            this.chartMagnitudo.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Magnitudo",
                    Stroke = System.Windows.Media.Brushes.PaleVioletRed,
                    Fill = System.Windows.Media.Brushes.Transparent,
                    PointGeometry = null,
                    Values = new ChartValues<double>(_values)
                }
            };

            /**
             * Labels allerta evento
            **/
            this.labelPrioritaEvento.Font = new Font(fonts.Families[0], 22.0F);
            this.labelMessaggioEvento.Font = new Font(fonts.Families[0], 16.0f);

  
        }

        public void OnLogout()
        {
            staFacendoLogout = true;
            magnitudoCodaThread.Abort();
            frequenzaCodaThread.Abort();
            this.sorgente?.Ferma();
            this.sorgente?.RimuoviAnalisi(magnitudo);
            this.sorgente?.RimuoviAnalisi(frequenza);
            magnitudo.RicevitoriRisultato -= SegnalaMagnitudo;
            frequenza.RicevitoriRisultato -= SegnalaFrequenza;
            GestoreEventi.RicevitoriEventoSismico -= RiceviEvento;
            this.magnitudo = null;
            this.frequenza = null;
            this.sorgente = null;
            
        }

        private void SegnalaMagnitudo(double value)
        {
            codaMagnitudo.Add(value);
        }

        private void SegnalaFrequenza(double value)
        {
            codaFrequenza.Add(value);
        }

        private void updateChartFrequenza(double value)
        {
            this.chartFrequenza.Invoke((MethodInvoker)delegate
            {
                // Running on the UI thread
                this.chartFrequenza.Series[0].Values.Add(value);
                this.chartFrequenza.Series[0].Values.RemoveAt(0);
            });
        }

        private void updateChartMagnitudo(double value)
        {
            this.chartMagnitudo.Invoke((MethodInvoker)delegate
            {
                // Running on the UI thread
                this.chartMagnitudo.Series[0].Values.Add(value);
                this.chartMagnitudo.Series[0].Values.RemoveAt(0);
            });
        }

        private void HomeDashboard_Load(object sender, EventArgs e)
        {
            this.panelAllertaEvento.Visible = false;

            // Inizializzo sorgente
            //ISorgente sorgente = factory.NuovaSorgenteRemota(stazione, "tizio", "password");
            sorgente = Factory.NuovaSorgenteLocale();

            threadSorgente = new Thread(() => sorgente.CicloPrincipale());
            threadSorgente.Start();

            magnitudo = new AnalisiMagnitudine();
            sorgente.AggiungiAnalisi(magnitudo);

            magnitudo.RicevitoriRisultato += SegnalaMagnitudo;

            frequenza = new AnalisiFrequenza();
            sorgente.AggiungiAnalisi(frequenza);

            frequenza.RicevitoriRisultato += SegnalaFrequenza;

            
            magnitudoCodaThread = new Thread(() =>
            {
                while (!staFacendoLogout)
                {
                    double corrente = codaMagnitudo.Take();
                    updateChartMagnitudo(corrente);
                }
            });
            magnitudoCodaThread.Start();

            
            frequenzaCodaThread = new Thread(() =>
            {
                while (!staFacendoLogout)
                {
                    double corrente = codaFrequenza.Take();
                    updateChartFrequenza(corrente);
                }
            });
            frequenzaCodaThread.Start();

            // Registro il gestore di eventi
            GestoreEventi.RicevitoriEventoSismico += RiceviEvento;
        }

        private void RiceviEvento(IEventoSismico evento)
        {
            this.Invoke((MethodInvoker)delegate
            {
                // Running on the UI thread
                allertaEventoAsync(evento);
            });
        }

        public async System.Threading.Tasks.Task allertaEventoAsync(IEventoSismico evento)
        {
            this.panelAllertaEvento.Visible = true;
            this.panelAllertaEvento.BackColor = SismioColor.Priorita(evento.Priorita);
            this.labelPrioritaEvento.Text = evento.Priorita.ToString().ToUpper();
            this.labelMessaggioEvento.Text = evento.Messaggio.ToString();

            if (evento.Priorita == Priorita.Fatal)
            {
                this.labelPrioritaEvento.ForeColor = Color.White;
                this.labelMessaggioEvento.ForeColor = Color.White;
            }
            else
            {
                this.labelPrioritaEvento.ForeColor = Color.Black;
                this.labelMessaggioEvento.ForeColor = Color.Black;
            }

            int criticita = (int)evento.Priorita + 1;
            await Task.Delay(TimeSpan.FromSeconds(criticita * ALLERTA_TIME_MULTIPLIER));
            this.panelAllertaEvento.Visible = false;
        }
    }
}
