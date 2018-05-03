namespace io.sismio.events
{
    public class PriorityFilter: IEventFilter
    {
        private Priority Priority;

        public PriorityFilter(Priority priority)
        {
            Priority = priority;
        }

        public bool Filter(Event evnt)
        {
            return evnt.Priority == Priority;
        }
    }
}