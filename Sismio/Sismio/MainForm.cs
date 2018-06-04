using MaterialSkin;
using MaterialSkin.Controls;
using Sismio.io.sismio.ui;
using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Sismio
{
    public partial class MainForm : MaterialForm
    {
        public MainForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = SismioColor.Scheme;
            this.navbar.BackColor = SismioColor.Scheme.DarkPrimaryColor;
            
            this.tabControl.SelectedTab = this.tabDashboard;

            this.tabDashboard.BackColor = SismioColor.BackColor;
            this.tabGestioneStazioni.BackColor = SismioColor.BackColor;
            this.tabGestioneUtenti.BackColor = SismioColor.BackColor;
            this.tabStorico.BackColor = SismioColor.BackColor;
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
