namespace Sismio.io.sismio.utente
{
    internal class Amministratore: Utente
    {
        
        public override bool PuoModificareUtenti()
        {
            return true;
        }

        public override bool PuoModificareSorgenti()
        {
            return true;
        }

        public override bool PuoModificareStazioni()
        {
            return true;
        }

        public Amministratore() : base()
        {
        }

        public Amministratore(string nome, string cognome, string email, string username, string hashPass, string saltPass, bool loginRemoto) : base(nome, cognome, email, username, hashPass, saltPass, loginRemoto)
        {
        }
    }
}