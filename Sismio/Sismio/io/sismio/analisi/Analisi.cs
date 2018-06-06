using System.Collections.Generic;
using Sismio.io.sismio.eventi;
using Sismio.io.sismio.stazione;

namespace Sismio.io.sismio.analisi
{
    // COSE CHE HO CAMBIATO
    // Cambiato risultato analisi
    // Aggiunto stazione e gestore eventi

    // TODO
    public abstract class Analisi: IAnalisi
    {
        public abstract event OnRisultatoAnalisi RicevitoriRisultato;

        public void OnDatiDisponibili(int[] data)
        {
            Analizza(data);
        }

        public IStazione Stazione { get; set; } = null;
        public GestoreEventi GestoreEventi { get; set; }

        public abstract void Analizza(int[] buffer);
    }
}