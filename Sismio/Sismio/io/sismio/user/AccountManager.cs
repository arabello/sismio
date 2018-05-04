using System;

namespace io.sismio.user
{
    public class AccountManager
    {
        private IAccount _activeUser;

        public IAccount GetActiveUser()
        {
            //TODO: Implement
            throw new NotImplementedException();
        }

        public bool Authenticate(string user, string password)
        {
            //TODO: Implement
            throw new NotImplementedException();
        }

        public bool Logout()
        {
            //TODO: Implement
            throw new NotImplementedException();
        }
    }
}