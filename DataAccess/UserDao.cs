using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Cache;
using System.Data;
using Npgsql;

namespace DataAccess
{
    //DAO = Data access object encargada de acceder a los datos de las tablas de la bd
    //Abstraer en el modelo y acceder a sus métodos
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
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", password);
                    command.CommandType = CommandType.Text;
                    NpgsqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            ActiveUser.IdUser = reader.GetInt32(0);
                            
                            ActiveUser.UserName = reader.GetString(1);
                            
                            ActiveUser.Password = reader.GetString(2);
                            
                            ActiveUser.Nombre = reader.GetString(3);
                            
                            ActiveUser.Apellido = reader.GetString(4);
                            
                            ActiveUser.Genero = reader.GetInt32(5);
                            
                            ActiveUser.Rol = reader.GetInt32(6);
                            
                            ActiveUser.Cedula = reader.GetString(7);
                            
                            ActiveUser.Ciudad = reader.GetString(8);
                            
                            ActiveUser.Nacimiento = reader.GetDateTime(9);
                            
                            ActiveUser.Telefono = reader.GetString(10);
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
        //TODO crear clase conexion
        public NpgsqlDataReader getUsersTable()
        {
            var connection = GetConnection();
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM usuarios";
            command.CommandType = CommandType.Text;
            NpgsqlDataReader reader = command.ExecuteReader();
            return reader;
        }

        public bool Guardar(Usuario user)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new NpgsqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO usuarios(nombre, apellido, cedula, telefono) VALUES (@nombre,@apellido,@cedula,@telefono)";
                    command.Parameters.Add(new NpgsqlParameter("@nombre", user.Nombre));
                    command.Parameters.Add(new NpgsqlParameter("@apellido", user.Apellido));
                    command.Parameters.Add(new NpgsqlParameter("@cedula", user.Cedula));
                    command.Parameters.Add(new NpgsqlParameter("@telefono", user.Telefono));
                    command.CommandType = CommandType.Text;
                    if (command.ExecuteNonQuery() < 1)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
        }

        public List<Usuario> Listar()
        {
            List<Usuario> olista = new List<Usuario>();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new NpgsqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT usuario_id, nombre, apellido,genero,rol,cedula,ciudad,nacimiento,telefono FROM usuarios";
                    command.CommandType = CommandType.Text;
                    NpgsqlDataReader reader = command.ExecuteReader();
                    while(reader.Read()) 
                    {
                        olista.Add(new Usuario()
                        {
                             IdUser = reader.GetInt32(0),
                             Nombre = reader.GetString(1),
                             Apellido = reader.GetString(2),
                             Genero = reader.GetInt32(3),
                             Rol = reader.GetInt32(4),
                             Cedula = reader.GetString(5),
                             Ciudad = reader.GetString(6),
                             Nacimiento = reader.GetDateTime(7),
                             Telefono = reader.GetString(8), 
                        });  
                    }
                }
            }
            return olista;
        }

        public bool Editar(Usuario user)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new NpgsqlCommand())
                {

                    command.Connection = connection;
                    command.CommandText = "UPDATE usuarios SET nombre=@nombre, apellido=@apellido, cedula=@cedula, telefono=@telefono WHERE usuario_id=@usuario_id";
                    command.Parameters.Add(new NpgsqlParameter("@nombre", user.Nombre));
                    command.Parameters.Add(new NpgsqlParameter("@apellido", user.Apellido));
                    command.Parameters.Add(new NpgsqlParameter("@cedula", user.Cedula));
                    command.Parameters.Add(new NpgsqlParameter("@telefono", user.Telefono));
                    command.Parameters.Add(new NpgsqlParameter("@usuario_id", user.IdUser));
                    command.CommandType = CommandType.Text;
                    if(command.ExecuteNonQuery() < 1)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
        }

        public bool Eliminar(Usuario user)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new NpgsqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "DELETE FROM usuarios WHERE usuario_id=@usuario_id";
                    command.Parameters.Add(new NpgsqlParameter("@usuario_id", user.IdUser));
                    if (command.ExecuteNonQuery() < 1)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
        }
    }
}
