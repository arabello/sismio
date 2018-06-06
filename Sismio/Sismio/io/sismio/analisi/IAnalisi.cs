using System.Collections.Generic;
using Sismio.io.sismio.eventi;
using Sismio.io.sismio.stazione;

namespace Sismio.io.sismio.analisi
{
    public delegate void OnRisultatoAnalisi(double valore); 

    public interface IAnalisi
    {
        event OnRisultatoAnalisi RicevitoriRisultato;
        void OnDatiDisponibili(int[] data);
        IStazione Stazione { get; set; }
        GestoreEventi GestoreEventi { get; set; }
    }
}