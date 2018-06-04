using System;
using System.Data.SQLite;
using System.Net;

namespace Sismio.io.sismio.stazione
{
    // Cambiato: aggiunto toString
    public class Stazione: IStazione
    {
        public string Nome { get; set; }
        public string Locazione { get; set; }
        public IPAddress IndirizzoDiRete { get; set; }
        public int Porta { get; set; }
        public string ImprontaChiavePubblica { get; set; }
        public long Id { get; set; } = -1;

        public Stazione()
        {
        }

        public Stazione(string nome, string locazione, IPAddress indirizzoDiRete, int porta, string improntaChiavePubblica)
        {
            Nome = nome;
            Locazione = locazione;
            IndirizzoDiRete = indirizzoDiRete;
            Porta = porta;
            ImprontaChiavePubblica = improntaChiavePubblica;
        }

        /// <summary>
        /// Utilizzato per convertire una riga di una query sql in un oggetto Stazione
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        public static Stazione ConvertiRigaInStazione(SQLiteDataReader reader)
        {
            Stazione stazione = new Stazione();

            // Popolo i campi della stazione
            stazione.Id = Convert.ToInt64(reader["stazioni_id"]);
            stazione.Nome = reader["stazioni_nome"].ToString();
            stazione.Locazione = reader["stazioni_locazione"].ToString();
            stazione.IndirizzoDiRete = IPAddress.Parse(reader["stazioni_indirizzoDiRete"].ToString());
            stazione.Porta = Convert.ToInt32(reader["stazioni_porta"]);
            stazione.ImprontaChiavePubblica = reader["stazioni_impronta"].ToString();

            return stazione;
        }

        public override string ToString()
        {
            return $"{nameof(Nome)}: {Nome}, {nameof(Locazione)}: {Locazione}, {nameof(IndirizzoDiRete)}: {IndirizzoDiRete}, {nameof(Porta)}: {Porta}, {nameof(ImprontaChiavePubblica)}: {ImprontaChiavePubblica}, {nameof(Id)}: {Id}";
        }

        protected bool Equals(Stazione other)
        {
            return string.Equals(Nome, other.Nome) && string.Equals(Locazione, other.Locazione) && Equals(IndirizzoDiRete, other.IndirizzoDiRete) && Porta == other.Porta && string.Equals(ImprontaChiavePubblica, other.ImprontaChiavePubblica) && Id == other.Id;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Stazione) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (Nome != null ? Nome.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Locazione != null ? Locazione.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (IndirizzoDiRete != null ? IndirizzoDiRete.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ Porta;
                hashCode = (hashCode * 397) ^ (ImprontaChiavePubblica != null ? ImprontaChiavePubblica.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ Id.GetHashCode();
                return hashCode;
            }
        }
    }
}
