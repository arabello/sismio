using io.sismio.sensor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace io.sismio.sensor
{
    class SerialSensor : ISensor
    {
        public string SerialPort { get; } // Readonly
        public int BaudRate { get; }  // Readonly

        public event OnRawDataAvailable SensorDataReceivers;

        public SerialSensor(string serialPort, int baudRate)
        {
            SerialPort = serialPort;
            BaudRate = baudRate;

            // Serial port initialization code here
        }

        public void Mainloop()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
