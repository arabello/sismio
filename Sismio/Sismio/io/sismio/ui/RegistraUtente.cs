using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sismio.io.sismio.utente;

namespace Sismio.io.sismio.ui
{
    public partial class RegistraUtente : UserControl
    {

        public  IGestioneUtentiController Controller;

        public RegistraUtente()
        {
            InitializeComponent();
        }

        bool IsValidEmail(string email)
        {
            try {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch {
                return false;
            }
        }

        private String validation()
        {
            if (inputNome.Text == "Nome" || inputNome.Text == "")
                return "Nome";
            if (inputCognome.Text == "Cognome" || inputCognome.Text == "")
                return "Cognome";
            if (inputEmail.Text == "Email" || inputEmail.Text == "" || !IsValidEmail(inputEmail.Text))
                return "Email";
            if (inputUsername.Text == "Username" || inputUsername.Text == "")
                return "Username";
            if (inputPassword.Text == "Password" || inputPassword.Text == "")
                return "Password";
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
            
            Utente utente;
            if (checkboxAmm.Checked)
                utente = new Amministratore
                {
                    Nome = inputNome.Text,
                    Cognome = inputCognome.Text,
                    Email = inputEmail.Text,
                    LoginRemoto = checkboxLoginRemoto.Checked,
                    Username = inputUsername.Text
                };
            else
                utente = new UtenteNormale
                {
                    Nome = inputNome.Text,
                    Cognome = inputCognome.Text,
                    Email = inputEmail.Text,
                    LoginRemoto = checkboxLoginRemoto.Checked,
                    Username = inputUsername.Text
                };
            utente.ImpostaPasswordDaOriginale(inputPassword.Text);
            bool res = Controller.Registra(utente);
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
