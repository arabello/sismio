using Sismio.io.sismio.analisi;
using Sismio.io.sismio.stazione;

namespace Sismio.io.sismio.sorgente
{
    public delegate void OnDatiDisponibili(int[] dati);

    public interface ISorgente
    {
        // Aggiunto rimuovi analisi

        /**
         * null for local stazione, otherwise a remote stazione
         */
        IStazione Stazione { get; }
        void AggiungiAnalisi(IAnalisi analisi);
        void RimuoviAnalisi(IAnalisi analisi);
        void CicloPrincipale();
        void Ferma();
    }
}
