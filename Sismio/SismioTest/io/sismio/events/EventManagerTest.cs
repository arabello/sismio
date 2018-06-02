using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Sismio.io.sismio.eventi;

namespace SismioTest.io.sismio.events
{
    [TestClass]
    public class EventManagerTest
    {
        [TestMethod]
        public void TestEventManager()
        {
            IEventoSismico e = EventTest.createMockEvent();

            // Create a mock EventoSismico Repository
            Mock<IStoricoController> eventRepository = new Mock<IStoricoController>();

            GestoreEventi gestoreEventi = new GestoreEventi(eventRepository.Object);

            // Register two event receivers and make sure they are all called
            bool firstReceived = false;
            bool secondReceived = false;

            gestoreEventi.RicevitoriEventoSismico += (evnt) =>
            {
                // Make sure the received 
                Assert.AreEqual(e, evnt);
                firstReceived = true;
            };

            gestoreEventi.RicevitoriEventoSismico += (evnt) =>
            {
                // Make sure the received 
                Assert.AreEqual(e, evnt);
                secondReceived = true;
            };

            // Register the event
            gestoreEventi.NotificaEvento(e);

            Assert.IsTrue(firstReceived);
            Assert.IsTrue(secondReceived);

            // Check if the event controller has been called
            eventRepository.Verify(x => x.RegistraEvento(e), Times.Once());
        }
    }
}
