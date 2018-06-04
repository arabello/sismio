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

namespace Sismio.io.sismio.ui
{
    public partial class HomeGestioneUtenti : UserControl
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
          IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();

        Font robotoMonoBold;
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

            robotoMonoBold = new Font(fonts.Families[0], 16.0f);

            this.title.Font = robotoMonoBold;

            this.BackColor = SismioColor.BackColor;

            /**
             * Set up GestioneUtenti
             */
            this.textCerca.BackColor = SismioColor.Scheme.DarkPrimaryColor;
            this.textCerca.Font = materialSkinManager.ROBOTO_REGULAR_11;
            this.textCerca.GotFocus += onTextCercaFocus;
            this.textCerca.LostFocus += onTextCercaBlur;
            this.textCerca.Font = materialSkinManager.ROBOTO_REGULAR_11;
            this.textCerca.ForeColor = Color.White;
            this.bgTextCerca.BackColor = SismioColor.Scheme.DarkPrimaryColor;
            this.btnAggiungiNuovo.BackColor = Color.LightGreen;
            this.btnAggiungiNuovo.Font = materialSkinManager.ROBOTO_REGULAR_11;

            /**
             * SetUp GestioneUtenti ListView
             **/
            seedGestioneUtentiListView();
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

        private void seedGestioneUtentiListView()
        {
            //Define
            var data = new[]
            {
                new []{"Lollipop", "392", "0.2", "v"},
                new []{"KitKat", "518", "26.0", "v"},
                new []{"Ice cream sandwich", "237", "9.0", ""},
                new []{"Jelly Bean", "375", "0.0", ""},
                new []{"Honeycomb", "408", "3.2", "v"}
            };

            //Add
            foreach (string[] version in data)
            {
                var item = new ListViewItem(version);
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
            //TODO: Show dialog confirm
            //TODO: Elimina utente
           
            //this.gestioneUtentiLV.SelectedItems
            //this.gestioneUtentiLV.SelectedItems
        }
    }
}
