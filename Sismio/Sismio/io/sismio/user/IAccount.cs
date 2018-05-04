namespace io.sismio.user
{
    public interface IAccount
    {
        string FirstName { get; }
        string LastName { get; }
        string Email { get; }
        bool RemoteLogin { get; }
        string Username { get; }
        string PassHash { get; }
        string PassSalt { get; }

        bool CanManageAccounts();
        bool CanManageSources();
        bool CanManageStations();
    }
}