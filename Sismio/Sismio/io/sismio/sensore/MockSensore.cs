using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sismio.io.sismio.sensore
{
    /// <summary>
    /// Questa classe permette di simulare un sensore che invia
    /// un flusso di valori casuali
    /// </summary>
    public class MockSensore : ISensore
    {
        private const int DIMENSIONE_BUFFER = 1;

        public event OnRisultatiGrezziDisponibili RicevitoriDatiSensore;

        private bool _dovrebbeFermarsi = false;
        private Random _random = new Random();

        public void CicloPrincipale()
        {
            while (!_dovrebbeFermarsi)
            {
                // Genero un buffer casuale
                int[] buffer = new int[DIMENSIONE_BUFFER];
                for (int i = 0; i < DIMENSIONE_BUFFER; i++)
                {
                    buffer[i] = _random.Next(1, 800);
                }

                // Invio i dati
                RicevitoriDatiSensore?.Invoke(buffer);

                // Dormo un po
                System.Threading.Thread.Sleep(100);
            }
        }

        public void Ferma()
        {
            _dovrebbeFermarsi = true;
        }
    }
}
