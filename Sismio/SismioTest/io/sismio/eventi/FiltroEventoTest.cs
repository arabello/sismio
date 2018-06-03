using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sismio.io.sismio.eventi;

namespace SismioTest.io.sismio.eventi
{
    [TestClass]
    public class FiltroEventoTest
    {
        [TestMethod]
        public void TestFiltroPriorita()
        {
            IFiltroEvento filter = new FiltroPriorita(Priorita.Info);
            IEventoSismico e = EventoSismicoTest.createMockEvent();

            // Should be false
            Assert.IsFalse(filter.Filtra(e));

            // Should be true
            IFiltroEvento filter2 = new FiltroPriorita(Priorita.Fatal);
            Assert.IsTrue(filter2.Filtra(e));
        }

        [TestMethod]
        public void TestFiltroCerca()
        {
            IEventoSismico e = EventoSismicoTest.createMockEvent();

            // Should be false
            IFiltroEvento filter = new FiltroCerca("yeah");
            Assert.IsFalse(filter.Filtra(e));

            // Should be true
            IFiltroEvento filter2 = new FiltroCerca("BRO");  // Test case insensitive
            Assert.IsTrue(filter2.Filtra(e));

            // Should be true
            IFiltroEvento filter3 = new FiltroCerca("gniTude");  // Test case insensitive
            Assert.IsTrue(filter3.Filtra(e));
        }

        [TestMethod]
        public void TestFiltroTag()
        {
            IEventoSismico e = EventoSismicoTest.createMockEvent();
            
            IFiltroEvento filter = new FiltroTag("Magnitude");
            Assert.IsTrue(filter.Filtra(e));

            IFiltroEvento filter2 = new FiltroTag("Frequency");
            Assert.IsFalse(filter2.Filtra(e));
        }

        [TestMethod]
        public void TestFiltroIntervalloDiTempo()
        {
            IEventoSismico e = EventoSismicoTest.createMockEvent();

            IFiltroEvento filter = new FiltroIntervalloDiTempo(123000, 123999);
            Assert.IsTrue(filter.Filtra(e));

            IFiltroEvento filter2 = new FiltroIntervalloDiTempo(123999, 999999);
            Assert.IsFalse(filter2.Filtra(e));

            IFiltroEvento filter3 = new FiltroIntervalloDiTempo(123000, 123123);
            Assert.IsFalse(filter3.Filtra(e));
        }
    }
}
