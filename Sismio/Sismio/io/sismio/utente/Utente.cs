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
        public long Id { get; set; } = -1;

        protected Utente() {}

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

        /// <summary>
        /// Partendo dalla password in chiaro originale, genera il salt e l'hash
        /// ed imposta automaticamente le proprietà HashPass e SaltPass.
        /// </summary>
        /// <param name="password">La password originale in chiaro</param>
        public void ImpostaPasswordDaOriginale(string password)
        {
            // Genera il salt casuale
            string salt = HashUtil.GeneraSalt();
            
            // Genera l'hash della password concatenata con il salt
            string hash = HashUtil.GeneraSHA256(password + salt);

            HashPass = hash;
            SaltPass = salt;
        }

        public abstract bool PuoModificareUtenti();
        public abstract bool PuoModificareSorgenti();
        public abstract bool PuoModificareStazioni();
    }
}