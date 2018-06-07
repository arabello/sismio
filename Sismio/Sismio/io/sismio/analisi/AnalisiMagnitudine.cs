using System;
using Sismio.io.sismio.eventi;

namespace Sismio.io.sismio.analisi
{
    // TODO
    public class AnalisiMagnitudine: Analisi
    {
        private const int DistanzaMinimaTraAvvisi = 1000;  // In millisecondi
        private long _tempoUltimoAvviso = 0;

        public override event OnRisultatoAnalisi RicevitoriRisultato;

        private int[] Soglie = new int[] {2,3,5,7,8};

        public override void Analizza(int[] buffer)
        {
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
            if (indiceSoglia >= 0 && (tempoAttuale - _tempoUltimoAvviso) > DistanzaMinimaTraAvvisi)
            {
                EventoSismico evento = new EventoSismico
                {
                    Messaggio = "Magnitudo ha superato: "+valoreMagnitudine,
                    Priorita = (Priorita) indiceSoglia,
                    Stazione = Stazione,
                    Tag = "Magnitudo",
                    Timestamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds()
                };
                GestoreEventi.NotificaEvento(evento);
                _tempoUltimoAvviso = tempoAttuale;
            }

            // Notifica il risultato
            RicevitoriRisultato?.Invoke(valoreMagnitudine);
        }
    }
}