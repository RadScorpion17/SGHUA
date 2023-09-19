using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Cache
{
    public class Usuario
    {
        public int? IdUser { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public int? Rol { get; set; }
        public string? Email { get; set; }
        public int? Genero { get; set; }
        public DateTime? Nacimiento { get; set; }
        public string? Cedula { get; set; }
        public string? Ciudad { get; set; }
        public string? Telefono { get; set; }
    }
}