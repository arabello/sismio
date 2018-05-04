using System;

namespace Sismio.io.sismio.events
{
    public delegate void OnSeismicEvent(Event seismicEvent);

    public class EventManager
    {
        public event OnSeismicEvent SeismicEventReceivers;
       
        public void RegisterEvent(Event evnt)
        {
            //TODO: Implement
            throw new NotImplementedException();
        }
    }
}