using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using Sismio.io.sismio.database;
using Sismio.io.sismio.stazione;

namespace Sismio.io.sismio.eventi
{
    // TODO
    public class StoricoController : DBController, IStoricoController
    {
        // COSE CHE HO CAMBIATO
        // Ho cambiato i tipi di ritorno di RegistraEvento

        public StoricoController(string percorsoDatabase) : base(percorsoDatabase)
        {
            // Crea la tabella eventi se non è gia presente
            CreaTabellaEventiSeNonEsiste();
        }

        private void CreaTabellaEventiSeNonEsiste()
        {
            // TODO Aggiungere il log dell'operazione

            // Creo la tabella utenti se non esiste già
            using (SQLiteCommand cmd = new SQLiteCommand("CREATE TABLE IF NOT EXISTS eventi (" +
                                                         "id INTEGER PRIMARY KEY AUTOINCREMENT, " +
                                                         "tag VARCHAR(100) NOT NULL," +
                                                         "priorita INTEGER NOT NULL," +
                                                         "messaggio VARCHAR(200) NOT NULL," +
                                                         "timestamp INTEGER NOT NULL," +
                                                         "stazione INTEGER," +
                                                         "FOREIGN KEY(stazione) REFERENCES stazioni(id)" +
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

        public bool RegistraEvento(EventoSismico evento)
        {
            int risultato = -1;
            using (SQLiteCommand cmd = new SQLiteCommand(_connection))
            {
                // Preparo la query SQL
                cmd.CommandText = "INSERT INTO eventi(tag, priorita, messaggio, timestamp, stazione) VALUES (@Tag, @Priorita, @Messaggio, @Timestamp, @Stazione)";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@Tag", evento.Tag);
                cmd.Parameters.AddWithValue("@Priorita", evento.Priorita);
                cmd.Parameters.AddWithValue("@Messaggio", evento.Messaggio);
                cmd.Parameters.AddWithValue("@Timestamp", evento.Timestamp);
                cmd.Parameters.AddWithValue("@Stazione", ((Stazione) evento.Stazione)?.Id);
                try
                {
                    risultato = cmd.ExecuteNonQuery();

                    // Aggiorno il valore dell'id dell'evento
                    if (risultato > 0)
                    {
                        evento.Id = _connection.LastInsertRowId;
                    }
                }
                catch (SQLiteException e)
                {
                    Console.WriteLine(e.ToString());
                }
            }

            return risultato > 0;
        }

        public IList<IEventoSismico> ListaEventi()
        {
            List<IEventoSismico> eventi = new List<IEventoSismico>();
            
            // Nella query effettuo una JOIN con la tabella stazioni per ottenere tutti i dati combinati
            using (SQLiteCommand cmd = new SQLiteCommand("SELECT eventi.id AS eventi_id, eventi.tag AS eventi_tag, " +
                                                         "eventi.priorita AS eventi_priorita, eventi.timestamp AS eventi_timestamp," +
                                                         "eventi.messaggio AS eventi_messaggio, stazioni.id AS stazioni_id, " +
                                                         "stazioni.nome AS stazioni_nome, " +
                                                         "stazioni.locazione AS stazioni_locazione, " +
                                                         "stazioni.indirizzoDiRete AS stazioni_indirizzoDiRete, " +
                                                         "stazioni.porta AS stazioni_porta, stazioni.impronta AS stazioni_impronta " +
                                                         "FROM eventi JOIN stazioni ON eventi.stazione = stazioni.id", _connection))
            {
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        IEventoSismico evento = EventoSismico.ConvertiRigaInEventoSismico(reader);
                        if (evento != null)
                        {
                            eventi.Add(evento);
                        }
                    }
                }
            }

            return eventi;
        }

        public IList<IEventoSismico> ListaEventi(IList<IFiltroEvento> filtri)
        {
            // Per filtrare la lista originale, converto la lista totale in un enumerabile
            IList<IEventoSismico> listaOriginale = ListaEventi();
            IEnumerable<IEventoSismico> output = listaOriginale.AsEnumerable();

            // Poi applico ogni filtro per scremare la collezione
            foreach (var filtro in filtri)
            {
                output = output.Where(evento => filtro.Filtra(evento));
            }

            // E infine riconverto in lista
            return output.ToList();
        }

        
    }
}