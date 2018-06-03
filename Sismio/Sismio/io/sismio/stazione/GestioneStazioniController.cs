using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Net;
using Sismio.io.sismio.database;
using Sismio.io.sismio.log;

namespace Sismio.io.sismio.stazione
{
    /// <summary>
    /// Classe responsabile della persistenza delle stazioni
    /// </summary>
    // Cambiato EliminaStazione, RegistraStazione -> Elimina, Registra
    // Cambiato IStazione -> Stazione in EliminaStazione, RegistraStazione
    // Cambiato void -> bool in EliminaStazione, RegistraStazione
    // Cambiare anche nell'interfaccia
    public class GestioneStazioniController : DBController, IGestioneStazioniController
    {
        /// <summary>
        /// Costruttore, crea la tabella se non esistente
        /// </summary>
        /// <param name="percorsoDatabase">Percorso del database</param>
        public GestioneStazioniController(string percorsoDatabase) : base(percorsoDatabase)
        {
            // Crea la tabella stazioni se non è gia presente
            CreaTabellaStazioniSeNonEsiste();
        }

        private void CreaTabellaStazioniSeNonEsiste()
        {

            // Creo la tabella stazioni se non esiste già
            using (SQLiteCommand cmd = new SQLiteCommand("CREATE TABLE IF NOT EXISTS stazioni (" +
                                                         "id INTEGER PRIMARY KEY AUTOINCREMENT, " +
                                                         "nome VARCHAR(20) NOT NULL," + // TODO UNIQUE: Nome unico?
                                                         "locazione VARCHAR(100) NOT NULL," +
                                                         "indirizzoDiRete VARCHAR(20) NOT NULL," + // TODO UNIQUE: Indirizzo pubblico unico?
                                                         "porta INTEGER NOT NULL," +
                                                         "impronta VARCHAR(65) NOT NULL" +
                                                         ")", _connection))
            {
                try
                {
                    cmd.ExecuteNonQuery();
                    // Logger.Scrivi("Creata tabella stazioni, prima non esistente"); // TODO Anche se esistente, scrive sul log; bisognerebbe controllare prima che non esista
                }
                catch (SQLiteException e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }
        
        /// <summary>
        /// Metodo responsabile della ricerca in base ad una query prestabilita
        /// </summary>
        /// <param name="query"> Stringa rappresentante la query da eseguire</param>
        /// <returns></returns>
        public IList<IStazione> Cerca(string query)
        {
            List<IStazione> stazioni = new List<IStazione>();
            using (SQLiteCommand cmd = new SQLiteCommand(query, _connection))
            {
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Converto la entry del database in una stazione
                        IStazione stazioneCorrente = Stazione.ConvertiRigaInStazione(reader);
                        if (stazioneCorrente != null)
                        {
                            stazioni.Add(stazioneCorrente);
                        }
                    }
                }
            }

            return stazioni;
        }
        /// <summary>
        /// Metodo che si occupa di listare tutte le stazioni del database
        /// </summary>
        /// <returns></returns>
        public IList<IStazione> ListaTutti()
        {
            List<IStazione> stazioni = new List<IStazione>();
            using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM stazioni", _connection))
            {
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Converto la entry del database in una stazione
                        IStazione stazioneCorrente = Stazione.ConvertiRigaInStazione(reader);
                        if (stazioneCorrente != null)
                        {
                            stazioni.Add(stazioneCorrente);
                        }
                    }
                }
            }

            return stazioni;
        }
        /// <summary>
        /// Metodo responsabile della registrazione della stazione
        /// </summary>
        /// <param name="stazione"> Stazione da registrare</param>
        /// <returns></returns>
        public bool Registra(Stazione stazione)
        {
            int risultato = -1;
            using (SQLiteCommand cmd = new SQLiteCommand(_connection))
            {
                // Preparo la query SQL
                cmd.CommandText = "INSERT INTO stazioni(nome, locazione, indirizzoDiRete, porta, impronta) VALUES (@Nome, @Locazione, @indirizzoDiRete, @Porta, @Impronta)";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@Nome", stazione.Nome);
                cmd.Parameters.AddWithValue("@Locazione", stazione.Locazione);
                cmd.Parameters.AddWithValue("@IndirizzoDiRete", stazione.IndirizzoDiRete.ToString());
                cmd.Parameters.AddWithValue("@Porta", stazione.Porta.ToString());
                cmd.Parameters.AddWithValue("@Impronta", stazione.ImprontaChiavePubblica);
                try
                {
                    risultato = cmd.ExecuteNonQuery();

                    // Aggiorno il valore dell'id della stazione
                    if (risultato > 0)
                    {
                       stazione.Id = _connection.LastInsertRowId;
                        // Se true, scrivo sul file di log
                       Logger.Scrivi("Registrata stazione: " + stazione);
                    }
                }
                catch (SQLiteException e)
                {
                    Console.WriteLine(e.ToString());
                }
            }

            return risultato > 0;
        }

        /// <summary>
        /// Metodo responsabile dell'eliminazione di una stazione
        /// </summary>
        /// <param name="stazione"> Stazione da eliminare </param>
        /// <returns></returns>
        public bool Elimina(Stazione stazione)
        {

            if (stazione.Id == -1)
                throw new InvalidOperationException("La stazione non contiene l'ID, quindi non può essere eliminata");

            int risultato = -1;
            using (SQLiteCommand cmd = new SQLiteCommand(_connection))
            {
                // Elimino la stazione che ha come id la stazione che passo come parametro
                cmd.CommandText = "DELETE FROM stazioni WHERE id = @Id";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@Id", stazione.Id);
                try
                {
                    risultato = cmd.ExecuteNonQuery();

                    // Se true, scrivo sul file di log
                    if (risultato > 0)
                        Logger.Scrivi("Eliminata stazione: " + stazione);
                }
                catch (SQLiteException e)
                {
                    Console.WriteLine(e.ToString());
                }
            }

            return risultato > 0 ? true : false;
        }
    }
}