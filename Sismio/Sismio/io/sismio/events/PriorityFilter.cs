namespace Sismio.io.sismio.events
{
    public class PriorityFilter: IEventFilter
    {
        private Priority Priority;

        public PriorityFilter(Priority priority)
        {
            Priority = priority;
        }

        public bool Filter(IEvent seismicEvent)
        {
            return seismicEvent.Priority == Priority;
        }
    }
}