namespace Sismio.io.sismio.analisi
{
    // TODO
    public class AnalisiFrequenza: Analisi
    {
        public override event OnRisultatoAnalisi RicevitoriRisultato;

        public override void Analizza(int[] buffer)
        {
            //TODO: Implement
            // Trova il massimo elemento
            int max = -1;
            for (int i = 0; i < buffer.Length; i++)
            {
                if (buffer[i] > max)
                {
                    max = buffer[i];
                }
            }

            // Notifica il risultato
            RicevitoriRisultato?.Invoke(max);
        }
    }
}