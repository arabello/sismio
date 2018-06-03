using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sismio.io.sismio.database;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace SismioTest.io.sismio.database
{
    [TestClass]
    public class DbControllerTest
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

            DBController controller = new TestDbController(DbFilename);

            // The database should now exists
            Assert.IsTrue(File.Exists(DbFilename));

            // Close the connection and delete the file
            controller.Dispose();
            File.Delete(DbFilename);
        }
    }

    /// <summary>
    /// Used to test the DBController
    /// </summary>
    class TestDbController : DBController
    {
        public TestDbController(string percorsoDatabase) : base(percorsoDatabase)
        {
        }
    }
}
