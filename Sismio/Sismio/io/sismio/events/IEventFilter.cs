using Sismio.io.sismio.events;

namespace Sismio.io.sismio.events
{
    public interface IEventFilter
    {
        bool Filter(IEvent seismicEvent);
    }
}