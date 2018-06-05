using System.Collections.Generic;

namespace Sismio.io.sismio.analisi
{
    // COSE CHE HO CAMBIATO
    // Cambiato risultato analisi

    // TODO
    public abstract class Analisi: IAnalisi
    {
        public abstract event OnRisultatoAnalisi RicevitoriRisultato;

        public void OnDatiDisponibili(int[] data)
        {
            // TODO: da sistemare per ottenere indietro il risultato
            Analizza(data);
        }

        public abstract void Analizza(int[] buffer);
    }
}