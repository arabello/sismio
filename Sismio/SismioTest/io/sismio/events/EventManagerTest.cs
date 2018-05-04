using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Sismio.io.sismio.events;

namespace SismioTest.io.sismio.events
{
    [TestClass]
    public class EventManagerTest
    {
        [TestMethod]
        public void TestEventManager()
        {
            IEvent e = EventTest.createMockEvent();

            // Create a mock Event Repository
            Mock<IEventRepository> eventRepository = new Mock<IEventRepository>();

            EventManager eventManager = new EventManager(eventRepository.Object);

            // Register two event receivers and make sure they are all called
            bool firstReceived = false;
            bool secondReceived = false;

            eventManager.SeismicEventReceivers += (evnt) =>
            {
                // Make sure the received 
                Assert.AreEqual(e, evnt);
                firstReceived = true;
            };

            eventManager.SeismicEventReceivers += (evnt) =>
            {
                // Make sure the received 
                Assert.AreEqual(e, evnt);
                secondReceived = true;
            };

            // Register the event
            eventManager.RegisterEvent(e);

            Assert.IsTrue(firstReceived);
            Assert.IsTrue(secondReceived);

            // Check if the event repository has been called
            eventRepository.Verify(x => x.StoreEvent(e), Times.Once());
        }
    }
}
