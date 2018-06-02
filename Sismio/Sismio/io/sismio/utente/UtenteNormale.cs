namespace Sismio.io.sismio.utente
{
    public class UtenteNormale: Utente
    {
        public override bool PuoModificareUtenti()
        {
            return false;
        }

        public override bool PuoModificareSorgenti()
        {
            return true;
        }

        public override bool PuoModificareStazioni()
        {
            return false;
        }

        public UtenteNormale(string nome, string cognome, string email, string username, string hashPass, string saltPass, bool loginRemoto) : base(nome, cognome, email, username, hashPass, saltPass, loginRemoto)
        {
        }
    }
}