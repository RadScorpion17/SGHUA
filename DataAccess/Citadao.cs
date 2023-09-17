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
    public class Citadao : Connection
    {
        public void getcita(int id)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new NpgsqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM citas WHERE cita_id=@id";
                    command.Parameters.AddWithValue("@id", id);
                    command.CommandType = CommandType.Text;
                    NpgsqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Citas.CitaID = reader.GetInt32(0);
                            Citas.PacienteID = reader.GetInt32(2);  
                            Citas.MedicoID = reader.GetInt32(1);    

                        }

                    }

                }
            }
        }
    }
}
