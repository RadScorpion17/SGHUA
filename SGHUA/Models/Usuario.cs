using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGHUA.Models
{
    public class Usuario
    {
        public int IdUsuario { get; set; }

        public string username { get; set; }

        public string password { get; set; }

        public string nombre { get; set; }

        public string apellido { get ; set ; }

        public int role { get; set; }

        public string email { get; set; }

        public string telefono { get; set; }
    }
}
