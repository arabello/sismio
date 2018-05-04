using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sismio.io.sismio.events;

namespace SismioTest.io.sismio.events
{
    [TestClass]
    public class EventFilterTest
    {
        static IEvent createMockEvent()
        {
            return new Event("Magnitude", Priority.Fatal, "Sory bro", 123456, null);
        }

        [TestMethod]
        public void TestPriorityFilter()
        {
            IEventFilter filter = new PriorityFilter(Priority.Info);
            IEvent e = createMockEvent();

            // Should be false
            Assert.IsFalse(filter.Filter(e));

            // Should be true
            IEventFilter filter2 = new PriorityFilter(Priority.Fatal);
            Assert.IsTrue(filter2.Filter(e));
        }

        [TestMethod]
        public void TestSearchFilter()
        {
            IEvent e = createMockEvent();

            // Should be false
            IEventFilter filter = new SearchFilter("yeah");
            Assert.IsFalse(filter.Filter(e));

            // Should be true
            IEventFilter filter2 = new SearchFilter("BRO");  // Test case insensitive
            Assert.IsTrue(filter2.Filter(e));

            // Should be true
            IEventFilter filter3 = new SearchFilter("gniTude");  // Test case insensitive
            Assert.IsTrue(filter3.Filter(e));
        }
    }
}
