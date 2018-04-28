using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace io.sismio.analysis
{
    public delegate void OnAnalysisResult(Dictionary<string, double[]> results);

    interface IAnalysis
    {
        event OnAnalysisResult ResultListeners;

        void OnChunkAvailable(int[] data);
    }
}
