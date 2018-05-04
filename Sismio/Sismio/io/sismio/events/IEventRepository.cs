using System.Collections.Generic;
using Sismio.io.sismio.events;

namespace Sismio.io.sismio.events
{
    public interface IEventRepository
    {
        void StoreEvent(IEvent evnt);
        IList<IEvent> GetEvents();
        IList<IEvent> GetEvents(IList<IEventFilter> filters);
    }
}