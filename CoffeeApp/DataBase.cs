using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace CoffeeApp
{
    public class DataBase
    {
        SQLiteConnection connection = new SQLiteConnection("Data Source=SQLite.db;Version=3;");
        public void openBase()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeBase()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public SQLiteConnection getConnection()
        {
            return connection;
        }
    }
}
