using System.Collections.Generic;

namespace io.sismio.analysis
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
        private Dictionary<string, double[]> results;
        public abstract void PerformAnalysis(Queue<int> buffer);
    }
}