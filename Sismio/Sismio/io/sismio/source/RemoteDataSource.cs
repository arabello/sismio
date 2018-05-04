using System.Net.Security;
using io.sismio.sensor;

namespace io.sismio.source
{
    public class RemoteDataSource: DataSource
    {
        public override Station Station { get; }
        private SslStream _connection;

        public RemoteDataSource(SslStream connection)
        {
            _connection = connection;
            //TODO: Implement
            throw new System.NotImplementedException();
        }

        public override void Mainloop()
        {
            //TODO: Implement
            throw new System.NotImplementedException();
        }

        public override void OnDataAvailable(int[] data)
        {
            //TODO: Implement
            throw new System.NotImplementedException();
        }

        public override void Dispose()
        {
            //TODO: Implement
            throw new System.NotImplementedException();
        }
    }
}