using System.Collections.Generic;

namespace io.sismio.user
{
    public interface IAccountRepository
    {
        IList<IAccount> GeAccounts();
        void Store(IAccount account);
        void Delete(IAccount account);
        IAccount Authenticate(string user, string password);
    }
}