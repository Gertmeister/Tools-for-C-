using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace Tools_for_CSharp
{
    public static class SQLiteDataBaseManager
    {
        public static SQLiteConnection OpenConnection(string DBpath)
        {
            if (File.Exists(DBpath))
            {
                return new SQLiteConnection(DBpath+"; Version=3;");
            }
            else
            {
                return new SQLiteConnection(DBpath+"; Version=3;");
            }
        }
        public static void DBNonQuery(string query, SQLiteConnection dbConnection)
        {
            SQLiteCommand command = new SQLiteCommand(query,dbConnection);
            command.ExecuteNonQuery();
        }
    }
}
