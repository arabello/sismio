using System;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using Sismio.io.sismio.user;

namespace Sismio.io.sismio.transmission
{
    public class StationServer
    {
        public const int ServerPort = 8001;

        private readonly X509Certificate2 _certificate;
        private readonly Thread _networkingThread = null;

        public StationServer(string certFile, string password)
        {
            // Make sure the certificate exists
            if (!File.Exists(certFile))
            {
                throw new CertificateNotFoundException("The specified certificate cannot be found.");
            }

            // Load the certificate file
            _certificate = new X509Certificate2(certFile, password, X509KeyStorageFlags.UserKeySet);

            // Create the networking thread
            _networkingThread = new Thread(new ThreadStart(Run));
        }

        public void Start()
        {
            // Start the networking thread
            _networkingThread.Start();
        }

        private void Run()
        {
            // Get the local ip address
            IPAddress ipAddress = IPAddress.Parse("127.0.0.1");

            // Initialize the tcp listener
            TcpListener tcpListener = new TcpListener(ipAddress, ServerPort);

            // Start listening to the specified port
            tcpListener.Start();

            // Endless loop to serve each request
            while (true)
            {
                // Accept a new connection
                TcpClient tcpClient = tcpListener.AcceptTcpClient();

                // Create a secure connection using a SslStream
                SslStream sslStream = new SslStream(tcpClient.GetStream(), false);
                sslStream.AuthenticateAsServer(_certificate, false, SslProtocols.Tls, true);

                // Create a new DataTransmissionWorker to handle the connection
                // TODO: inject the correct sensore
                DataTransmissionWorker worker = new DataTransmissionWorker(null, sslStream);
                
                // Start the worker thread
                worker.Start();
            }
        }
    }
} 