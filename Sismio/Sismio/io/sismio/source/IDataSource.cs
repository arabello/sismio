using io.sismio.analysis;
using io.sismio.sensor;

namespace io.sismio.source
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
