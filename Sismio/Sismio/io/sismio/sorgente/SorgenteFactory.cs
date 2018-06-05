using System.Net.Security;
using Sismio.io.sismio.sensore;
using Sismio.io.sismio.stazione;
using Sismio.io.sismio.trasmissione;

namespace Sismio.io.sismio.sorgente
{
    public class SorgenteFactory
    {
        // COSE CHE HO CAMBIATO
        // * non è necessario specificare porta e baud rate perchè il sensore è
        //   unico all'interno del sistema e dovrebbe caricarlo automaticamente
        // * aggiunto user e password alla sorgente remota
        // * aggiunto parametro sensore al costruttore

        private readonly CreatoreConnessioni creatoreConnessioni = null;
        private readonly ISensore _sensore;

        public SorgenteFactory(CreatoreConnessioni creatoreConnessioni, ISensore sensore)
        {
            this.creatoreConnessioni = creatoreConnessioni;
            _sensore = sensore;
        }

        public ISorgente NuovaSorgenteLocale()
        {
            return new SensoreSorgenteAdapter(_sensore);
        }

        public ISorgente NuovaSorgenteRemota(IStazione stazione, string user, string pass)
        {
            // Creo lo stream remoto
            SslStream stream = creatoreConnessioni.CreaConnessione(stazione, user, pass);

            // Creo la sorgente
            return new SorgenteRemota(stream);
        }

        public ISorgente NuovaSorgenteFile(string percorsoFile)
        {
            return new SorgenteFile(percorsoFile);
        }
    }
}
