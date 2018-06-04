using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Sismio.io.sismio.eventi;
using Sismio.io.sismio.stazione;
using Sismio.io.sismio.utente;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace SismioTest.io.sismio.eventi
{
    [TestFixture]
    public class StoricoControllerTest
    {
        private IStoricoController storicoController = null;
        private IGestioneStazioniController gestioneStazioniController = null;

        [SetUp]
        public void SetUp()
        {
            // Se il database esiste, lo elimino
            if (File.Exists(@"test_database.db"))
            {
                File.Delete(@"test_database.db");
            }

            // Creo un nuovo controller
            storicoController = new StoricoController("test_database.db");
            gestioneStazioniController = new GestioneStazioniController("test_database.db");
        }

        [TearDown]
        public void TearDown()
        {
            // Elimino il controller ed il database
            storicoController.Dispose();
            storicoController = null;

            gestioneStazioniController.Dispose();
            gestioneStazioniController = null;

            File.Delete(@"test_database.db");
        }

        [Test]
        public void TestRegistraEvento()
        {
            Stazione stazione = new Stazione
            {
                Nome = "BolognaA1",
                Locazione = "Bologna",
                IndirizzoDiRete = IPAddress.Parse("10.56.77.233"),
                Porta = 5555,
                ImprontaChiavePubblica = "aksjdada8s7d8a6da78sdEEeewrR"
            };

            Assert.IsTrue(gestioneStazioniController.Registra(stazione));

            EventoSismico evento = new EventoSismico
            {
                Messaggio = "Magnitudo superata",
                Priorita = Priorita.Fatal,
                Stazione = stazione,
                Tag = "Magnitudo",
                Timestamp = 1234
            };

            Assert.IsTrue(storicoController.RegistraEvento(evento));

            // Verifico che sia stato salvato correttamente
            IEventoSismico evnt = storicoController.ListaEventi()[0];

            Assert.AreEqual(evento, evnt);
            Assert.AreEqual(evnt.Stazione, stazione);
        }

        [Test]
        public void TestListaEventi()
        {
            Stazione stazione = new Stazione
            {
                Nome = "BolognaA1",
                Locazione = "Bologna",
                IndirizzoDiRete = IPAddress.Parse("10.56.77.233"),
                Porta = 5555,
                ImprontaChiavePubblica = "aksjdada8s7d8a6da78sdEEeewrR"
            };

            Assert.IsTrue(gestioneStazioniController.Registra(stazione));

            EventoSismico evento = new EventoSismico
            {
                Messaggio = "Magnitudo superata",
                Priorita = Priorita.Fatal,
                Stazione = stazione,
                Tag = "Magnitudo",
                Timestamp = 1234
            };

            Assert.IsTrue(storicoController.RegistraEvento(evento));

            EventoSismico evento2 = new EventoSismico
            {
                Messaggio = "Frequenza superata",
                Priorita = Priorita.Info,
                Stazione = stazione,
                Tag = "Frequenza",
                Timestamp = 1235
            };

            Assert.IsTrue(storicoController.RegistraEvento(evento2));

            IList<IEventoSismico> eventi = storicoController.ListaEventi();
                
            Assert.AreEqual(eventi[0], evento);
            Assert.AreEqual(eventi[1], evento2);
        }

        [Test]
        public void TestLeggiEventiConFiltra()
        {
            Stazione stazione = new Stazione
            {
                Nome = "BolognaA1",
                Locazione = "Bologna",
                IndirizzoDiRete = IPAddress.Parse("10.56.77.233"),
                Porta = 5555,
                ImprontaChiavePubblica = "aksjdada8s7d8a6da78sdEEeewrR"
            };

            Assert.IsTrue(gestioneStazioniController.Registra(stazione));

            EventoSismico evento = new EventoSismico
            {
                Messaggio = "Magnitudo superata",
                Priorita = Priorita.Fatal,
                Stazione = stazione,
                Tag = "Magnitudo",
                Timestamp = 1234
            };

            Assert.IsTrue(storicoController.RegistraEvento(evento));

            EventoSismico evento2 = new EventoSismico
            {
                Messaggio = "Frequenza superata",
                Priorita = Priorita.Info,
                Stazione = stazione,
                Tag = "Frequenza",
                Timestamp = 1235
            };

            Assert.IsTrue(storicoController.RegistraEvento(evento2));

            Assert.AreEqual(storicoController.ListaEventi(new List<IFiltroEvento> {new FiltroCerca("quenza")}).Count, 1);
            Assert.AreEqual(storicoController.ListaEventi(new List<IFiltroEvento> {new FiltroCerca("superata")}).Count, 2);
            Assert.AreEqual(storicoController.ListaEventi(new List<IFiltroEvento> {new FiltroCerca("superata"), new FiltroPriorita(Priorita.Fatal)}).Count, 1);
            Assert.AreEqual(storicoController.ListaEventi(new List<IFiltroEvento> {new FiltroIntervalloDiTempo(10, 1300)}).Count, 2);
            Assert.AreEqual(storicoController.ListaEventi(new List<IFiltroEvento> {new FiltroTag("Magnitudo")}).Count, 1);
        }
    }
}
