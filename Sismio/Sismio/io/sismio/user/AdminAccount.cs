namespace io.sismio.user
{
    internal class AdminAccount: Account
    {
        
        public override bool CanManageAccounts()
        {
            return true;
        }

        public override bool CanManageSources()
        {
            return true;
        }

        public override bool CanManageStations()
        {
            return true;
        }

        public AdminAccount(string firstName, string lastName, string email, bool remoteLogin, string username, string passHash, string passSalt) : base(firstName, lastName, email, remoteLogin, username, passHash, passSalt)
        {
        }
    }
}