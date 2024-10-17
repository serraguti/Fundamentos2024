using NetCoreEF.Data;
using NetCoreEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreEF.Repositories
{
    public class RepositoryDoctores
    {
        private EmpleadosContext context;

        public RepositoryDoctores(EmpleadosContext context)
        {
            this.context = context;
        }

        public List<Doctor> GetDoctores()
        {
            var consulta = from datos in this.context.Doctores
                           select datos;
            return consulta.ToList();
        }
    }
}
