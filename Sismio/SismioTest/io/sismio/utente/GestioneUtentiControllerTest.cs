using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Sismio.io.sismio.utente;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace SismioTest.io.sismio.utente
{
    [TestFixture]
    public class GestioneUtentiControllerTest
    {
        private IGestioneUtentiController gestioneUtentiController = null;

        [SetUp]
        public void SetUp()
        {
            // Se il database esiste, lo elimino
            if (File.Exists(@"test_database.db"))
            {
                File.Delete(@"test_database.db");
            }

            // Creo un nuovo controller
            gestioneUtentiController = new GestioneUtentiController("test_database.db");
        }

        [TearDown]
        public void TearDown()
        {
            // Elimino il controller ed il database
            gestioneUtentiController.Dispose();
            gestioneUtentiController = null;
            File.Delete(@"test_database.db");
        }

        [Test]
        public void TestAdminCreatoCorrettamente()
        {
            IUtente admin = gestioneUtentiController.ValidaCredenziali("admin", "admin");
            Assert.IsNotNull(admin);
        }

        [Test]
        public void TestValidaCredenzialiDovrebbeRestituireNull()
        {
            IUtente admin = gestioneUtentiController.ValidaCredenziali("admin", "sbagliata");
            Assert.IsNull(admin);
        }

        [Test]
        public void TestEliminaUtente()
        {
            // Ottengo l'admin
            IUtente admin = gestioneUtentiController.ValidaCredenziali("admin", "admin");
            Assert.IsNotNull(admin);

            // Lo elimino
            Assert.IsTrue(gestioneUtentiController.Elimina((Utente) admin));

            // Verifico che sia stato eliminato
            admin = gestioneUtentiController.ValidaCredenziali("admin", "admin");
            Assert.IsNull(admin);
        }

        [Test]
        public void TestRegistraUtente()
        {
            Utente utente = new UtenteNormale
            {
                Nome="tizio",
                Cognome = "caio",
                Email = "tizio@caio.it",
                LoginRemoto = true,
                Username = "tizio"
            };
            utente.ImpostaPasswordDaOriginale("password");

            // Verifico che non esista
            Assert.IsNull(gestioneUtentiController.ValidaCredenziali("tizio", "password"));

            // Lo registro, e verifico che adesso esiste
            Assert.IsTrue(gestioneUtentiController.Registra(utente));
            IUtente utenteValidato = gestioneUtentiController.ValidaCredenziali("tizio", "password");
            Assert.IsNotNull(utenteValidato);

            // Mi assicuro che sia del tipo giusto
            Assert.IsInstanceOfType(utenteValidato, typeof(UtenteNormale), "L'utente è di tipo sbagliato");
        }

        [Test]
        public void TestListaTutti()
        {
            Utente utente = new UtenteNormale
            {
                Nome = "tizio",
                Cognome = "caio",
                Email = "tizio@caio.it",
                LoginRemoto = true,
                Username = "tizio"
            };
            utente.ImpostaPasswordDaOriginale("password");

            // Lo registro, e verifico che adesso esiste
            Assert.IsTrue(gestioneUtentiController.Registra(utente));

            IList<IUtente> utenti = gestioneUtentiController.ListaTutti();
            Assert.AreEqual(utenti[0].Username, "admin");
            Assert.AreEqual(utenti[1].Username, "tizio");
        }

        [Test]
        public void TestCerca()
        {
            Utente utente = new UtenteNormale
            {
                Nome = "tizio",
                Cognome = "caio",
                Email = "tizio@caio.it",
                LoginRemoto = true,
                Username = "tizio"
            };
            utente.ImpostaPasswordDaOriginale("password");

            // Lo registro, e verifico che adesso esiste
            Assert.IsTrue(gestioneUtentiController.Registra(utente));

            // Dovrebbe contenere Admin
            IList<IUtente> utenti = gestioneUtentiController.Cerca("dMin");
            Assert.AreEqual(utenti[0].Username, "admin");

            // Dovrebbe contenere tizio
            utenti = gestioneUtentiController.Cerca("@cAiO");
            Assert.AreEqual(utenti[0].Username, "tizio");
        }
    }
}
