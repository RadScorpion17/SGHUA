using Npgsql;

namespace DataAccess
{
    public abstract class Connection
    {
        private readonly string var;

        public Connection()
        {
            var = "Host=localhost;Username=postgres;Password=;Database=";
        }

        protected NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(var);
        }
    }
}
