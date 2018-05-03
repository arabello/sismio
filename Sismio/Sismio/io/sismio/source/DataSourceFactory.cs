using io.sismio.sensor;
using io.sismio.source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
