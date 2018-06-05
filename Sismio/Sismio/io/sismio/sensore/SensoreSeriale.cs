using System;
using System.IO.Ports;

namespace Sismio.io.sismio.sensore
{
    // TODO
    public class SensoreSeriale : ISensore
    {
        private const int TIMEOUT = 500;  // Timeout lettura sensore in millisecondi
        private const int DIMENSIONE_BUFFER = 10;

        public string PortaSeriale { get; }
        public int BaudRate { get; }

        private SerialPort _serialPort;

        private bool _dovrebbeFermarsi = false;

        public event OnRisultatiGrezziDisponibili RicevitoriDatiSensore;

        public SensoreSeriale(string portaSeriale, int baudRate)
        {
            PortaSeriale = portaSeriale;
            BaudRate = baudRate;

            // Inizializza la porta seriale
            _serialPort = new SerialPort();

            // Imporsta i parametri di lettura
            _serialPort.PortName = portaSeriale;
            _serialPort.BaudRate = baudRate;
            _serialPort.Parity = Parity.None;
            _serialPort.DataBits = 8;
            _serialPort.StopBits = StopBits.One;
            _serialPort.Handshake = Handshake.None;

            // Imposta i timeout
            _serialPort.ReadTimeout = TIMEOUT;
            _serialPort.WriteTimeout = TIMEOUT;

            ApriSeriale();
        }

        private void ApriSeriale()
        {
            // Apri la porta seriale
            _serialPort.Open();
        }

        public SensoreSeriale(string fileConfigurazione)
        {
            //TODO: Implement
            throw new System.NotImplementedException();
        }

        public void CicloPrincipale()
        {
            int[] buffer = new int[DIMENSIONE_BUFFER];
            int indiceCorrente = 0;

            while (!_dovrebbeFermarsi)
            {
                try
                {
                    // Leggi la riga
                    string line = _serialPort.ReadLine();
                    if (line != null)
                    {
                        line = line.Trim();
                        // Controllo della validità
                        if (line.StartsWith("START ") && line.EndsWith(" END"))
                        {
                            // Parsa il valore
                            int value = int.Parse(line.Split(' ')[1]);

                            // Riempi il buffer e, quando è pieno, notifica i ricevitori
                            if (indiceCorrente < DIMENSIONE_BUFFER)
                            {
                                buffer[indiceCorrente] = value;
                                indiceCorrente++;
                            }
                            else
                            {
                                // Invio i dati
                                RicevitoriDatiSensore?.Invoke(buffer);

                                // Resetto il buffer
                                indiceCorrente = 0;
                            }
                        }
                    }
                }
                catch (TimeoutException e)
                {
                    Console.WriteLine(e.ToString());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
            _serialPort.Close();
        }

        public void Ferma()
        {
            _dovrebbeFermarsi = true;
        }
    }
}
