using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace io.sismio.analysis
{
    class Analysis : IAnalysis
    {
        public event OnAnalysisResult ResultListeners;

        public void OnChunkAvailable(int[] data)
        {
            throw new NotImplementedException();
        }
    }
}
