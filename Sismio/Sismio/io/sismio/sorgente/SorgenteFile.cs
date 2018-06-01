using Sismio.io.sismio.stazione;
using System;
using System.IO;

namespace Sismio.io.sismio.sorgente
{
    // TODO
    public class SorgenteFile: Sorgente
    {
        public override IStazione Stazione { get; } = null;
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