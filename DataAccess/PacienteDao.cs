using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Cache;
using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;

namespace DataAccess
{
    public class PacienteDao : Connection
    {
        public void getPaciente(int id, string nombre, string apellido)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new NpgsqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM pacientes WHERE paciente_id=@id";
                    command.Parameters.AddWithValue("@id", id);
                    command.CommandType = CommandType.Text;
                    NpgsqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Pacientes.Id_Paciente = reader.GetInt32(0);
                            Pacientes.Nombre_Paciente = reader.GetString(1);
                            Pacientes.Apellido_Paciente = reader.GetString(2);

                        }
                        
                    }
                   
                }
            }
        }
    }
}
