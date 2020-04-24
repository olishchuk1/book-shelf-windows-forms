using System;
using Npgsql;

namespace BookShelf.db.DataBaseConnection
{
    public class SQLCon
    {
        private NpgsqlConnection npgsqlConnection;
        string connectionString = String.Format("Server={0};Port={1};" +
                    "User Id={2};Password={3};Database={4};",
                    "localhost", "5432", "postgres",
                    "1377fs", "publication");

        public void openConnection()
        {
            npgsqlConnection = new NpgsqlConnection(connectionString);
            npgsqlConnection.Open();
        }

        public void closeConnection()
        {
            npgsqlConnection.Close();
        }

        public NpgsqlConnection GetNpgsqlConnection()
        {
            return npgsqlConnection;
        }
    }
}
