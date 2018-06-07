using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
using Sismio.io.sismio.eventi;
using Sismio.io.sismio.stazione;

namespace Sismio.io.sismio.analisi
{
    // COSE CHE HO CAMBIATO
    // Cambiato risultato analisi
    // Aggiunto stazione e gestore eventi
    // Aggiunto sistema di coda bloccante e cicloprincipale per renderli concorrenti

    // TODO
    public abstract class Analisi: IAnalisi
    {
        private BlockingCollection<int[]> _dataQueue = new BlockingCollection<int[]>();

        public abstract event OnRisultatoAnalisi RicevitoriRisultato;

        private Thread _threadAnalisi = null;

        public void OnDatiDisponibili(int[] data)
        {
            // Aggiungo i dati alla coda
            _dataQueue.Add(data);
        }

        public void Avvia()
        {
            _threadAnalisi = new Thread(() => CicloPrincipale());
            _threadAnalisi.Start();
        }

        public void Ferma()
        {
            _threadAnalisi.Abort();
        }

        private void CicloPrincipale()
        {
            // Ciclo che legge la coda ed invia i valori quando disponibili
            while (true)
            {
                // Legge e rimuove un elemento dalla coda.
                // La chiamata è BLOCCANTE, quindi se la coda è vuota
                // il loop si sospende fino a quando non sono disponibili
                // altri valori
                int[] datiCorrenti = _dataQueue.Take();

                // Avvia l'analisi corrente
                Analizza(datiCorrenti);
            }
        }

        public IStazione Stazione { get; set; } = null;
        public GestoreEventi GestoreEventi { get; set; }

        public abstract void Analizza(int[] buffer);
    }
}