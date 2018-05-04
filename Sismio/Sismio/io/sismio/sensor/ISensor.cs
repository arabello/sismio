using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace io.sismio.sensor
{
    public delegate void OnRawDataAvailable(int[] data);

    public interface ISensor
    {
        event OnRawDataAvailable SensorDataReceivers;

        void Mainloop();

        void Dispose();
    }
}
