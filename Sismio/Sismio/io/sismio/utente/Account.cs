namespace Sismio.io.sismio.user
{
    public abstract class Account: IAccount
    {
        public string FirstName { get; set; }
        public string LastName { get; set;  }
        public string Email { get; set; }
        public bool RemoteLogin { get; set; }
        public string Username { get; set; }
        public string PassHash { get; set; }
        public string PassSalt { get; set; }
        public long Id { get; set; }

        protected Account(string firstName, string lastName, string email, bool remoteLogin, string username, string passHash, string passSalt)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            RemoteLogin = remoteLogin;
            Username = username;
            PassHash = passHash;
            PassSalt = passSalt;
        }

        public abstract bool CanManageAccounts();
        public abstract bool CanManageSources();
        public abstract bool CanManageStations();
    }
}