using System;
using System.IO;

namespace Database
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SQLite database = new SQLite("database.db", 3);

            string query = File.ReadAllText($"{Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}/src/Database/Queries/create.sql");
            database.ExecuteQuery(query);

            database.Close();
        }
    }
}
