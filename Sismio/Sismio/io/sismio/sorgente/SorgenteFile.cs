using Sismio.io.sismio.stazione;
using System;
using System.IO;

namespace Sismio.io.sismio.sorgente
{
    // TODO
    public class SorgenteFile: Sorgente
    {
        
        public override IStazione Stazione { get; } = null;

        // Dimensione del buffer di uscita
        private const int DimensioneBuffer = 10; 
        
        // Delay tra un valore ed un altro ( Millisecondi )
        private const int TempoSleep = 10;

        // Quando diventa vera, il ciclo principale si arresta
        private bool _dovrebbeFermarsi = false;
        private readonly string _percorsoFile;

        public SorgenteFile(string percorsoFile)
        {
            _percorsoFile = percorsoFile;

            // Verifico che il file esista
            if (!File.Exists(percorsoFile))
            {
                throw new FileNotFoundException("Il file non esiste");
            }
        }

        public override void CicloPrincipale()
        {
            int[] bufferCorrente = new int[DimensioneBuffer];
            int cursore = 0;

            // Leggo le righe una ad una
            System.IO.StreamReader file = new System.IO.StreamReader(_percorsoFile);
            do
            {
                string rigaCorrente;

                while ((rigaCorrente = file.ReadLine()) != null)
                {
                    if (rigaCorrente != null && rigaCorrente.Length > 0)
                    {
                        int valoreCorrente = Convert.ToInt32(rigaCorrente);
                        bufferCorrente[cursore] = valoreCorrente;
                        cursore++;

                        // Se il buffer è stato riempito, lo notifico alla sorgente
                        if (cursore >= DimensioneBuffer)
                        {
                            NotificaDatiDisponibili(bufferCorrente);
                            cursore = 0;
                        }

                        // Sleep per un piccolo periodo
                        System.Threading.Thread.Sleep(TempoSleep);
                    }
                }

                // Ritorno all'inizio del file per ricominciare la lettura
                file.DiscardBufferedData();
                file.BaseStream.Seek(0, System.IO.SeekOrigin.Begin);
            } while (!_dovrebbeFermarsi);

            file.Close();
        }

        public override void Ferma()
        {
            _dovrebbeFermarsi = true;
        }
    }
}