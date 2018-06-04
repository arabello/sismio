using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Sismio.io.sismio.stazione;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace SismioTest.io.sismio.stazione
{
    [TestFixture]
    public class GestioneStazioniControllerTest
    {
        private IGestioneStazioniController gestioneStazioniController = null;

        [SetUp]
        public void SetUp()
        {
            // Se il database esiste, lo elimino
            if (File.Exists(@"test_stazioni.db"))
            {
                File.Delete(@"test_stazioni.db");
            }

            // Creo un nuovo controller
            gestioneStazioniController = new GestioneStazioniController("test_stazioni.db");
        }

        [TearDown]
        public void TearDown()
        {
            // Elimino il controller ed il database
            gestioneStazioniController.Dispose();
            gestioneStazioniController = null;
            File.Delete(@"test_stazioni.db");
        }

        [Test]
        public void TestRegistraStazione()
        {
            Stazione stazione = new Stazione
            {
                Nome = "BolognaA1",
                Locazione = "Bologna",
                IndirizzoDiRete = IPAddress.Parse("10.56.77.233"),
                Porta = 5555,
                ImprontaChiavePubblica = "aksjdada8s7d8a6da78sdEEeewrR"
            };

            // Verifico che non esista
            Assert.AreEqual(gestioneStazioniController.Cerca("bologna").Count, 0);

            // Lo registro, e verifico che adesso esiste
            Assert.IsTrue(gestioneStazioniController.Registra(stazione));

            // Verifico che esista
            Assert.AreEqual(gestioneStazioniController.Cerca("bologna").Count, 1);
        }

        [Test]
        public void TestListaTutti()
        {
            Stazione stazione = new Stazione
            {
                Nome = "BolognaA1",
                Locazione = "Bologna",
                IndirizzoDiRete = IPAddress.Parse("10.56.77.233"),
                Porta = 5555,
                ImprontaChiavePubblica = "aksjdada8s7d8a6da78sdEEeewrR"
            };

            // Lo registro, e verifico che adesso esiste
            Assert.IsTrue(gestioneStazioniController.Registra(stazione));
            Assert.AreEqual(gestioneStazioniController.Cerca("bolognaA1").Count, 1);

            Stazione stazione2 = new Stazione
            {
                Nome = "BolognaA2",
                Locazione = "Bologna",
                IndirizzoDiRete = IPAddress.Parse("10.223.23.3"),
                Porta = 5555,
                ImprontaChiavePubblica = "aksjdada8s7d8a6da78sdEEeewrR"
            };

            Assert.IsTrue(gestioneStazioniController.Registra(stazione2));
            Assert.AreEqual(gestioneStazioniController.Cerca("bolognaA2").Count, 1);

            IList<IStazione> stazioni = gestioneStazioniController.ListaTutti();

            Assert.AreEqual(stazioni[0].Nome, "BolognaA1");
            Assert.AreEqual(stazioni[1].Nome, "BolognaA2");
        }

        [Test]
        public void TestCerca()
        {
            Stazione stazione = new Stazione
            {
                Nome = "BolognaA1",
                Locazione = "Bologna",
                IndirizzoDiRete = IPAddress.Parse("10.56.77.233"),
                Porta = 5555,
                ImprontaChiavePubblica = "aksjdada8s7d8a6da78sdEEeewrR"
            };

            // Lo registro, e verifico che adesso esiste
            Assert.IsTrue(gestioneStazioniController.Registra(stazione));
            Assert.AreEqual(gestioneStazioniController.Cerca("bolognaA1").Count, 1);

            Stazione stazione2 = new Stazione
            {
                Nome = "BolognaA2",
                Locazione = "Bologna",
                IndirizzoDiRete = IPAddress.Parse("10.223.23.3"),
                Porta = 5555,
                ImprontaChiavePubblica = "aksjdada8s7d8a6da78sdEEeewrR"
            };

            Assert.IsTrue(gestioneStazioniController.Registra(stazione2));
            Assert.AreEqual(gestioneStazioniController.Cerca("bolognaA2").Count, 1);

            IList<IStazione> stazioni = gestioneStazioniController.Cerca("bolo");

            Assert.AreEqual(stazioni[0].Nome, "BolognaA1");
            Assert.AreEqual(stazioni[1].Nome, "BolognaA2");
        }

        [Test]
        public void TestEliminaStazione()
        {
            Stazione stazione = new Stazione
            {
                Nome = "BolognaA1",
                Locazione = "Bologna",
                IndirizzoDiRete = IPAddress.Parse("10.56.77.233"),
                Porta = 5555,
                ImprontaChiavePubblica = "aksjdada8s7d8a6da78sdEEeewrR"
            };

            // Lo registro, e verifico che adesso esiste
            Assert.IsTrue(gestioneStazioniController.Registra(stazione));
            Assert.AreEqual(gestioneStazioniController.Cerca("bolognaA1").Count, 1);

            // Lo elimino
            Assert.IsTrue(gestioneStazioniController.Elimina(stazione));

            // Verifico che sia stata eliminato
            Assert.AreEqual(gestioneStazioniController.Cerca("bolognaA1").Count, 0);
        }
    }
}
