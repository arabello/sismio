using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sismio.io.sismio.stazione;
using Sismio.io.sismio.utente;

namespace Sismio.io.sismio.ui
{
    public partial class RegistraStazione : UserControl
    {

        public IGestioneStazioniController Controller;

        public RegistraStazione()
        {
            InitializeComponent();
        }

        private String validation()
        {
            if (inputNome.Text == "Nome stazione" || inputNome.Text == "" || ! (inputNome.Text.Length <= 20)) 
                return "Nome stazione";
            if (inputLocazione.Text == "Locazione" || inputLocazione.Text == "" || !(inputLocazione.Text.Length <= 100))
                return "Locazione";
            if (inputIP.Text == "Indirizzo IP" || inputIP.Text == "" || ! IPAddress.TryParse(inputIP.Text, out IPAddress ind))
                return "Indirizzo IP";
            if (inputPorta.Text == "Porta" || inputPorta.Text == "" || ! int.TryParse(inputPorta.Text, out int number) || ! (int.Parse(inputPorta.Text) > 1024 && int.Parse(inputPorta.Text) < 65535))
                return "Porta";
            return null;
        }

        private void btnCrea_Click(object sender, EventArgs e)
        {
            String error = validation();
            if (error != null)
            {
                MessageBox.Show("Il campo " + error + " non è corretto", "Inserimento dati non valido",
                    MessageBoxButtons.OK);
                return;
            }

            Stazione stazione;

            stazione = new Stazione
            {
                Nome = inputNome.Text,
                Locazione = inputLocazione.Text,
                IndirizzoDiRete = IPAddress.Parse(inputIP.Text),
                Porta = Int32.Parse(inputPorta.Text),
                ImprontaChiavePubblica = "E2C9153221FE658AFDCEBE095EE5D2392AF8C4AE"  // TODO: andrebbe richiesta al server dinamicamente, versione 2.0
            };
            
            bool res = Controller.Registra(stazione);
            if (res)
                this.ParentForm.DialogResult = DialogResult.Abort;
            else
                this.ParentForm.DialogResult = DialogResult.OK;
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            this.ParentForm.DialogResult = DialogResult.Cancel;
        }
    }
}
