using System.Collections.Generic;

namespace io.sismio.analysis
{
    public delegate void OnAnalysisResult(Dictionary<string, double[]> results); 

    public interface IAnalysis
    {
        event OnAnalysisResult ResultReceivers;
        void OnChunkAvailable(int[] data);
    }
}