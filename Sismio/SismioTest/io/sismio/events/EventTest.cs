using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sismio.io.sismio.events;

namespace SismioTest.io.sismio.events
{
    [TestClass]
    public class EventTest
    {
        public static IEvent createMockEvent()
        {
            return new Event("Magnitude", Priority.Fatal, "Sorry bro", 123456, null);
        }

        [TestMethod]
        public void TestEventId()
        {
            Event e = (Event) createMockEvent();
            Assert.AreEqual(e.Id, -1);

            e.Id = 12345;
            Assert.AreEqual(e.Id, 12345);
        }
    }
}
