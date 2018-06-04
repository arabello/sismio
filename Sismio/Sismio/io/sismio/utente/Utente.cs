using System;
using System.Data.SQLite;

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

        /// <summary>
        /// Utilizzato per convertire una riga di una query sql in un oggetto Utente
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        public static Utente ConvertiRigaInUtente(SQLiteDataReader reader)
        {
            // Ottengo il tipo dell'utente corrente
            Type tipoUtente = Type.GetType(typeof(Utente).Namespace + "." + reader["type"].ToString());
            if (tipoUtente == null)
                return null;

            // Genero un istanza per il tipo dell'utente corrente
            Utente utente = (Utente)Activator.CreateInstance(tipoUtente);

            // Popolo i campi dell'utente
            utente.Id = Convert.ToInt64(reader["id"]);
            utente.Nome = reader["nome"].ToString();
            utente.Cognome = reader["cognome"].ToString();
            utente.Username = reader["username"].ToString();
            utente.Email = reader["email"].ToString();
            utente.HashPass = reader["hashPass"].ToString();
            utente.SaltPass = reader["salt"].ToString();
            utente.LoginRemoto = (Convert.ToInt16(reader["loginRemoto"]) == 0 ? false : true);

            return utente;
        }

        public abstract bool PuoModificareUtenti();
        public abstract bool PuoModificareSorgenti();
        public abstract bool PuoModificareStazioni();

        public override string ToString()
        {
            return $"{nameof(Nome)}: {Nome}, {nameof(Cognome)}: {Cognome}, {nameof(Email)}: {Email}, {nameof(Username)}: {Username}, {nameof(HashPass)}: {HashPass}, {nameof(SaltPass)}: {SaltPass}, {nameof(LoginRemoto)}: {LoginRemoto}, {nameof(Id)}: {Id}";
        }

        protected bool Equals(Utente other)
        {
            return string.Equals(Nome, other.Nome) && string.Equals(Cognome, other.Cognome) && string.Equals(Email, other.Email) && string.Equals(Username, other.Username) && string.Equals(HashPass, other.HashPass) && string.Equals(SaltPass, other.SaltPass) && LoginRemoto == other.LoginRemoto && Id == other.Id;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Utente) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (Nome != null ? Nome.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Cognome != null ? Cognome.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Email != null ? Email.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Username != null ? Username.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (HashPass != null ? HashPass.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (SaltPass != null ? SaltPass.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ LoginRemoto.GetHashCode();
                hashCode = (hashCode * 397) ^ Id.GetHashCode();
                return hashCode;
            }
        }
    }
}