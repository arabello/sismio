using Sismio.io.sismio.analisi;
using Sismio.io.sismio.sensore;
using Sismio.io.sismio.sorgente;

namespace Sismio.io.sismio.sorgente
{
    public abstract class Sorgente: ISorgente
    {
        public event OnDatiDisponibili RicevitoriDati;

        public abstract Station Stazione { get; }

        public void AggiungiAnalisi(IAnalisi analisi)
        {
            //TODO: Implement
            throw new System.NotImplementedException();
        }

        protected void OnDatiDisponibili(int[] data)
        {
            //TODO: Implement
            throw new System.NotImplementedException();
        }

        public abstract void CicloPrincipale();

        public abstract void Ferma();
    }
}