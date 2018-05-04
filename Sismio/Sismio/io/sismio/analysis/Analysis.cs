using System.Collections.Generic;

namespace Sismio.io.sismio.analysis
{
    public abstract class Analysis: IAnalysis
    {
        public event OnAnalysisResult ResultReceivers;
        public void OnChunkAvailable(int[] data)
        {
            // TODO: Implement
            throw new System.NotImplementedException();
        }

        /**
         * Circular buffer
         */
        private Queue<int> _buffer;
        private IDictionary<string, double[]> results;
        public abstract void PerformAnalysis(int[] buffer);
    }
}