using io.sismio.sensor;

namespace io.sismio.events
{
    public class Event: IEvent
    {
        public string Tag { get; }
        public Priority Priority { get; }
        public string Message { get; }
        public long Timestamp { get; }
        public Station Station { get; }
        public long Id { get; set;  }

        public Event(string tag, Priority priority, string message, long timestamp, Station station)
        {
            Tag = tag;
            Priority = priority;
            Message = message;
            Timestamp = timestamp;
            Station = station;
        }
    }
}