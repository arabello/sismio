using System;
using System.Collections.Generic;
using io.sismio.database;

namespace io.sismio.events
{
    public class DBEventRepository : DBRepository, IEventRepository
    {
        public DBEventRepository(string databasePath) : base(databasePath)
        {
            //TODO: Implement
            throw new NotImplementedException();
        }

        public void StoreEvent(Event evnt)
        {
            //TODO: Implement
            throw new NotImplementedException();
        }

        public IList<Event> GetEvents()
        {
            //TODO: Implement
            throw new NotImplementedException();
        }

        public IList<Event> GetEvents(IList<IEventFilter> filters)
        {
            //TODO: Implement
            throw new NotImplementedException();
        }

      
    }
}