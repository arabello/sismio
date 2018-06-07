using System;
using System.Globalization;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Sismio.io.sismio.analisi;
using Sismio.io.sismio.eventi;
using Sismio.io.sismio.log;
using Sismio.io.sismio.sensore;
using Sismio.io.sismio.sorgente;
using Sismio.io.sismio.stazione;
using Sismio.io.sismio.trasmissione;
using Sismio.io.sismio.user;
using Sismio.io.sismio.utente;

namespace Sismio
{
    static class Program
    {
        private const string PERCORSO_DATABASE = @"sismio_database.db";

        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Inizializzo il sensore
            ISensore sensore = new MockSensore();
            //ISensore sensore = new SensoreSeriale("COM10", 74880);
            //sensore.RicevitoriDatiSensore += dati => Console.WriteLine(String.Join(",", dati));

            // Creo il thread del sensore e lo avvio
            Thread threadSensore = new Thread(() => sensore.CicloPrincipale());
            threadSensore.Name = "Thread Sensore";
            threadSensore.Start();



            Stazione stazione = new Stazione
            {
                Nome = "BolognaA1",
                Locazione = "Bologna",
                IndirizzoDiRete = IPAddress.Parse("127.0.0.1"),
                Porta = 8001,
                ImprontaChiavePubblica = "E2C9153221FE658AFDCEBE095EE5D2392AF8C4AE"
            };

            // Inizializzo il gestore delle stazioni

            IGestioneStazioniController stazioniController = new GestioneStazioniController(PERCORSO_DATABASE);
            stazioniController.Registra(stazione);

            stazione.Nome = "ReggioEmiliaA1";
            stazione.Locazione = "Reggio Emilia";
            stazione.IndirizzoDiRete = IPAddress.Parse("10.1.45.230");
            stazione.Porta = 5555;

            stazioniController.Registra(stazione);

            // Inizializzo il gestore utenti

            IGestioneUtentiController gestioneUtentiController = new GestioneUtentiController(PERCORSO_DATABASE);
            AutenticazioneController autenticazioneController = new AutenticazioneController(gestioneUtentiController);

            // Aggiungo l'utente tizio
            Utente utente = new UtenteNormale
            {
                Nome = "tizio",
                Cognome = "caio",
                Email = "tizio@caio.it",
                LoginRemoto = true,
                Username = "tizio"
            };
            
            utente.ImpostaPasswordDaOriginale("password");
            if (gestioneUtentiController.ValidaCredenziali("tizio", "password") == null)
            {
                gestioneUtentiController.Registra(utente);
            }

            EventoSismico evento = new EventoSismico
            {
                Messaggio = "Frequenza",
                Priorita = Priorita.Fatal,
                Stazione = stazione,
                Tag = "Frequenza",
                Timestamp = 1234
            };
            IStoricoController storicoController = new StoricoController(PERCORSO_DATABASE);
            storicoController.RegistraEvento(evento);

            GestoreEventi gestoreEventi = new GestoreEventi(storicoController);
            gestoreEventi.RicevitoriEventoSismico += sismico => Console.WriteLine(sismico);

            // Avvio il server della stazione
            ServerStazione server = new ServerStazione(sensore, gestioneUtentiController, Sismio.CertificatoResource.certificato, "passwordsismio");
            server.Avvia();

            CreatoreConnessioni creatore = new CreatoreConnessioni(stazioniController);
            SorgenteFactory factory = new SorgenteFactory(creatore, sensore, gestoreEventi);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form loginForm = new Login(autenticazioneController, gestioneUtentiController, stazioniController, storicoController, factory);
            Application.Run(loginForm);
        }
    }

    internal class SismioServer
    {
    }
}
