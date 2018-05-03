using System.Collections.Generic;
using io.sismio.events;

namespace io.sismio.events
{
    public interface IEventRepository
    {
        void StoreEvent(Event evnt);
        IList<Event> GetEvents();
        IList<Event> GetEvents(IList<IEventFilter> filters);
    }
}