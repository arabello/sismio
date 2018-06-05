using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sismio.io.sismio.ui
{
    public delegate void OnRisultatiAnalisi(double newValue);

    class MockAnalisi
    {
        public event OnRisultatiAnalisi RicevitoriRisultati;
        private Thread _thread;

        public MockAnalisi()
        {
        }

        public void start(int updateRate)
        {
            _thread = new Thread(() =>
            {
                Thread.Sleep(updateRate);
                Thread.CurrentThread.IsBackground = true;
                Random r = new Random();
                while (true)
                {
                    RicevitoriRisultati(r.NextDouble() * r.NextDouble() * 100);
                    Thread.Sleep(updateRate);
                }
            });

            _thread.Start();
        }

        public void stop()
        {
            _thread.Abort();
            _thread = null;
        }
    }
}
