﻿using System;
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
        private double _time = 0;

        public void CicloPrincipale()
        {
            while (!_dovrebbeFermarsi)
            {
                // Genero un buffer casuale
                int[] buffer = new int[DIMENSIONE_BUFFER];
                for (int i = 0; i < DIMENSIONE_BUFFER; i++)
                {
                    int picco = 0;
                    if (_random.Next(1, 1000) > 997)
                    {
                        picco = 300;
                    }
                    buffer[i] = (int)(Math.Cos(_time) * 20 + 500) + picco+ _random.Next(1,50);
                    _time += 0.1;
                }

                // Invio i dati
                RicevitoriDatiSensore?.Invoke(buffer);

                // Dormo un po
                System.Threading.Thread.Sleep(10);
            }
        }

        public void Ferma()
        {
            _dovrebbeFermarsi = true;
        }
    }
}
