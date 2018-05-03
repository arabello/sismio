using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace io.sismio.source
{
    interface IDataSource
    {
        // TODO: add analysis

        void AddAnalysis();

        void Mainloop();

    }
}
