using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using io.sismio.analysis;

namespace io.sismio.source
{
    abstract class DataSource : IDataSource
    {
        private List<IAnalysis> analysisList = new List<IAnalysis>();

        public void AddAnalysis(IAnalysis analysis)
        {
            analysisList.Add(analysis);
        }

        public void OnDataAvailable(int[] data)
        {
            foreach(IAnalysis analysis in analysisList)
            {
                analysis.OnChunkAvailable(data);
            }
        }

        abstract public void Mainloop();

        abstract public void Dispose();

        abstract public string GetLocation();
    }
}
