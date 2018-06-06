using System;
using System.Collections.Concurrent;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Threading;
using Sismio.io.sismio.sensore;
using Sismio.io.sismio.user;
using Sismio.io.sismio.utente;

namespace Sismio.io.sismio.trasmissione
{
    public class TrasmissioneDatiWorker
    {
        // COSE CHE HO CAMBIATO
        // Prende in ingresso un gestioneUtentiController

        private ISensore _sensore;
        private SslStream _sslStream;
        private BinaryWriter _binaryWriter;
        private BinaryReader _binaryReader;

        private BlockingCollection<int> _dataQueue = new BlockingCollection<int>();

        private readonly Thread _threadNetwork = null;
        private readonly IGestioneUtentiController _gestioneUtentiController;

        public TrasmissioneDatiWorker(IGestioneUtentiController gestioneUtentiController, ISensore sensore, SslStream sslStream)
        {
            _gestioneUtentiController = gestioneUtentiController;

            _sensore = sensore;
            _sslStream = sslStream;

            // Crea i lettori e scrittori binari
            _binaryWriter = new BinaryWriter(sslStream);
            _binaryReader = new BinaryReader(sslStream);

            // Ottengo le credenziali utente
            string user = _binaryReader.ReadString();
            string pass = _binaryReader.ReadString();

            Console.WriteLine("Richiesta connessione per utente :{0}", user);

            // Verifico le credenziali
            // TODO Log della connessione remota
            IUtente utenteRemoto = gestioneUtentiController.ValidaCredenziali(user, pass);
            if (utenteRemoto != null)  // Credenziali accettate
            {
                // Invio la risposta
                _binaryWriter.Write("ACCEPT");

                Console.WriteLine("Connessione accettata");

                // Creo il thread di networking
                _threadNetwork = new Thread(new ThreadStart(Run));

                // Registra il worker come ricevitore del sensore per ricevere i dati
                // in tempo reale
                sensore.RicevitoriDatiSensore += OnRisultatiGrezziDisponibili;
            }
            else  // Credenziali non accettate
            {
                // Invio la risposta
                _binaryWriter.Write("INVALID");

                Console.WriteLine("Connessione non accettata");

                throw new CredenzialiInvalideEccezione("Le credenziali non sono valide");
            }
        }

        public void OnRisultatiGrezziDisponibili(int[] dati)
        {
            // Aggiungi tutti i valori alla coda
            foreach (var value in dati)
            {
                _dataQueue.Add(value);
            }
        }

        public void Start()
        {
            // Avvia il thread di networking
            _threadNetwork.Start();
        }
        
        private void Run()
        {
            try
            {
                // Ciclo che legge la coda ed invia i valori quando disponibili
                while (true)
                {
                    // Legge e rimuove un elemento dalla coda.
                    // La chiamata è BLOCCANTE, quindi se la coda è vuota
                    // il loop si sospende fino a quando non sono disponibili
                    // altri valori
                    int valoreCorrente = _dataQueue.Take();

                    // Invia i valori attraverso lo stream sicuro
                    _binaryWriter.Write(valoreCorrente);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}