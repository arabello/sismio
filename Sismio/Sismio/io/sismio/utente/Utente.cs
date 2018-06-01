namespace Sismio.io.sismio.utente
{
    public abstract class Utente: IUtente
    {
        public string Nome { get; set; }
        public string Cognome { get; set;  }
        public string Email { get; set; }
        public string Username { get; set; }
        public string HashPass { get; set; }
        public string SaltPass { get; set; }
        public bool LoginRemoto { get; set; }
        public long Id { get; set; }

        protected Utente(string nome, string cognome, string email, string username, string hashPass, string saltPass, bool loginRemoto)
        {
            Nome = nome;
            Cognome = cognome;
            Email = email;
            LoginRemoto = loginRemoto;
            Username = username;
            HashPass = hashPass;
            SaltPass = saltPass;
            LoginRemoto = loginRemoto;
        }

        public abstract bool PuoModificareUtenti();
        public abstract bool PuoModificareSorgenti();
        public abstract bool PuoModificareStazioni();
    }
}