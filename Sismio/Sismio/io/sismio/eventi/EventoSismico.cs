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
            evento.Id = Convert.ToInt64(reader["eventi_id"]);
            evento.Messaggio = reader["eventi_messaggio"].ToString();
            evento.Priorita = (Priorita)Convert.ToInt32(reader["eventi_priorita"]);
            evento.Tag = reader["eventi_tag"].ToString();
            evento.Timestamp = Convert.ToInt64(reader["eventi_timestamp"]);
            evento.Stazione = stazione.Stazione.ConvertiRigaInStazione(reader);
            
            return evento;
        }

        public override string ToString()
        {
            return $"{nameof(Tag)}: {Tag}, {nameof(Priorita)}: {Priorita}, {nameof(Messaggio)}: {Messaggio}, {nameof(Timestamp)}: {Timestamp}, {nameof(Stazione)}: {Stazione}, {nameof(Id)}: {Id}";
        }

        protected bool Equals(EventoSismico other)
        {
            return string.Equals(Tag, other.Tag) && Priorita == other.Priorita && string.Equals(Messaggio, other.Messaggio) && Timestamp == other.Timestamp && Equals(Stazione, other.Stazione) && Id == other.Id;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((EventoSismico) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (Tag != null ? Tag.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (int) Priorita;
                hashCode = (hashCode * 397) ^ (Messaggio != null ? Messaggio.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ Timestamp.GetHashCode();
                hashCode = (hashCode * 397) ^ (Stazione != null ? Stazione.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ Id.GetHashCode();
                return hashCode;
            }
        }
    }
}