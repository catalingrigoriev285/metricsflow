using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Database;

namespace metricsflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Database.SQlite database = new Database.SQlite("database.db", 3);

            database.CreateTable("users", new string[] { "id", "username", "password" });

            database.ExecuteQuery("INSERT INTO users (id, username, password) VALUES (1, 'admin', 'admin')");


        }
    }
}
