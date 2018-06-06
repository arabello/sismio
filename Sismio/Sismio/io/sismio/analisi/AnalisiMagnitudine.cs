using System;
using Sismio.io.sismio.eventi;

namespace Sismio.io.sismio.analisi
{
    // TODO
    public class AnalisiMagnitudine: Analisi
    {
        public override event OnRisultatoAnalisi RicevitoriRisultato;

        private int[] Soglie = new int[] {2,3,5,7,8};

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

            // Converto in magnitudo
            double valoreMagnitudine = Math.Abs(max - 500) / 50f;

            // Verifico se il massimo supera una soglia
            int indiceSoglia = -1;
            for (int i = 0; i < Soglie.Length; i++)
            {
                if (valoreMagnitudine> Soglie[i])
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
            RicevitoriRisultato?.Invoke(valoreMagnitudine);
        }
    }
}