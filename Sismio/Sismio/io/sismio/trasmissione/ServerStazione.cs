using System.IO;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace Sismio.io.sismio.trasmissione
{
    // TODO
    public class ServerStazione
    {
        public const int PortaServer = 8001;

        private readonly X509Certificate2 _certificato;
        private readonly Thread _threadNetwork = null;

        public ServerStazione(string certFile, string password)
        {
            // Make sure the certificate exists
            if (!File.Exists(certFile))
            {
                throw new CertificatoNonTrovatoEccezione("The specified certificate cannot be found.");
            }

            // Load the certificate file
            _certificato = new X509Certificate2(certFile, password, X509KeyStorageFlags.UserKeySet);

            // Create the networking thread
            _threadNetwork = new Thread(new ThreadStart(Run));
        }

        public void Avvia()
        {
            // Start the networking thread
            _threadNetwork.Start();
        }

        private void Run()
        {
            // Get the local ip address
            IPAddress ipAddress = IPAddress.Parse("127.0.0.1");

            // Initialize the tcp listener
            TcpListener tcpListener = new TcpListener(ipAddress, PortaServer);

            // Start listening to the specified port
            tcpListener.Start();

            // Endless loop to serve each request
            while (true)
            {
                // Accept a new connection
                TcpClient tcpClient = tcpListener.AcceptTcpClient();

                // Create a secure connection using a SslStream
                SslStream sslStream = new SslStream(tcpClient.GetStream(), false);
                sslStream.AuthenticateAsServer(_certificato, false, SslProtocols.Tls, true);

                // Create a new DataTransmissionWorker to handle the connection
                // TODO: inject the correct sensore
                TrasmissioneDatiWorker worker = new TrasmissioneDatiWorker(null, sslStream);
                
                // Start the worker thread
                worker.Start();
            }
        }
    }
} 