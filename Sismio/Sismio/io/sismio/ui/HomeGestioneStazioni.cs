using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using Sismio.io.sismio.stazione;

namespace Sismio.io.sismio.ui
{
    public partial class HomeGestioneStazioni : UserControl
    {
        public IGestioneStazioniController StazioniController { get; set; }

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();

        Font robotoMonoBold16;
        Font robotMonoLight10;

        private IList<IStazione> stazioni = null;

        public HomeGestioneStazioni()
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

            robotoMonoBold16 = new Font(fonts.Families[0], 16.0f);

            fontData = Properties.Resources.RobotoMono_Light;
            fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.RobotoMono_Light.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.RobotoMono_Light.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            robotMonoLight10 = new Font(fonts.Families[0], 10.0f);

            this.title.Font = robotoMonoBold16;

            this.BackColor = SismioColor.BackColor;

            /**
             * Set up buttom controls
             */
            this.textCerca.BackColor = SismioColor.Scheme.DarkPrimaryColor;
            this.textCerca.Font = robotMonoLight10;
            this.textCerca.GotFocus += onTextCercaFocus;
            this.textCerca.LostFocus += onTextCercaBlur;
            this.textCerca.Font = materialSkinManager.ROBOTO_REGULAR_11;
            this.textCerca.ForeColor = Color.White;
            this.bgTextCerca.BackColor = SismioColor.Scheme.DarkPrimaryColor;
            this.btnAggiungiNuovo.BackColor = Color.LightGreen;
            this.btnAggiungiNuovo.Font = materialSkinManager.ROBOTO_REGULAR_11;

            /**
             * Set up ListView
             **/
            this.btnDelete.Visible = false;
            this.listView.MultiSelect = false;
            this.listView.SelectedIndexChanged += onStazioneSelect;
        }

        private void onStazioneSelect(object sender, EventArgs e)
        {
            if (this.btnDelete.Visible)
            {
                if (this.listView.SelectedIndices.Count == 0)
                    this.btnDelete.Visible = false;
            }
            else
                this.btnDelete.Visible = true;
        }

        private void seedListView(String query)
        {
            this.listView.Items.Clear();

            if (query == null)
            {
                stazioni = StazioniController.ListaTutti();
            }
            else
            {
                stazioni = StazioniController.Cerca(query);
            }


            //Add
            foreach (IStazione stazione in stazioni)
            {
                var version = new string[]
                {
                    stazione.Nome, stazione.Locazione, stazione.IndirizzoDiRete.ToString()+":"+stazione.Porta.ToString(), stazione.ImprontaChiavePubblica
                };
                var item = new ListViewItem(version);
                item.BackColor = Color.AliceBlue;
                this.listView.Items.Add(item);
            }
        }

        private void onTextCercaBlur(object sender, EventArgs e)
        {
            this.textCerca.Text = "Cerca qui";
        }

        private void onTextCercaFocus(object sender, EventArgs e)
        {
            this.textCerca.Text = "";
        }

        private void btnAggiungiNuovo_Click(object sender, EventArgs e)
        {
            //RegistraStazioneForm f = new RegistraStazioneForm(StazioniController);
            //f.ShowDialog();
            seedListView(null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = this.listView.SelectedIndices[0];
            StazioniController.Elimina((Stazione)stazioni[index]);
            seedListView(null);
            this.btnDelete.Visible = false;
        }

        private void HomeGestioneStazioni_Load(object sender, EventArgs e)
        {
            seedListView(null);
        }

        private void textCerca_TextChanged(object sender, EventArgs e)
        {
            if (this.textCerca.Text != "Cerca qui")
            {
                seedListView(this.textCerca.Text);
            }
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
