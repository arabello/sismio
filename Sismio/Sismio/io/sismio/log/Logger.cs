using Sismio.io.sismio.utente;
using System;
using System.IO;

namespace Sismio.io.sismio.log
{
    public sealed class Logger
    {
        private static readonly Logger instance = new Logger();
        private static string _path;

        static Logger()
        {
            string userName = Environment.UserName;
            _path = "C:\\Users\\"+userName+"\\Sismio";
            System.IO.Directory.CreateDirectory(_path);
            _path += "\\fileDiLog.txt";
        }

        public static Logger Instance
        {
            get
            {
                return instance;
            }
        }

        public static int Scrivi(IUtente utente, string messaggio)
        {
            var offset = 2*60*60; // TODO timezone vincolata
            long timestamp = new DateTimeOffset(DateTime.Now).ToUnixTimeSeconds()+offset;

            string linea = timestamp.ToString() + " " + utente.Username + " " + messaggio;

            FileStream fs = null;
            try
            {
                fs = new FileStream(_path, FileMode.Append);
                using (StreamWriter writer = new StreamWriter(fs))
                {
                    writer.WriteLine(linea);
                }
            }
            finally
            {
                if (fs != null)
                    fs.Dispose();
            }

            return linea.Length; // TODO void invece che int come tipo di ritorno? // TODO dovrei leggere i byte effettivamente scritti invece che quelli virtuali (lunghezza stringa)
        }
    }
}


