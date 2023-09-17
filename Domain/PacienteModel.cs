using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class PacienteModel
    {
        
        
            PacienteDao pacienteDao = new PacienteDao();

            public void getpaciente(int id, string nombre, string apellido)
            {
                pacienteDao.getPaciente(id,nombre,apellido );
            }
        
    }
}
