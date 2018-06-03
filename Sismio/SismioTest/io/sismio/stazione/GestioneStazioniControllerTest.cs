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
            /*if (File.Exists(@"C:\\sqlite\\test_stazioni.db"))
            {
                File.Delete(@"C:\\sqlite\\test_stazioni.db");
            }*/

            // Creo un nuovo controller
            gestioneStazioniController = new GestioneStazioniController("C:\\sqlite\\test_stazioni.db");
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
            //Assert.IsNull(gestioneStazioniController.Cerca("SELECT * FROM stazioni WHERE id = 1"));

            // Lo registro, e verifico che adesso esiste
            Assert.IsTrue(gestioneStazioniController.Registra(stazione));
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
            //Assert.IsTrue(gestioneStazioniController.Registra(stazione));

            stazione.Nome = "BolognaA2";
            stazione.IndirizzoDiRete = IPAddress.Parse("10.223.23.3");

            //Assert.IsTrue(gestioneStazioniController.Registra(stazione));

            IList<IStazione> stazioni = gestioneStazioniController.ListaTutti();

            foreach (var s in stazioni)
            {
                Console.WriteLine(s);
            }

            //Assert.AreEqual(stazioni[0].Nome, "BolognaA1");
            //Assert.AreEqual(stazioni[1].Nome, "BolognaA2");
        }

        [Test]
        public void TestEliminaStazione()
        {
            // Ottengo la stazione
            IList<IStazione> stazioni = gestioneStazioniController.Cerca("SELECT * FROM stazioni WHERE id = 6");
            Assert.IsNotNull(stazioni);

            // Lo elimino
            Assert.IsTrue(gestioneStazioniController.Elimina((Stazione)stazioni.ElementAt(0)));

            // Verifico che sia stata eliminato
            //stazioni = gestioneStazioniController.Cerca("SELECT * FROM stazioni WHERE id = 1");
            //Assert.IsNull(stazioni);
        }

        [TearDown]
        public void TearDown()
        {
            // Elimino il controller ed il database
            gestioneStazioniController.Dispose();
            gestioneStazioniController = null;
            //File.Delete(@"C:\\sqlite\\test_stazioni.db");
        }
    }
}
