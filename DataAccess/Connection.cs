using Npgsql;

namespace DataAccess
{
    public abstract class Connection
    {
        private readonly string var;

        public Connection()
        {
            var = "Host=localhost;Username=postgres;Password=55197469;Database=consultorio";
        }

        protected NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(var);
        }
    }
}
