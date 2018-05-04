using System.Collections.Generic;
using Sismio.io.sismio.events;

namespace Sismio.io.sismio.events
{
    public interface IEventRepository
    {
        void StoreEvent(Event evnt);
        IList<Event> GetEvents();
        IList<Event> GetEvents(IList<IEventFilter> filters);
    }
}