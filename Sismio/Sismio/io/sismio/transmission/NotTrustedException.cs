using System;

namespace io.sismio.transmission
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