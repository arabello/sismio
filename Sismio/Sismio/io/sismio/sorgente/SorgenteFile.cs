using System;
using System.IO;
using Sismio.io.sismio.sensore;

namespace Sismio.io.sismio.sorgente
{
    public class SorgenteFile: Sorgente
    {
        public override Station Stazione { get; } = null;
        private FileStream _fileStream;

        public SorgenteFile(string percorsoFile)
        {
            //TODO: Implement
            throw new NotImplementedException();
        }

        public override void CicloPrincipale()
        {
            //TODO: Implement
            throw new System.NotImplementedException();
        }

        public override void Ferma()
        {
            //TODO: Implement
            throw new System.NotImplementedException();
        }
    }
}