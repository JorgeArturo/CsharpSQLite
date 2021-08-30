using System;
using System.Data.SQLite;

namespace SqliteDemo
{
    class DbController {

        private readonly string SqlRoute;
        private SQLiteConnection sqlConn;

        public DbController(string sqlRoute)
        {

            if (sqlRoute == null || sqlRoute == "")
            {
                throw new SystemException("The string input don't able be null");
            }
            SqlRoute = sqlRoute;
        }
        private void DbOpen() {

            sqlConn = new SQLiteConnection(SqlRoute);
            sqlConn.Open();

        }
        private void DbClose() {

            sqlConn.Close();

        }
        public void Query(string cmd)
        {
            try
            {
                DbOpen();

                var Cmd = new SQLiteCommand(cmd,sqlConn);
                Cmd.ExecuteNonQuery();

                DbClose();
            }
            catch (Exception)
            {

                throw new SystemException("It is not possible to do the perfoming of DB ") ;
            }

        }
  
    }
}
