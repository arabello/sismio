using System;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using Sismio.io.sismio.sensore;
using Sismio.io.sismio.user;
using Sismio.io.sismio.utente;

namespace Sismio.io.sismio.trasmissione
{
    // COSE CHE HO CAMBIATO
    // prende in ingresso un gestioneUtentiController
    // Prende in ingresso un sensore
    public class ServerStazione
    {
        public int PortaServer { get; set; } = 8001;

        private readonly ISensore _sensore;
        private readonly IGestioneUtentiController _gestioneUtentiController = null;
        private readonly X509Certificate2 _certificato;
        private Thread _threadNetwork = null;

        public ServerStazione(ISensore sensore, IGestioneUtentiController gestioneUtentiController, string certFile, string password)
        {
            _sensore = sensore;
            _gestioneUtentiController = gestioneUtentiController;

            // Assicurati che il certificato esista
            if (!File.Exists(certFile))
            {
                throw new CertificatoNonTrovatoEccezione("The specified certificate cannot be found.");
            }

            // Carica il certificato
            _certificato = new X509Certificate2(certFile, password, X509KeyStorageFlags.UserKeySet);
        }

        public ServerStazione(ISensore sensore, IGestioneUtentiController gestioneUtentiController, byte[] certBytes, string password)
        {
            _sensore = sensore;
            _gestioneUtentiController = gestioneUtentiController;

            // Carica il certificato
            _certificato = new X509Certificate2(certBytes, password, X509KeyStorageFlags.UserKeySet);
        }

        public void Avvia()
        {
            // Crea il thread di networking
            _threadNetwork = new Thread(() => Run());

            // Avvia il thread di networking
            _threadNetwork.Start();
        }

        private void Run()
        {
            // Ottieni l'indirizzo locale
            IPAddress ipAddress = IPAddress.Parse("127.0.0.1");

            // Avvia l'ascoltatore TCP
            TcpListener tcpListener = new TcpListener(ipAddress, PortaServer);

            // Inizia l'ascolto sulla porta specificata
            tcpListener.Start();

            // Loop infinito per servire tutte le richieste
            while (true)
            {
                // Accetta una nuova connessione
                TcpClient tcpClient = tcpListener.AcceptTcpClient();

                Console.WriteLine("Connessione ricevuta da :{0}", ((IPEndPoint) tcpClient.Client.RemoteEndPoint).Address.ToString());

                // Crea una connessione sicura utilizzando un SslStream
                SslStream sslStream = new SslStream(tcpClient.GetStream(), false);
                sslStream.AuthenticateAsServer(_certificato, false, SslProtocols.Tls, true);

                // Crea un nuovo Worker per gestire la trasmissione
                try
                {
                    TrasmissioneDatiWorker worker = new TrasmissioneDatiWorker(_gestioneUtentiController, _sensore, sslStream);

                    // Avvia il worker
                    worker.Start();
                }
                catch (CredenzialiInvalideEccezione e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }
    }
} 