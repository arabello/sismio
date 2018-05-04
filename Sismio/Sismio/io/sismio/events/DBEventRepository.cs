using System;
using System.Collections.Generic;
using Sismio.io.sismio.database;

namespace Sismio.io.sismio.events
{
    public class DBEventRepository : DBRepository, IEventRepository
    {
        public DBEventRepository(string databasePath) : base(databasePath)
        {
            //TODO: Implement
            throw new NotImplementedException();
        }

        public void StoreEvent(IEvent evnt)
        {
            //TODO: Implement
            throw new NotImplementedException();
        }

        public IList<IEvent> GetEvents()
        {
            //TODO: Implement
            throw new NotImplementedException();
        }

        public IList<IEvent> GetEvents(IList<IEventFilter> filters)
        {
            //TODO: Implement
            throw new NotImplementedException();
        }

      
    }
}