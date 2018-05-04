using Sismio.io.sismio.sensor;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sismio.io.sismio.sensor
{
    public class SerialSensor : ISensor
    {
        public string SerialPort { get; }
        public int BaudRate { get; }

        public event OnRawDataAvailable SensorDataReceivers;

        public SerialSensor(string serialPort, int baudRate)
        {
            SerialPort = serialPort;
            BaudRate = baudRate;
            
            //TODO: Implement
            throw new System.NotImplementedException();
        }

        private void OpenSerial()
        {
            //TODO: Implement
            throw new System.NotImplementedException();
        }

        public SerialSensor(string configFile)
        {
            //TODO: Implement
            throw new System.NotImplementedException();
        }

        public void Mainloop()
        {
            //TODO: Implement
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            //TODO: Implement
            throw new System.NotImplementedException();
        }
    }
}
