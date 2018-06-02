using System;

namespace Sismio.io.sismio.trasmissione
{
    public class CertificatoNonTrovatoEccezione : Exception
    {
        public CertificatoNonTrovatoEccezione()
        {
        }

        public CertificatoNonTrovatoEccezione(string messaggio) : base(messaggio)
        {
        }
    }
}