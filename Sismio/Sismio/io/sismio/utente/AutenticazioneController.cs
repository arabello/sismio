using Sismio.io.sismio.utente;
using System;

namespace Sismio.io.sismio.user
{
    public class AutenticazioneController
    {
        public IUtente UtenteAttivo { get; set; }

        private readonly IGestioneUtentiController _gestioneUtentiController;
        public AutenticazioneController(IGestioneUtentiController gestioneUtentiController)
        {
            this._gestioneUtentiController = gestioneUtentiController;
        }

        public bool Autentica(string username, string pass)
        {
            IUtente user = _gestioneUtentiController.ValidaCredenziali(username, pass);
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