using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Cache
{
    public static class ActiveUser
    {
        public static int IdUser {get; set;}
        public static string UserName { get; set;}
        public static string Password { get; set;}
        public static string Nombre { get; set;}
        public static string Apellido { get; set;}
        public static int Rol { get; set;}
        public static string Email { get; set;}
        public static int Genero { get; set; }
        public static DateTime Nacimiento { get; set;}
        public static string Cedula { get; set; }
        public static string Ciudad { get; set; }
        public static string Telefono { get; set; }
    }
}
