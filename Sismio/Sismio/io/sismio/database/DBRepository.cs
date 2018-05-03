namespace io.sismio.database
{
    public abstract class DBRepository
    {
        public DBRepository(string databasePath)
        {
            this.OpenDBConnection();
            //TODO: Implement
            throw new System.NotImplementedException();
        }

        ~DBRepository()
        {
            this.CloseDBConnection();
            //TODO: Implement
            throw new System.NotImplementedException();
        }

        private void OpenDBConnection()
        {
            //TODO: Implement
            throw new System.NotImplementedException();
        }

        private void CloseDBConnection()
        {
            //TODO: Implement
            throw new System.NotImplementedException();
        }
    }
}