using Microsoft.Data.Sqlite;

namespace UnderRule.PersistanceService
{
    public class DatabaseInitializer
    {
        public void CreateDB()
        {
            // create a new database connection:
            SqliteConnection sqlite_conn = new SqliteConnection("Data Source=database.sqlite;Version=3;");

            // open the connection:
            sqlite_conn.Open();

            SqliteCommand sqlite_cmd = sqlite_conn.CreateCommand();

            // Let the SQLiteCommand object know our SQL-Query:
            sqlite_cmd.CommandText = "CREATE TABLE Player (id integer primary key, name varchar(100));";

            // Now lets execute the SQL ;-)
            sqlite_cmd.ExecuteNonQuery();
        }
    }
}
