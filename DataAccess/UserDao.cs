using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Cache;
using System.Data;
using System.Data.SqlClient;
using Npgsql;

namespace DataAccess
{
    public class UserDao : Connection
    {
        public bool Login(string user, string password)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new NpgsqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM usuarios WHERE username=@user AND password=@pass";
                    command.Parameters.AddWithValue("@user",user);
                    command.Parameters.AddWithValue("@pass",password);
                    command.CommandType = CommandType.Text;
                    NpgsqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while(reader.Read())
                        {
                            ActiveUser.IdUser = reader.GetInt32(0);
                            ActiveUser.UserName = reader.GetString(1);
                            ActiveUser.Password = reader.GetString(6);
                            ActiveUser.Nombre = reader.GetString(2);
                            ActiveUser.Apellido = reader.GetString(3);
                            ActiveUser.Posicion = reader.GetInt32(4);
                            ActiveUser.Email = reader.GetString(5);
                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
    }
}
