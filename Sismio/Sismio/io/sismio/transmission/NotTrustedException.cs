using System;

namespace Sismio.io.sismio.transmission
{
    public class NotTrustedException : Exception
    {
        public NotTrustedException()
        {
        }

        public NotTrustedException(string message) : base(message)
        {
        }
    }
}