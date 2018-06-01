using System.Collections.Generic;
using Sismio.io.sismio.stazione;

namespace Sismio.io.sismio.eventi
{
    public class EventoSismico: IEventoSismico
    {
        public string Tag { get; }
        public Priorita Priorita { get; }
        public string Messaggio { get; }
        public long Timestamp { get; }
        public Stazione Stazione { get; }
        public long Id { get; set; } = -1;

        public EventoSismico(string tag, Priorita priorita, string message, long timestamp, Stazione stazione)
        {
            Tag = tag;
            Priorita = priorita;
            Messaggio = message;
            Timestamp = timestamp;
            Stazione = stazione;
        }

        
    }
}