using MaterialSkin;
using MaterialSkin.Controls;
using Sismio.io.sismio.ui;
using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Sismio
{
    public partial class Form1 : MaterialForm
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
           IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();

        Font robotoMonoBold;

        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = SismioColor.Scheme;
            this.navbar.BackColor = SismioColor.Scheme.DarkPrimaryColor;

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

            robotoMonoBold = new Font(fonts.Families[0], 16.0F);

            this.tabControl.SelectedTab = this.tabDashboard;

            /**
             * Set up tabs common properties
             * */
             Color bgGray = Color.FromArgb(100, 245, 245, 245);
            this.tabDashboard.BackColor = bgGray;
            this.tabGestioneStazioni.BackColor = bgGray;
            this.tabGestioneUtenti.BackColor = bgGray;
            this.tabStorico.BackColor = bgGray;

            /**
             * Set up titles
             **/
            this.titleDashboard.Font = robotoMonoBold;
            this.titleGestioneStazioni.Font = robotoMonoBold;
            this.titleGestioneUtenti.Font = robotoMonoBold;
            this.titleStorico.Font = robotoMonoBold;

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
            this.listView.CheckBoxes = true;
        }

        private void seedGestioneUtentiListView()
        {
            //Define
            var data = new[]
            {
                new []{"Lollipop", "392", "0.2", "0"},
                new []{"KitKat", "518", "26.0", "7"},
                new []{"Ice cream sandwich", "237", "9.0", "4.3"},
                new []{"Jelly Bean", "375", "0.0", "0.0"},
                new []{"Honeycomb", "408", "3.2", "6.5"}
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

        private void changeTab(TabPage tabPage)
        {
            this.tabControl.SelectedTab = tabPage;
            this.ActiveControl = this.tabControl; // clear focus
        }

        private void navDashboard_Click(object sender, EventArgs e)
        {
            changeTab(this.tabDashboard);
        }

        private void navGestioneStazioni_Click(object sender, EventArgs e)
        {
            changeTab(this.tabGestioneStazioni);
        }

        private void navStorico_Click(object sender, EventArgs e)
        {
            changeTab(this.tabStorico);
        }

        private void navGestioneUtenti_Click(object sender, EventArgs e)
        {
            changeTab(this.tabGestioneUtenti);
        }
    }
}
