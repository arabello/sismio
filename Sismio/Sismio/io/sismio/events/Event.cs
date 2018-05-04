﻿namespace io.sismio.events
{
    public class Event
    {
        public long Id { get;  }
        public string Tag { get; }
        public Priority Priority { get; }
        public string Message { get; }
        public long Timestamp { get; }
        public string Station { get; }

        public Event(long id, string tag, Priority priority, string message, long timestamp, string station)
        {
            Id = id;
            Tag = tag;
            Priority = priority;
            Message = message;
            Timestamp = timestamp;
            Station = station;
        }
    }
}