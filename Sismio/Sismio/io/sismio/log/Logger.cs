using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace io.sismio.log
{
    private File logFile;
    private static Logger instance;

    class Logger
    {
        private Singleton() {
            
        }

        public void Log()
        {
            Console.Write(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile));
        }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Logger();
                }
                return instance;
            }
        }
    }
}
