using Sismio.io.sismio.analysis;
using Sismio.io.sismio.sensore;
using Sismio.io.sismio.sorgente;

namespace Sismio.io.sismio.sorgente
{
    public abstract class Sorgente: ISorgente
    {
        public event OnDatiDisponibili RicevitoriDati;

        public abstract Station Stazione { get; }

        public void AggiungiAnalisi(IAnalysis analysis)
        {
            //TODO: Implement
            throw new System.NotImplementedException();
        }

        public abstract void CicloPrincipale();

        public abstract void OnDataAvailable(int[] data);

        public abstract void Ferma();
    }
}