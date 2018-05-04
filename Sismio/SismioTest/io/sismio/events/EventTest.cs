using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sismio.io.sismio.events;

namespace SismioTest.io.sismio.events
{
    [TestClass]
    public class EventTest
    {
        [TestMethod]
        public void TestEventId()
        {
            Event e = new Event("Magnitude", Priority.Fatal, "Sory", 123456, null);
            Assert.AreEqual(e.Id, -1);

            e.Id = 12345;
            Assert.AreEqual(e.Id, 12345);
        }
    }
}
