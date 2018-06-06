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

        private void btnCrea_Click(object sender, EventArgs e)
        {
            /*
            Utente utente;
            if (amministratore)
                utente = new Amministratore(
                    Nome = "tizio",
                    Cognome = "caio",
                    Email = "tizio@caio.it",
                    LoginRemoto = true,
                    Username = "tizio" );
            else
                utente = new UtenteNormale(
                    Nome = "tizio",
                    Cognome = "caio",
                    Email = "tizio@caio.it",
                    LoginRemoto = true,
                    Username = "tizio");

             utente.ImpostaPasswordDaOriginale("password");
            
            Controller.Registra(utente);
            */
        }
    }
}
