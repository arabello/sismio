﻿using System.Collections.Generic;

namespace Sismio.io.sismio.analisi
{
    // TODO
    public abstract class Analisi: IAnalisi
    {
        public event OnRisultatiAnalisi RicevitoriRisultati;
        public void OnDatiDisponibili(int[] data)
        {
            // TODO: da sistemare per ottenere indietro il risultato
            Analizza(data);
        }

        private Queue<int> _buffer;
        private IDictionary<string, double[]> risultati;
        public abstract void Analizza(int[] buffer);
    }
}