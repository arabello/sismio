using Sismio.io.sismio.analisi;
using Sismio.io.sismio.stazione;

namespace Sismio.io.sismio.sorgente
{
    public abstract class Sorgente: ISorgente
    {
        // COSE CHE HO CAMBIATO
        // * ho rinominato la funzione NotificaDatiDisponibili perchè aveva
        //   lo stesso nome di una cosa completamente diversa
        // * ho aggiunto la dimensione buffer

        protected const int DimensioneBuffer = 20;

        public event OnDatiDisponibili RicevitoriDati;

        public void AggiungiAnalisi(IAnalisi analisi)
        {
            RicevitoriDati += analisi.OnDatiDisponibili;
        }

        public void RimuoviAnalisi(IAnalisi analisi)
        {
            RicevitoriDati -= analisi.OnDatiDisponibili;
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