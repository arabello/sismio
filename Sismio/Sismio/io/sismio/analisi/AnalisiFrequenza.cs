using System;
using System.Collections.Generic;

namespace Sismio.io.sismio.analisi
{
    // TODO
    public class AnalisiFrequenza: Analisi
    {


        private const int SogliaPicco = 800;
        private const int TempoDistanzaMinimo = 500;
        private const int TempoAnalisi = 30000;  // 30 secondi

        private long TempoUltimoPicco = 0;

        private Queue<long> codaPicchi = new Queue<long>();

        public override event OnRisultatoAnalisi RicevitoriRisultato;

        public override void Analizza(int[] buffer)
        {
            // Trovo il tempo attuale
            long tempoAttuale = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;

            // Trova il massimo elemento
            int max = -1;
            for (int i = 0; i < buffer.Length; i++)
            {
                if (buffer[i] > max)
                {
                    max = buffer[i];
                }
            }

            if (max > SogliaPicco && (tempoAttuale - TempoUltimoPicco) > TempoDistanzaMinimo)
            {
                codaPicchi.Enqueue(tempoAttuale);
                TempoUltimoPicco = tempoAttuale;
            }

            // Conto i picchi e dimensiono la coda
            if (codaPicchi.Count > 0 && (tempoAttuale - codaPicchi.Peek()) > TempoAnalisi)
            {
                codaPicchi.Dequeue();
            }

            int risultato = codaPicchi.Count;

            // Notifica il risultato
            RicevitoriRisultato?.Invoke(risultato);
        }
    }
}