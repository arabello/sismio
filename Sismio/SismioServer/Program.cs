using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Sismio.io.sismio.sensore;
using Sismio.io.sismio.trasmissione;
using Sismio.io.sismio.utente;

namespace SismioServer
{
    class Program
    {
        static void Main(string[] args)
        {
            ISensore sensore = new MockSensore();
            //ISensore sensore = new SensoreSeriale("COM10", 74880);
            sensore.RicevitoriDatiSensore += dati => Console.WriteLine(String.Join(",", dati)); 

            // Creo il thread del sensore
            Thread threadSensore = new Thread(() => sensore.CicloPrincipale());
            threadSensore.Start();

            Utente utente = new UtenteNormale
            {
                Nome = "tizio",
                Cognome = "caio",
                Email = "tizio@caio.it",
                LoginRemoto = true,
                Username = "tizio"
            };
            utente.ImpostaPasswordDaOriginale("password");

            if (File.Exists("test_server.db"))
            {
                File.Delete("test_server.db");
            }

            IGestioneUtentiController gestioneUtentiController = new GestioneUtentiController("test_server.db");
            gestioneUtentiController.Registra(utente);

            // Avvio il server della stazione
            ServerStazione server = new ServerStazione(sensore, gestioneUtentiController, SismioServer.CertificatoRisorsa.certificato, "passwordsismio");
            server.Avvia();
        }
    }
}
