using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Citamodel 
    {
        Citadao citadao = new Citadao();
        public void getcita (int id)
        {
            citadao.getcita (id);

        }


    }
}
