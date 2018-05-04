using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Sismio.io.sismio.database;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace SismioTest.io.sismio.database
{
    [TestClass]
    public class DbRepositoryTest
    {
        public const string DbFilename = "testdatabase.db";

        public static void SetupDatabase()
        {
            // Make sure the database doesn't exist
            if (File.Exists(DbFilename))
            {
                // Delete the file
                File.Delete(DbFilename);
            }
        } 

        [TestMethod]
        public void TestDBRepositoryCreateDatabase()
        {
            SetupDatabase();

            // The database should not exists
            Assert.IsFalse(File.Exists(DbFilename));

            DBRepository repository = new TestDBRepository(DbFilename);

            // The database should now exists
            Assert.IsTrue(File.Exists(DbFilename));

            // Close the connection and delete the file
            repository.Dispose();
            File.Delete(DbFilename);
        }
    }

    /// <summary>
    /// Used to test the DBRepository
    /// </summary>
    class TestDBRepository : DBRepository
    {
        public TestDBRepository(string databasePath) : base(databasePath)
        {
        }
    }
}
