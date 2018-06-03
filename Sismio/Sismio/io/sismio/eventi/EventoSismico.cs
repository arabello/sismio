using System;
using System.Data.SQLite;
using Sismio.io.sismio.stazione;

namespace Sismio.io.sismio.eventi
{
    public class EventoSismico: IEventoSismico
    {
        public string Tag { get; set; }
        public Priorita Priorita { get; set; }
        public string Messaggio { get; set; }
        public long Timestamp { get; set; }
        public IStazione Stazione { get; set; }
        public long Id { get; set; } = -1;

        public EventoSismico()
        {
        }

        public EventoSismico(string tag, Priorita priorita, string message, long timestamp, IStazione stazione)
        {
            Tag = tag;
            Priorita = priorita;
            Messaggio = message;
            Timestamp = timestamp;
            Stazione = stazione;
        }

        /// <summary>
        /// Utilizzato per convertire una riga di una query sql in un oggetto EventoSismico
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        public static EventoSismico ConvertiRigaInEventoSismico(SQLiteDataReader reader)
        {
            EventoSismico evento = new EventoSismico();

            // Popolo i campi dell'evento
            evento.Id = Convert.ToInt64(reader["id"]);
            evento.Messaggio = reader["messaggio"].ToString();
            evento.Priorita = (Priorita)Convert.ToInt32(reader["priorita"]);
            evento.Tag = reader["tag"].ToString();
            evento.Timestamp = Convert.ToInt64(reader["timestamp"]);
            evento.Stazione = stazione.Stazione.ConvertiRigaInStazione(reader);
            
            return evento;
        }
    }
}