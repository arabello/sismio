using System;
using System.Data.SQLite;
using System.Net;
using Sismio.io.sismio.eventi;

namespace Sismio.io.sismio.stazione
{
    public class Stazione: IStazione
    {
        public string Nome { get; set; }
        public string Locazione { get; set; }
        public IPAddress IndirizzoDiRete { get; set; }
        public int Porta { get; set; }
        public string ImprontaChiavePubblica { get; set; }
        public long Id { get; set; }

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
            stazione.Id = Convert.ToInt64(reader["id"]);  // TODO considerare il caso della join con evento
            stazione.Nome = reader["nome"].ToString();
            stazione.Locazione = reader["locazione"].ToString();
            stazione.IndirizzoDiRete = IPAddress.Parse(reader["indirizzoDiRete"].ToString());
            stazione.Porta = Convert.ToInt32(reader["porta"]);
            stazione.ImprontaChiavePubblica = reader["improntaChiavePubblica"].ToString();

            return stazione;
        }
    }
}
