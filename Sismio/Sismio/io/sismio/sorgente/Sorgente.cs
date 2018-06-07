using System.Collections.Generic;
using System.Threading;
using Sismio.io.sismio.analisi;
using Sismio.io.sismio.eventi;
using Sismio.io.sismio.stazione;

namespace Sismio.io.sismio.sorgente
{
    public abstract class Sorgente: ISorgente
    {
        // COSE CHE HO CAMBIATO
        // * ho rinominato la funzione NotificaDatiDisponibili perchè aveva
        //   lo stesso nome di una cosa completamente diversa
        // * ho aggiunto la dimensione buffer
        // * aggiunto gestore eventi

        protected const int DimensioneBuffer = 20;

        protected GestoreEventi _gestoreEventi;

        public event OnDatiDisponibili RicevitoriDati;

        public void AggiungiAnalisi(IAnalisi analisi)
        {
            analisi.Stazione = Stazione;
            analisi.GestoreEventi = _gestoreEventi;
            RicevitoriDati += analisi.OnDatiDisponibili;

            // Avvio il thread dell'analisi
            analisi.Avvia();
        }

        public void RimuoviAnalisi(IAnalisi analisi)
        {
            RicevitoriDati -= analisi.OnDatiDisponibili;
            analisi.Ferma();
        }

        protected void NotificaDatiDisponibili(int[] data)
        {
            // Notifica i dati disponibili a tutte le analisi
            RicevitoriDati?.Invoke(data);
        }

        public abstract IStazione Stazione { get; }

        public abstract void CicloPrincipale();

        public abstract void Ferma();
    }
}