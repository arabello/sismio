using System;

namespace io.sismio.events
{
    public delegate void OnEvent(Event evnt);

    public class EventManager
    {
        public event OnEvent EventReceivers;
       
        public void RegisterEvent(Event evnt)
        {
            //TODO: Implement
            throw new NotImplementedException();
        }
    }
}