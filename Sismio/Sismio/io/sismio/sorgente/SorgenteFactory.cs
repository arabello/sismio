using Sismio.io.sismio.sensore;
using Sismio.io.sismio.stazione;

namespace Sismio.io.sismio.sorgente
{
    class SorgenteFactory
    {
        // COSE CHE HO CAMBIATO
        // * Messo i metodi come statici
        // * non è necessario specificare porta e baud rate perchè il sensore è
        //   unico all'interno del sistema e dovrebbe caricarlo automaticamente
        public static ISorgente NuovaSorgenteLocale(ISensore sensore)
        {
            return new SensoreSorgenteAdapter(sensore);
        }

        public static ISorgente NuovaSorgenteRemota(IStazione stazione)
        {
            //TODO: Implement
            throw new System.NotImplementedException();
        }

        public static ISorgente NuovaSorgenteFile(string percorsoFile)
        {
            return new SorgenteFile(percorsoFile);
        }
    }
}
