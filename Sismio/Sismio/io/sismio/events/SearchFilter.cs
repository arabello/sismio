using System;

namespace Sismio.io.sismio.events
{
    public class SearchFilter: IEventFilter
    {
        private string _query;

        public SearchFilter(string query)
        {
            this._query = query;
        }

        public bool Filter(IEvent seismicEvent)
        {
            return seismicEvent.Tag.IndexOf(_query, StringComparison.OrdinalIgnoreCase) >= 0
                   || seismicEvent.Message.IndexOf(_query, StringComparison.OrdinalIgnoreCase) >= 0;
        }
    }
}