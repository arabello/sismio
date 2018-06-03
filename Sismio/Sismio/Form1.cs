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

            this.titleDashboard.Font = robotoMonoBold;
            this.titleGestioneStazioni.Font = robotoMonoBold;
            this.titleGestioneUtenti.Font = robotoMonoBold;
            this.titleStorico.Font = robotoMonoBold;
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
