using System;
using Sismio.io.sismio.eventi;

namespace Sismio.io.sismio.analisi
{
    // TODO
    public class AnalisiMagnitudine: Analisi
    {
        public override event OnRisultatoAnalisi RicevitoriRisultato;

        private int[] Soglie = new int[] {550, 600, 650, 700, 800};

        public override void Analizza(int[] buffer)
        {
            // Trova il massimo elemento
            int max = -1;
            for (int i = 0; i < buffer.Length; i++)
            {
                if (buffer[i] > max)
                {
                    max = buffer[i];
                }
            }

            // Verifico se il massimo supera una soglia
            int indiceSoglia = -1;
            for (int i = 0; i < Soglie.Length; i++)
            {
                if (max > Soglie[i])
                {
                    indiceSoglia = i;
                }
            }

            // Se la supera, creo un evento
            if (indiceSoglia >= 0)
            {
                Priorita priorita = (Priorita) indiceSoglia;
                //Console.WriteLine(priorita);
                // TODO
            }

            // Notifica il risultato
            RicevitoriRisultato?.Invoke(max);
        }
    }
}