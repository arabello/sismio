using System;
using System.IO;
using Sismio.io.sismio.sensor;

namespace Sismio.io.sismio.source
{
    public class FileDataSource: DataSource
    {
        public override Station Station { get; } = null;
        private FileStream _fileStream;

        public FileDataSource(string filePath)
        {
            //TODO: Implement
            throw new NotImplementedException();
        }

        public override void Mainloop()
        {
            //TODO: Implement
            throw new System.NotImplementedException();
        }

        public override void OnDataAvailable(int[] data)
        {
            //TODO: Implement
            throw new System.NotImplementedException();
        }

        public override void Dispose()
        {
            //TODO: Implement
            throw new System.NotImplementedException();
        }
    }
}