using Sismio.io.sismio.sensor;

namespace Sismio.io.sismio.source
{
    class DataSourceFactory
    {
        public IDataSource NewLocalSource(string serialPort, int baudRate)
        {
            //TODO: Implement
            throw new System.NotImplementedException();
        }

        public IDataSource NewRemoteSource(Station station)
        {
            //TODO: Implement
            throw new System.NotImplementedException();
        }
    }
}
