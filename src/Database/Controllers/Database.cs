using System;
using System.Data.SQLite;
using System.IO;

namespace Database
{
    public class SQlite
    {
        public SQLiteConnection sQLiteConnection;

        public SQlite(string database_name, int database_version)
        {
            sQLiteConnection = new SQLiteConnection($"Data Source={database_name};Version={database_version};");
            sQLiteConnection.Open();

            ExecuteQuery("PRAGMA journal_mode=WAL;");
        }

        public void ExecuteQuery(string query)
        {
            using (SQLiteCommand sQLiteCommand = new SQLiteCommand(query, sQLiteConnection))
            {
                sQLiteCommand.ExecuteNonQuery();
            }
        }

        public void CreateTable(string table_name, string[] columns)
        {
            string query = $"CREATE TABLE IF NOT EXISTS {table_name} (";
            for (int i = 0; i < columns.Length; i++)
            {
                query += $"{columns[i]} TEXT";
                if (i != columns.Length - 1)
                {
                    query += ", ";
                }
            }
            query += ")";
            ExecuteQuery(query);
        }

        public void DeleteTable(string table_name)
        {
            string query = $"DROP TABLE IF EXISTS {table_name}";
            ExecuteQuery(query);
        }

        public void Close()
        {
            if (sQLiteConnection != null)
            {
                sQLiteConnection.Close();
                sQLiteConnection.Dispose();
            }
        }
    }
}
