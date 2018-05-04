using Sismio.io.sismio.analysis;
using Sismio.io.sismio.sensor;

namespace Sismio.io.sismio.source
{
    public delegate void OnChunkAvailable(int[] data);

    public interface IDataSource
    {
        /**
         * null for local station, otherwise a remote station
         */
        Station Station { get; }
        void AddAnalysis(IAnalysis analysis);
        void Mainloop();
        void OnDataAvailable(int[] data);
        void Dispose();
    }
}
