using System;

namespace Sismio.io.sismio.analisi
{
    // TODO
    public class AnalisiGrezza: Analisi
    {
        public override event OnRisultatoAnalisi RicevitoriRisultato;

        public override void Analizza(int[] buffer)
        {
            foreach (var i in buffer)
            {
                RicevitoriRisultato?.Invoke(i);
            }
        }
    }
}