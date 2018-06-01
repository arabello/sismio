using System;

namespace Sismio.io.sismio.trasmissione
{
    public class NonFidatoEccezione : Exception
    {
        public NonFidatoEccezione()
        {
        }

        public NonFidatoEccezione(string messaggio) : base(messaggio)
        {
        }
    }
}