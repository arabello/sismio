using System;
using Sismio.io.sismio.sensor;

namespace Sismio.io.sismio.source
{
    public class SensorDataSourceAdapter: DataSource
    {
        private ISensor _sensor;
        public override Station Station { get; } = null;
    
        public SensorDataSourceAdapter(ISensor sensor)
        {
            _sensor = sensor;
            //TODO: Implement
            throw new NotImplementedException();
        }


        public override void Mainloop()
        {
            throw new NotImplementedException();
        }

        public override void OnDataAvailable(int[] data)
        {
            throw new NotImplementedException();
        }

        public override void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}