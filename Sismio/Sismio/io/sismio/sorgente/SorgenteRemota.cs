using Sismio.io.sismio.stazione;
using System.Net.Security;

namespace Sismio.io.sismio.sorgente
{
    // TODO
    public class SorgenteRemota: Sorgente
    {
        public override IStazione Stazione { get; }
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

        public override void Ferma()
        {
            //TODO: Implement
            throw new System.NotImplementedException();
        }
    }
}