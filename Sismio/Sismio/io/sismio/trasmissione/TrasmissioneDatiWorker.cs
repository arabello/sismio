using System.Collections.Concurrent;
using System.IO;
using System.Net.Security;
using System.Threading;
using Sismio.io.sismio.sensore;

namespace Sismio.io.sismio.trasmissione
{
    public class TrasmissioneDatiWorker
    {
        private ISensore _sensore;
        private SslStream _sslStream;
        private BinaryWriter _binaryWriter;

        private BlockingCollection<int> _dataQueue = new BlockingCollection<int>();

        private readonly Thread _networkingThread = null;

        public TrasmissioneDatiWorker(ISensore sensore, SslStream sslStream)
        {
            _sensore = sensore;
            _sslStream = sslStream;

            // Create the binary writer from the stream output
            _binaryWriter = new BinaryWriter(sslStream);

            // Create the networking thread 
            _networkingThread = new Thread(new ThreadStart(Run));

            // Register as a receiver to the sensore to receive
            // the realtime raw data
            sensore.RicevitoriDatiSensore += OnRisultatiGrezziDisponibili;
        }

        public void OnRisultatiGrezziDisponibili(int[] dati)
        {
            // Add all the values to the queue
            foreach (var value in dati)
            {
                _dataQueue.Add(value);
            }
        }

        public void Start()
        {
            // Start the networking thread
            _networkingThread.Start();
        }
        
        private void Run()
        {
            // Cycle reading the queue and sending the values
            // when they are available.
            while (true)
            {
                // Read and remove an element from the data queue
                // The call is BLOCKING, that means that if the queue
                // is empty, the loop suspend itself until a new element
                // is available.
                int currentValue = _dataQueue.Take();

                // Send the value through the secure stream
                _binaryWriter.Write(currentValue);
            }
        }
    }
}