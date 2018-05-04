using System;

namespace Sismio.io.sismio.events
{
    public delegate void OnSeismicEvent(IEvent seismicEvent);

    public class EventManager
    {
        public event OnSeismicEvent SeismicEventReceivers;

        private readonly IEventRepository _eventRepository;

        public EventManager(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }

        public void RegisterEvent(IEvent evnt)
        {
            // Send the event to every receiver, while making sure they are not null
            SeismicEventReceivers?.Invoke(evnt);

            // Save the event using the Event Repository
            _eventRepository.StoreEvent(evnt);
        }
    }
}