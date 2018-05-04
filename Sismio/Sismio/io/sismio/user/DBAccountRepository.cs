using System.Collections.Generic;

namespace io.sismio.user
{
    internal class DBAccountRepository: IAccountRepository
    {
        public IList<IAccount> GeAccounts()
        {
            //TODO: Implement
            throw new System.NotImplementedException();
        }

        public void Store(IAccount account)
        {
            //TODO: Implement
            throw new System.NotImplementedException();
        }

        public void Delete(IAccount account)
        {
            //TODO: Implement
            throw new System.NotImplementedException();
        }

        public IAccount Authenticate(string user, string password)
        {
            //TODO: Implement
            throw new System.NotImplementedException();
        }
    }
}