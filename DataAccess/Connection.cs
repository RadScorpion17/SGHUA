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
            var = "Host=localhost;Username=postgres;Password=;Database=postgres";
>>>>>>> c5941904ddbba48a6c1514a4816665ed15d86510
        }

        protected NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(var);
        }
    }
}
