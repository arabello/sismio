using Sismio.io.sismio.utente;
using System;

namespace Sismio.io.sismio.user
{
    public class AutenticazioneController
    {
        public IUtente UtenteAttivo { get; set; }

        private IGestioneUtentiController gestioneUtentiController;
        public AutenticazioneController(IGestioneUtentiController gestioneUtentiController)
        {
            this.gestioneUtentiController = gestioneUtentiController;
        }

        public bool Autentica(string username, string pass)
        {
            IUtente user = gestioneUtentiController.ValidaCredenziali(username, pass);
            if (user == null)
            {
                return false;
            }
            else
            {
                UtenteAttivo = user;
                return true;
            }
        }

        public bool Disconnetti()
        {
            UtenteAttivo = null;
            return true;
        }
    }
}