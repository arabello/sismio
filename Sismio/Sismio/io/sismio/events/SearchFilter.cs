using System;

namespace io.sismio.events
{
    public class SearchFilter: IEventFilter
    {
        private string query;

        public SearchFilter(string query)
        {
            this.query = query;
        }

        public bool Filter(Event evnt)
        {
            //TODO: Implement
            throw new NotImplementedException();
        }
    }
}