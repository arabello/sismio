using System;

namespace Sismio.io.sismio.transmission
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