using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sismio.io.sismio.events;

namespace SismioTest.io.sismio.events
{
    [TestClass]
    public class EventFilterTest
    {
        [TestMethod]
        public void TestPriorityFilter()
        {
            IEventFilter filter = new PriorityFilter(Priority.Info);
            IEvent e = EventTest.createMockEvent();

            // Should be false
            Assert.IsFalse(filter.Filter(e));

            // Should be true
            IEventFilter filter2 = new PriorityFilter(Priority.Fatal);
            Assert.IsTrue(filter2.Filter(e));
        }

        [TestMethod]
        public void TestSearchFilter()
        {
            IEvent e = EventTest.createMockEvent();

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

        [TestMethod]
        public void TestTagFilter()
        {
            IEvent e = EventTest.createMockEvent();
            
            IEventFilter filter = new TagFilter("Magnitude");
            Assert.IsTrue(filter.Filter(e));

            IEventFilter filter2 = new TagFilter("Frequency");
            Assert.IsFalse(filter2.Filter(e));
        }

        [TestMethod]
        public void TestTimeRangeFilter()
        {
            IEvent e = EventTest.createMockEvent();

            IEventFilter filter = new TimeRangeFilter(123000, 123999);
            Assert.IsTrue(filter.Filter(e));

            IEventFilter filter2 = new TimeRangeFilter(123999, 999999);
            Assert.IsFalse(filter2.Filter(e));

            IEventFilter filter3 = new TimeRangeFilter(123000, 123123);
            Assert.IsFalse(filter3.Filter(e));
        }
    }
}
