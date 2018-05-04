using System;

namespace io.sismio.user
{
    public class InvalidCredentialException : Exception
    {
        public InvalidCredentialException()
        {
        }

        public InvalidCredentialException(string message) : base(message)
        {
        }
    }
}