using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NanoAdministrativo.Model
{
    public partial class db_Entities : DbContext
    {
        public db_Entities() : base(nameOrConnectionString: "cnxFacturacion") { }

        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Departamentos> Departamentos { get; set; }
    }

}
