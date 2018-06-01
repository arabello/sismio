using Sismio.io.sismio.analisi;
using Sismio.io.sismio.sensore;

namespace Sismio.io.sismio.sorgente
{
    public delegate void OnDatiDisponibili(int[] dati);

    public interface ISorgente
    {
        /**
         * null for local stazione, otherwise a remote stazione
         */
        Station Stazione { get; }
        void AggiungiAnalisi(IAnalisi analisi);
        void CicloPrincipale();
        void Ferma();
    }
}
