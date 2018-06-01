using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Sismio.io.sismio.database;

namespace Sismio.io.sismio.utente
{
    // Cosa ho modificato rispetto all'originale:
    // Ho fatto estendere anche da DBController come richiesto

    // TODO
    internal class GestioneUtentiController : DBController, IGestioneUtentiController
    {
        public GestioneUtentiController(string percorsoDatabase) : base(percorsoDatabase)
        {
            // Crea la tabella utenti se non è gia presente
            CreaTabellaUtentiSeNonEsiste();
        }

        private void CreaTabellaUtentiSeNonEsiste()
        {
            // Creo la tabella utenti se non esiste già
            using (SQLiteCommand cmd = new SQLiteCommand("CREATE TABLE IF NOT EXISTS utenti (" +
                                                         "id INTEGER PRIMARY KEY AUTOINCREMENT, " +
                                                         "nome VARCHAR(100)," +
                                                         "cognome VARCHAR(100)," +
                                                         "email VARCHAR(200)," +
                                                         "username VARCHAR(100)," +
                                                         "hashPass VARCHAR(64)," +
                                                         "salt VARCHAR(64)," +
                                                         "loginRemoto INTEGER," +
                                                         "type VARCHAR(30)" +
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

        public IUtente ValidaCredenziali(string username, string pass)
        {
            //TODO: Implement
            throw new System.NotImplementedException();
        }

        public void Elimina(IUtente utente)
        {
            throw new System.NotImplementedException();
        }

        public IList<IUtente> ListaTutti()
        {
            //TODO: Implement
            throw new System.NotImplementedException();
        }

        public void Registra(IUtente utente)
        {
            //TODO: Implement
            throw new System.NotImplementedException();
        }
    }
}