using System.Net.Security;
using Sismio.io.sismio.sensore;

namespace Sismio.io.sismio.sorgente
{
    public class SorgenteRemota: Sorgente
    {
        public override Station Stazione { get; }
        private SslStream _connessione;

        public SorgenteRemota(SslStream connessione)
        {
            _connessione = connessione;
            //TODO: Implement
            throw new System.NotImplementedException();
        }

        public override void CicloPrincipale()
        {
            //TODO: Implement
            throw new System.NotImplementedException();
        }

        public override void OnDataAvailable(int[] data)
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