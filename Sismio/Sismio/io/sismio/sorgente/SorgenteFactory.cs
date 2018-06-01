using Sismio.io.sismio.stazione;

namespace Sismio.io.sismio.sorgente
{
    // TODO
    class SorgenteFactory
    {
        public ISorgente NuovaSorgenteLocale(string portaSeriale, int baudRate)
        {
            //TODO: Implement
            throw new System.NotImplementedException();
        }

        public ISorgente NuovaSorgenteRemota(IStazione stazione)
        {
            //TODO: Implement
            throw new System.NotImplementedException();
        }

        public ISorgente NuovaSorgenteFile(string percorsoFile)
        {
            //TODO: Implement
            throw new System.NotImplementedException();
        }
    }
}
