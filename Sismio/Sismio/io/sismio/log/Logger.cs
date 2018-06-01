using Sismio.io.sismio.utente;
using System;
using System.IO;

namespace Sismio.io.sismio.log
{
    class Logger
    {
        private Stream _fileDiLog;

        public Logger(Stream fileDiLog)
        {
            _fileDiLog = fileDiLog;
        }

        public int Scrivi(IUtente utente, string messaggio)
        {
            // TODO: Implement
            throw new NotImplementedException();
        }
    }
}
