using Sismio.io.sismio.analysis;
using Sismio.io.sismio.sensore;

namespace Sismio.io.sismio.sorgente
{
    public delegate void OnDatiDisponibili(int[] dati);

    public interface ISorgente
    {
        /**
         * null for local station, otherwise a remote station
         */
        Station Stazione { get; }
        void AggiungiAnalisi(IAnalysis analysis);
        void CicloPrincipale();
        void OnDataAvailable(int[] data);
        void Ferma();
    }
}
