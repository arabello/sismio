namespace Sismio.io.sismio.events
{
    public class TimeRangeFilter: IEventFilter
    {
        private long Start;
        private long End;

        public TimeRangeFilter(long start, long end)
        {
            Start = start;
            End = end;
        }

        public bool Filter(Event evnt)
        {
            return evnt.Timestamp >= Start && evnt.Timestamp <= End;
        }
    }
}