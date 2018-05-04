using io.sismio.sensor;

namespace io.sismio.source
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
