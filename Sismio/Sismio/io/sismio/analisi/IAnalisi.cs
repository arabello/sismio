using System.Collections.Generic;

namespace Sismio.io.sismio.analisi
{
    public delegate void OnRisultatiAnalisi(Dictionary<string, double[]> risultati); 

    public interface IAnalisi
    {
        event OnRisultatiAnalisi RicevitoriRisultati;
        void OnDatiDisponibili(int[] data);
    }
}