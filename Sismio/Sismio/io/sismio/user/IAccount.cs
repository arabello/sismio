namespace Sismio.io.sismio.user
{
    public interface IAccount
    {
        string Username { get; }
        string PassHash { get; }
        string PassSalt { get; }

        bool CanManageAccounts();
        bool CanManageSources();
        bool CanManageStations();
    }
}