using System;
using System.Net.Security;
using io.sismio.sensor;

namespace io.sismio.transmission
{
    public class DataTransmissionWorker
    {
        public ISensor Sensor { get; }
        public SslStream SslStream { get; }
        public event OnRawDataAvailable onRawDataAvailable;

        public DataTransmissionWorker(ISensor sensor, SslStream sslStream)
        {
            Sensor = sensor;
            SslStream = sslStream;
        }
        
        public void Run()
        {
            //TODO: Implement
            throw new NotImplementedException();
        }
    }
}