using System;

namespace io.sismio.transmission
{
    public class CertificateNotFoundException : Exception
    {
        public CertificateNotFoundException()
        {
        }

        public CertificateNotFoundException(string message) : base(message)
        {
        }
    }
}