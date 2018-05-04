namespace io.sismio.user
{
    public class UserAccount: Account
    {
        public override bool CanManageAccounts()
        {
            return false;
        }

        public override bool CanManageSources()
        {
            return true;
        }

        public override bool CanManageStations()
        {
            return false;
        }

        public UserAccount(string firstName, string lastName, string email, bool remoteLogin, string username, string passHash, string passSalt) : base(firstName, lastName, email, remoteLogin, username, passHash, passSalt)
        {
        }
    }
}