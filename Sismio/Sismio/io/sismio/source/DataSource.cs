using Sismio.io.sismio.analysis;
using Sismio.io.sismio.sensor;
using Sismio.io.sismio.source;

namespace Sismio.io.sismio.source
{
    public abstract class DataSource: IDataSource
    {
        public abstract Station Station { get; }

        public void AddAnalysis(IAnalysis analysis)
        {
            //TODO: Implement
            throw new System.NotImplementedException();
        }

        public abstract void Mainloop();

        public abstract void OnDataAvailable(int[] data);

        public abstract void Dispose();
    }
}