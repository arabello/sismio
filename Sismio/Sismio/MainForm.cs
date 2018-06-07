using MaterialSkin;
using MaterialSkin.Controls;
using Sismio.io.sismio.eventi;
using Sismio.io.sismio.stazione;
using Sismio.io.sismio.ui;
using Sismio.io.sismio.utente;
using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using Sismio.io.sismio.sensore;
using Sismio.io.sismio.sorgente;
using Sismio.io.sismio.user;

namespace Sismio
{
    public partial class MainForm : MaterialForm
    {
        public MainForm(IGestioneUtentiController gestioneUtentiController,
            IGestioneStazioniController gestioneStazioniController,
            IStoricoController storico,
            ISorgente sorgente, GestoreEventi gestoreEventi,
            AutenticazioneController autenticazioneController)
        {
            InitializeComponent();

            this.homeDashboard1.Sorgente = sorgente;
            this.homeDashboard1.GestoreEventi = gestoreEventi;
            this.homeDashboard1.GestioneStazioniController = gestioneStazioniController;

            this.storico1.StoricoController = storico;
            this.homeGestioneUtenti1.UtentiController = gestioneUtentiController;
            this.homeGestioneStazioni1.StazioniController = gestioneStazioniController;

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = SismioColor.Scheme;
            this.navbar.BackColor = SismioColor.Scheme.DarkPrimaryColor;
            //this.BackColor = SismioColor.BackColor;
            
            this.tabControl.SelectedTab = this.tabDashboard;

            this.tabDashboard.BackColor = SismioColor.BackColor;
            this.tabGestioneStazioni.BackColor = SismioColor.BackColor;
            this.tabGestioneUtenti.BackColor = SismioColor.BackColor;
            this.tabStorico.BackColor = SismioColor.BackColor;

            // Nascondo i pulsanti in base ai permessi
            IUtente utenteCorrente = autenticazioneController.UtenteAttivo;

            if (utenteCorrente == null)
            {
                this.navGestioneStazioni.Visible = false;
                this.navGestioneUtenti.Visible = false;
            }
            else
            {
                this.navGestioneStazioni.Visible = utenteCorrente.PuoModificareStazioni();
                this.navGestioneUtenti.Visible = utenteCorrente.PuoModificareUtenti();
            }
            
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
       
        private void asvg_Click(object sender, EventArgs e)
        {
            
            this.DialogResult = DialogResult.OK;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.homeDashboard1.OnLogout();
            this.DialogResult = DialogResult.OK;
            //if (DialogResult != DialogResult.OK)
            //    this.DialogResult = DialogResult.Abort;
        }

        private void tabGestioneStazioni_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
