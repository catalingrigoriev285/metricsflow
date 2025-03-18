using System;

namespace Database
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Database database = new Database("database.db", 3);

            database.CreateTable("users", new string[] { "id", "username", "password" });

            database.ExecuteQuery("INSERT INTO users (id, username, password) VALUES (1, 'admin', 'admin')");

            database.Close();
        }
    }
}
