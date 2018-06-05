using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using MaterialSkin;
using Sismio.io.sismio.utente;

namespace Sismio.io.sismio.ui
{
    public partial class HomeGestioneUtenti : UserControl
    {
        public IGestioneUtentiController UtentiController { get; set; }

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
          IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();

        Font robotoMonoBold16;
        Font robotMonoLight10;

        private IList<IUtente> utenti = null;

        public HomeGestioneUtenti()
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
            this.listView.SelectedIndexChanged += onUtenteSelect;
        }

        private void onUtenteSelect(object sender, EventArgs e)
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
                utenti = UtentiController.ListaTutti();
            }
            else
            {
                utenti = UtentiController.Cerca(query);
            }
                

            //Add
            foreach (IUtente utente in utenti)
            {
                var version = new string[]
                {
                    utente.Email, utente.Username, utente.GetType().Name, utente.LoginRemoto.ToString()
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
            //TODO: Nuovo utente
        }

        private void btnDeleteUtente_Click(object sender, EventArgs e)
        {
            //TODO: Elimina utente
            //this.gestioneUtentiLV.SelectedItems
            //this.gestioneUtentiLV.SelectedItems
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = this.listView.SelectedIndices[0];
            UtentiController.Elimina((Utente) utenti[index]);
            seedListView(null);
            this.btnDelete.Visible = false;
        }

        private void HomeGestioneUtenti_Load(object sender, EventArgs e)
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
    }
}
