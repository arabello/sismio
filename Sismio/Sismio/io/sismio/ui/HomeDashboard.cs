using System;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Threading;
using LiveCharts;
using LiveCharts.Wpf;

namespace Sismio.io.sismio.ui
{
    public partial class HomeDashboard : UserControl
    {
        public HomeDashboard()
        {
            InitializeComponent();

            /**
             * Set up chart Frequenza
             **/
            this.chartFrequenza.DisableAnimations = true;
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
                    Stroke = Brushes.CornflowerBlue,
                    Fill = Brushes.Transparent,
                    PointGeometry = null
                }
            };

            /**
             * Set up chart Magnitudo
             **/
            this.chartMagnitudo.DisableAnimations = true;
            this.chartMagnitudo.AxisX.Add(new Axis
            {
                Title = "Orario",
                LabelFormatter = value => new DateTime((long)(DateTime.Now.Ticks + (value * TimeSpan.FromMinutes(1).Ticks))).ToString("t") // Divido l'asse x discretamente ai minuti
            });

            this.chartMagnitudo.AxisY.Add(new Axis
            {
                Title = "Intensità"
            });
            this.chartMagnitudo.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Magnitudo",
                    Stroke = Brushes.PaleVioletRed,
                    Fill = Brushes.Transparent,
                    PointGeometry = null
                }
            };

            /**
             * Set up events
             **/
            MockAnalisi analisiFrequenza = new MockAnalisi(); // TODO: Change mock to actual analisys
            analisiFrequenza.RicevitoriRisultati += updateChartFrequenza;

            MockAnalisi analisiMagnitudo = new MockAnalisi(); // TODO: Change mock to actual analisys
            analisiMagnitudo.RicevitoriRisultati += updateChartMagnitudo;

            analisiMagnitudo.start(1000);
            analisiFrequenza.start(1000);
        }

        private void updateChartFrequenza(double[] values)
        {
            this.chartFrequenza.Invoke((MethodInvoker)delegate {
                // Running on the UI thread
                this.chartFrequenza.Series[0].Values = new ChartValues<double>(values);
            });
        }

        private void updateChartMagnitudo(double[] values)
        {
            this.chartMagnitudo.Invoke((MethodInvoker)delegate {
                // Running on the UI thread
                this.chartMagnitudo.Series[0].Values = new ChartValues<double>(values);
            });
            
        }
    }
}
