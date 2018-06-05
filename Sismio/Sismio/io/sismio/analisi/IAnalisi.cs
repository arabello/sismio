using System.Collections.Generic;

namespace Sismio.io.sismio.analisi
{
    public delegate void OnRisultatoAnalisi(double valore); 

    public interface IAnalisi
    {
        event OnRisultatoAnalisi RicevitoriRisultato;
        void OnDatiDisponibili(int[] data);
    }
}