using Sismio.io.sismio.sensor;
using System.Collections.Generic;

namespace Sismio.io.sismio.events
{
    public class Event: IEvent
    {
        public string Tag { get; }
        public Priority Priority { get; }
        public string Message { get; }
        public long Timestamp { get; }
        public Station Station { get; }
        public long Id { get; set; } = -1;

        public Event(string tag, Priority priority, string message, long timestamp, Station station)
        {
            Tag = tag;
            Priority = priority;
            Message = message;
            Timestamp = timestamp;
            Station = station;
        }

        public override bool Equals(object obj)
        {
            var @event = obj as Event;
            return @event != null &&
                   Tag == @event.Tag &&
                   Priority == @event.Priority &&
                   Message == @event.Message &&
                   Timestamp == @event.Timestamp &&
                   EqualityComparer<Station>.Default.Equals(Station, @event.Station) &&
                   Id == @event.Id;
        }

        public override int GetHashCode()
        {
            var hashCode = 741419350;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Tag);
            hashCode = hashCode * -1521134295 + Priority.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Message);
            hashCode = hashCode * -1521134295 + Timestamp.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Station>.Default.GetHashCode(Station);
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            return hashCode;
        }
    }
}