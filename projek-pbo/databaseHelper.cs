using Npgsql;

namespace projek_pbo
{
    internal static class databaseHelper
    {
        private static readonly string connectionString =
            "Host=localhost;Port=5432;Database=agri-rent;Username=postgres;Password=1";

        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(connectionString);
        }
    }
}