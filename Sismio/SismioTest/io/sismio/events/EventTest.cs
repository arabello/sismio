using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sismio.io.sismio.eventi;

namespace SismioTest.io.sismio.events
{
    [TestClass]
    public class EventTest
    {
        public static IEventoSismico createMockEvent()
        {
            return new EventoSismico("Magnitude", Priorita.Fatal, "Sorry bro", 123456, null);
        }

        [TestMethod]
        public void TestEventId()
        {
            EventoSismico e = (EventoSismico) createMockEvent();
            Assert.AreEqual(e.Id, -1);

            e.Id = 12345;
            Assert.AreEqual(e.Id, 12345);
        }
    }
}
