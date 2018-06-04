using System;

namespace Sismio.io.sismio.trasmissione
{
    public class RispostaInvalidaEccezione : Exception
    {
        public RispostaInvalidaEccezione()
        {
        }

        public RispostaInvalidaEccezione(string messaggio) : base(messaggio)
        {
        }
    }
}