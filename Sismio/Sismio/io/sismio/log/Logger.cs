using Sismio.io.sismio.utente;
using System;
using System.IO;

namespace Sismio.io.sismio.log
{
    /*
     * Singleton per la scrittura di log.
     * Il costruttore privato effettua tutto il necessario per la costruzione del path "dinamico".
     * Il path di destinazione sarà: C:\Users\<userName>\Sismio\fileDiLog.txt
     * 
     * Esempio di utilizzo:
     * Logger.Scrivi(pippo, "messaggio"); 
     * int bytes = Logger.Scrivi(pippo, "messaggio"); 
     * */
    public sealed class Logger
    {
        private static readonly Logger instance = new Logger();
        private static string _path;

        static Logger()
        {
            string userName = Environment.UserName;
            _path = "C:\\Users\\"+userName+"\\Sismio";
            // Crea la directory. Non fa nulla se già esistente
            System.IO.Directory.CreateDirectory(_path);
            // Creo il percorso finale del mio file
            _path += "\\fileDiLog.txt";
        }

        public static Logger Instance
        {
            get
            {
                return instance;
            }
        }

        /*
         * Metodo statico per la scrittura sul file di log.
         * Parametri: IUtente utente che effettua il logging, string messaggio da scrivere
         * Ritorno: intero che rappresenta il numero di bytes scritti sul file
         * */
        public static int Scrivi(IUtente utente, string messaggio)
        {
            // Offset: da UTC a CEST
            var offset = 2*60*60; // TODO timezone vincolata
            // Aggiungo l'offset per avere coerenza con la timezone. Opportuno decidere altro metodo oppure se va bene anche con timezone UTC
            long timestamp = new DateTimeOffset(DateTime.Now).ToUnixTimeSeconds()+offset;

            // Concateno le differenti parti della linea finale
            string linea = timestamp.ToString() + " " + utente.Username + " " + messaggio;

            FileStream fs = null;
            try
            {
                // Apro il file in append
                fs = new FileStream(_path, FileMode.Append);
                using (StreamWriter writer = new StreamWriter(fs))
                {
                    // Scrivo la linea
                    writer.WriteLine(linea);
                }
            }
            finally
            {
                if (fs != null)
                    fs.Dispose();
            }

            // TODO void invece che int come tipo di ritorno? 
            // TODO dovrei leggere i byte effettivamente scritti invece che quelli virtuali (lunghezza stringa)
            return linea.Length; 
        }
    }
}


