using System;
using System.Net.Security;
using io.sismio.sensor;

namespace io.sismio.transmission
{
    public class DataTransmissionWorker
    {
        public ISensor Sensor { get; }
        public SslStream SslStream { get; }

        public DataTransmissionWorker(ISensor sensor, SslStream sslStream)
        {
            //TODO: Implement
            throw new NotImplementedException();
        }

        public void OnRawDataAvailable(int[] data)
        {
            //TODO: Implement
            throw new NotImplementedException();
        }
        
        public void Run()
        {
            //TODO: Implement
            throw new NotImplementedException();
        }
    }
}