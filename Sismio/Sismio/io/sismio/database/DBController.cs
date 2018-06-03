using System;
using System.Data.SQLite;
using System.IO;

namespace Sismio.io.sismio.database
{
    // Per documentazione su sqlite multi-thread
    // https://www.sqlite.org/threadsafe.html

    /// <summary>
    /// This abstract class manages the basics of the interactions with a
    /// SQLite database and creates a new one if it doesn't exists.
    /// </summary>
    public abstract class DBController : IDisposable
    {
        private string _percorsoDatabase;
        protected SQLiteConnection _connection;

        public DBController(string percorsoDatabase)
        {
            _percorsoDatabase = percorsoDatabase;

            // Open the connection to the database
            this.ApriConnessioneDB();
        }

        public void Dispose()
        {
            // Close the connection with the database
            this.ChiudiConnessioneDB();
        }

        /// <summary>
        /// Open the connection with the SQLite database.
        /// If the database doesn't exists, it creates a new one.
        /// </summary>
        private void ApriConnessioneDB()
        {
            // If the database doesn't exist yet, create one.
            if (!File.Exists(_percorsoDatabase))
            {
                // Create a new database
                SQLiteConnection.CreateFile(_percorsoDatabase);
            }

            // Open the connection to the database
            _connection = new SQLiteConnection($"Data Source={_percorsoDatabase};Version=3;");
            _connection.Open();
        }

        /// <summary>
        /// Close the connection with the SQLite database.
        /// </summary>
        private void ChiudiConnessioneDB()
        {
            _connection.Close();
        }
    }
}