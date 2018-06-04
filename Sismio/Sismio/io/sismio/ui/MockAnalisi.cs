using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sismio.io.sismio.ui
{
    public delegate void OnRisultatiAnalisi(double[] risultati);

    class MockAnalisi
    {
        public event OnRisultatiAnalisi RicevitoriRisultati;
        private double[] _values;

        public MockAnalisi()
        {
            _values = new double[100];
            Random r = new Random();
            for (int i = 0; i < _values.Length; i++)
                _values[i] = r.NextDouble();
        }

        public void start(int updateRate)
        {
            new Thread(() =>
            {
                Thread.Sleep(updateRate);
                Thread.CurrentThread.IsBackground = true;
                Random r = new Random();
                while (true)
                {
                    var oldArray = _values;
                    Array.Copy(oldArray, 1, _values, 0, oldArray.Length - 1);
                    _values[_values.Length - 1] = r.NextDouble() * 10 * r.NextDouble();
                    RicevitoriRisultati(_values);
                    Thread.Sleep(updateRate);
                }
            }).Start();
        }
    }
}
