using io.sismio.sensor;
using io.sismio.source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace io.sismio.source
{
    class DataSourceFactory
    {
        public IDataSource NewLocalSource(string serialPort, int baudRate)
        {
            // TODO
            return null;
        }

        // TODO
        public IDataSource NewRemoteSource(Station station)
        {
            return null;
        }
    }
}
