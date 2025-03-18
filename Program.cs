using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database;
using static Database.SQLite;

namespace metricsflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SQLite database = new SQLite("database.db", 3);

            database.CreateTable("users", new string[] { "id", "username", "password" });

            database.ExecuteQuery("INSERT INTO users (id, username, password) VALUES (1, 'admin', 'admin')");


        }
    }
}
