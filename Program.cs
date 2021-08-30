using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace SqliteDemo
{

    class Program
    {
        static void Main(string[] args)
        {
            var dbWork = new DbController("Data Source=MyDatabase.sqlite;Version=3;");
            var dbTest = new DbController("Data Source=MyDatabaseTest.sqlite;Version=3;");
            
            dbWork.Query(@"CREATE TABLE IF NOT EXISTS Tracking (
                                id INTEGER PRIMARY KEY AUTOINCREMENT, 
                                score INT)");
            dbTest.Query(@"CREATE TABLE IF NOT EXISTS TrackingTest (
                                id INTEGER PRIMARY KEY AUTOINCREMENT, 
                                score INT)");

            for (int i = 0; i < 10; i++)
            {
                dbWork.Query($"INSERT INTO Tracking (score) VALUES ({i})");
                dbTest.Query($"INSERT INTO TrackingTest (score) VALUES ({i + 1})");
            }

        }
    }
}
