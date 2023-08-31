﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGHUA.Coneccion_SQLite;
using System.Data.SQLite;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SGHUA.Logica
{
    public class PersonaLogica
    {
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;
        private static PersonaLogica? _instancia = null;
        private PersonaLogica() {

        }
        public static PersonaLogica Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new PersonaLogica();
                }
                return _instancia;
            }
        }
        public bool Guardar(Persona obj) {

            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena)) {
                conexion.Open();
                string query = "INSERT INTO Persona(Nombre,Apellido,Telefono) values (@Nombre,@Apellido,@Telefono)";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@Nombre", obj.Nombre));
                cmd.Parameters.Add(new SQLiteParameter("@Apellido", obj.Apellido));
                cmd.Parameters.Add(new SQLiteParameter("@Telefono", obj.Telefono));
                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1) {
                    respuesta = false;
                }
            }
            return respuesta;
        }

        public List<Persona> Listar()
        {
            List<Persona> olista = new List<Persona>();
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "select IdPersona,Nombre,Apellido,Telefono from Persona";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dr = cmd.ExecuteReader()) 
                {

                    while (dr.Read())
                    {

                        olista.Add(new Persona()
                        {
                            IdPersona = int.Parse(dr["IdPersona"].ToString()),
                            Nombre = dr["Nombre"].ToString(),
                            Apellido = dr["Apellido"].ToString(),
                            Telefono = dr["Telefono"].ToString(),
                        }) ;

                          
                        
                    }
                }
                
            }
            return olista;
        }

    }
}


