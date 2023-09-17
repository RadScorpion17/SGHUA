using Npgsql;

namespace DataAccess
{
    public abstract class Connection
    {
        private readonly string var;

        public Connection()
        {
<<<<<<< HEAD
            var = "Host=localhost;Username=postgres;Password=258017;Database=postgres";
=======
            var = "Host=localhost;Username=postgres;Password=;Database=";
>>>>>>> 7ef8a5c3fed916a672381d446a3883ad56df37be
        }

        protected NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(var);
        }
    }
}