using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Net;
using Sismio.io.sismio.database;

namespace Sismio.io.sismio.stazione
{
    public class GestioneStazioniController : DBController, IGestioneStazioniController
    {
        //private string _percorso;

        public GestioneStazioniController(string percorsoDatabase) : base(percorsoDatabase)
        {
            string sql = "CREATE TABLE stazione (id INT NOT NULL PRIMARY KEY, nome VARCHAR(20), locazione VARCHAR(100), indirizzoDiRete VARCHAR(20), porta INT, impronta VARCHAR(20))"; // TODO spostare // TODO ; alla fine delle query?
            SQLiteCommand command = new SQLiteCommand(sql, controller);
            command.ExecuteNonQuery();
        }

        public void EliminaStazione(IStazione stazione)
        {
            string sql = "DELETE FROM stazione WHERE nome = "+stazione.Nome+" AND locazione = "+stazione.Locazione;
            SQLiteCommand command = new SQLiteCommand(sql, controller);
            command.ExecuteNonQuery();
        }

        public IList<IStazione> Cerca(string query)
        {
            SQLiteCommand command = new SQLiteCommand(query, controller);
            SQLiteDataReader reader = command.ExecuteReader();
            Stazione stazione;
            IList<IStazione> result = new List<IStazione>();

            while (reader.Read())
            {
                stazione = new Stazione(reader["nome"], reader["locazione"], IPAddress.Parse(reader["ip"]), Int32.Parse(reader["porta"]), reader["impronta"]);
                result.Add(stazione);
            }

            return result;
        }

        public IList<IStazione> ListaTutti()
        {
            string sql = "SELECT * FROM stazione";
            SQLiteCommand command = new SQLiteCommand(sql, controller);
            SQLiteDataReader reader = command.ExecuteReader();
            Stazione stazione;
            IList<IStazione> result = new List<IStazione>();

            while (reader.Read())
            {
                stazione = new Stazione(reader["nome"], reader["locazione"], IPAddress.Parse(reader["ip"]), Int32.Parse(reader["porta"]), reader["impronta"]);
                result.Add(stazione);
            }

            return result;
        }

        public void RegistraStazione(IStazione stazione)
        {
            // _percorso = "C:\\Users\\" + System.Environment.UserName + "\\Sismio\\database\\stazione.sqlite";

            // DBController controller = new GestioneStazioniController(_percorso);

            string sql = "INSERT INTO stazione () VALUES ()";
            SQLiteCommand command = new SQLiteCommand(sql, controller);
            command.ExecuteNonQuery();
            
            //controller.Dispose();
        }
    }
}