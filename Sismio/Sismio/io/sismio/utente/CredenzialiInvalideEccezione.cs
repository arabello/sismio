using System;

namespace Sismio.io.sismio.user
{
    public class CredenzialiInvalideEccezione : Exception
    {
        public CredenzialiInvalideEccezione()
        {
        }

        public CredenzialiInvalideEccezione(string message) : base(message)
        {
        }
    }
}