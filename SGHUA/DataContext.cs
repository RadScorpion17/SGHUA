using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGHUA
{
    public class DataContext:DbContext
    {
        protected override void Onconfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=ProyectoDB");
        }

    }
}
