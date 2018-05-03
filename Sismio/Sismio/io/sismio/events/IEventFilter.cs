using io.sismio.events;

namespace io.sismio.events
{
    public interface IEventFilter
    {
        bool Filter(Event evnt);
    }
}