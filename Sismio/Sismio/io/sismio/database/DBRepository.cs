using System;
using System.Data.SQLite;
using System.IO;

namespace Sismio.io.sismio.database
{
    /// <summary>
    /// This abstract class manages the basics of the interactions with a
    /// SQLite database and creates a new one if it doesn't exists.
    /// </summary>
    public abstract class DBRepository : IDisposable
    {
        private string _databasePath;
        private SQLiteConnection _connection;

        public DBRepository(string databasePath)
        {
            _databasePath = databasePath;

            // Open the connection to the database
            this.OpenDBConnection();
        }

        ~DBRepository()
        {
            Dispose();
        }

        public void Dispose()
        {
            // Close the connection with the database
            this.CloseDBConnection();
        }

        /// <summary>
        /// Open the connection with the SQLite database.
        /// If the database doesn't exists, it creates a new one.
        /// </summary>
        private void OpenDBConnection()
        {
            // If the database doesn't exist yet, create one.
            if (!File.Exists(_databasePath))
            {
                // Create a new database
                SQLiteConnection.CreateFile(_databasePath);
            }

            // Open the connection to the database
            _connection = new SQLiteConnection($"Data Source={_databasePath};Version=3;");
            _connection.Open();
        }

        /// <summary>
        /// Close the connection with the SQLite database.
        /// </summary>
        private void CloseDBConnection()
        {
            _connection.Close();
        }
    }
}