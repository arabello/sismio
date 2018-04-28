using io.sismio.analysis;
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

        void AddAnalysis(IAnalysis analysis);

        void OnDataAvailable(int[] data);

        void Mainloop();

        string GetLocation();

        void Dispose();
    }
}
