using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Sismio.io.sismio.database;

namespace Sismio.io.sismio.utente
{
    // Cosa ho modificato rispetto all'originale:
    // Ho fatto estendere anche da DBController come richiesto
    // Ho cambiato i tipi di ritorno di Registra ed Elimina
    // Da segnalare l'utilizzo della Reflection per ricreare l'istanza del tipo di utente corretto

    public class GestioneUtentiController : DBController, IGestioneUtentiController
    {
        public GestioneUtentiController(string percorsoDatabase) : base(percorsoDatabase)
        {
            // Crea la tabella utenti se non è gia presente
            CreaTabellaUtentiSeNonEsiste();

            // Crea l'utente admin se non già presente
            CreaAdminSeNonEsiste();
        }

        private void CreaTabellaUtentiSeNonEsiste()
        {
            // TODO Aggiungere il log dell'operazione

            // Creo la tabella utenti se non esiste già
            using (SQLiteCommand cmd = new SQLiteCommand("CREATE TABLE IF NOT EXISTS utenti (" +
                                                         "id INTEGER PRIMARY KEY AUTOINCREMENT, " +
                                                         "nome VARCHAR(100) NOT NULL," +
                                                         "cognome VARCHAR(100) NOT NULL," +
                                                         "email VARCHAR(200) NOT NULL UNIQUE," +
                                                         "username VARCHAR(100) NOT NULL UNIQUE," +
                                                         "hashPass VARCHAR(64) NOT NULL," +
                                                         "salt VARCHAR(64) NOT NULL," +
                                                         "loginRemoto INTEGER NOT NULL," +
                                                         "type VARCHAR(30) NOT NULL" +
                                                         ")", _connection))
            {
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SQLiteException e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        private void CreaAdminSeNonEsiste()
        {
            // Verifico se l'admin esiste
            bool adminPresente = false;
            using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM utenti WHERE username = 'admin'", _connection))
            {
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        adminPresente = true;
                    }
                }
            }

            // Se l'admin non è presente, lo aggiungo al database
            if (!adminPresente)
            {
                // Creo l'utente admin
                var adminUtente = new Amministratore
                {
                    Nome = "Admin",
                    Cognome = "Admin",
                    Email = "admin@admin.it",
                    Username = "admin",
                    LoginRemoto = false
                };
                adminUtente.ImpostaPasswordDaOriginale("admin");
                
                // Lo aggiungo al database
                Registra(adminUtente);
            }
           
        }

        public IUtente ValidaCredenziali(string username, string pass)
        {
            IUtente outputUtente = null;

            using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM utenti WHERE username = @Username", _connection))
            {
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@Username", username);

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        outputUtente = Utente.ConvertiRigaInUtente(reader);
                    }
                }
            }

            // Controllo che l'utente esista e la password corrisponda
            if (outputUtente == null)
            {
                return null;
            }
            else
            {
                // Controllo che la password corrisponda
                string hashPrevisto = HashUtil.GeneraSHA256(pass + outputUtente.SaltPass);
                if (hashPrevisto == outputUtente.HashPass)
                {
                    return outputUtente;
                }
                else
                {
                    return null;
                }
            }
        }

        public bool Elimina(Utente utente)
        {
            // TODO Aggiungere il log dell'operazione

            // Assicurati che l'utente abbia l'id e quindi possa essere eliminato
            if (utente.Id == -1)
                throw new InvalidOperationException("L'utente non contiene l'ID, quindi non può essere eliminato");

            int risultato = -1;
            using (SQLiteCommand cmd = new SQLiteCommand(_connection))
            {
                cmd.CommandText = "DELETE FROM utenti WHERE id = @Id";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@Id", utente.Id);
                try
                {
                    risultato = cmd.ExecuteNonQuery();
                }
                catch (SQLiteException e)
                {
                    Console.WriteLine(e.ToString());
                }
            }

            return risultato > 0 ? true : false;
        }

        public IList<IUtente> ListaTutti()
        {
            List<IUtente> utenti = new List<IUtente>();
            using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM utenti", _connection))
            {
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        IUtente utenteCorrente = Utente.ConvertiRigaInUtente(reader);
                        if (utenteCorrente != null)
                        {
                            utenti.Add(utenteCorrente);
                        }
                    }
                }
            }

            return utenti;
        }

        /// <summary>
        /// Metodo responsabile della ricerca in base ad una query prestabilita
        /// </summary>
        /// <param name="query">Stringa da cercare</param>
        /// <returns></returns>
        public IList<IUtente> Cerca(string query)
        {
            string uppercaseQuery = query.ToUpper();
            List<IUtente> utenti = new List<IUtente>();

            // Effettuo una ricerca CASE-INSENSITIVE sui campi email, nome, cognome ed username
            using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM utenti WHERE UPPER(email) LIKE '%' || @query || '%' " +
                                                         "OR UPPER(nome) LIKE '%' || @query || '%' " +
                                                         "OR UPPER(cognome) LIKE '%' || @query || '%' " +
                                                         "OR UPPER(username) LIKE '%' || @query || '%' ", _connection))
            {
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@query", uppercaseQuery);
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Converto la entry del database in una stazione
                        IUtente utenteCorrente = Utente.ConvertiRigaInUtente(reader);
                        if (utenteCorrente != null)
                        {
                            utenti.Add(utenteCorrente);
                        }
                    }
                }
            }

            return utenti;
        }

        public bool Registra(Utente utente)
        {
            // TODO Aggiungere il log dell'operazione

            int risultato = -1;
            using (SQLiteCommand cmd = new SQLiteCommand(_connection))
            {
                // Preparo la query SQL
                cmd.CommandText = "INSERT INTO utenti(nome, cognome, email, username, hashPass, salt, loginRemoto, type) VALUES (@Nome, @Cognome, @Email, @Username, @HashPass, @Salt, @LoginRemoto, @Type)";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@Nome", utente.Nome);
                cmd.Parameters.AddWithValue("@Cognome", utente.Cognome);
                cmd.Parameters.AddWithValue("@Email", utente.Email);
                cmd.Parameters.AddWithValue("@Username", utente.Username);
                cmd.Parameters.AddWithValue("@HashPass", utente.HashPass);
                cmd.Parameters.AddWithValue("@Salt", utente.SaltPass);
                cmd.Parameters.AddWithValue("@LoginRemoto", utente.LoginRemoto ? 1 : 0);
                cmd.Parameters.AddWithValue("@Type", utente.GetType().Name);
                try
                {
                    risultato = cmd.ExecuteNonQuery();

                    // Aggiorno il valore dell'id dell'utente
                    if (risultato > 0)
                    {
                        utente.Id = _connection.LastInsertRowId;
                    }
                }
                catch (SQLiteException e)
                {
                    Console.WriteLine(e.ToString());
                }
            }

            return risultato > 0;
        }
    }
}