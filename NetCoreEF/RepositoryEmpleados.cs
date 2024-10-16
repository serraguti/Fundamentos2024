using NetCoreEF.Data;
using NetCoreEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreEF
{
    public class RepositoryEmpleados
    {
        //ESTA CLASE DEBE UTILIZAR EL DBCONTEXT PARA LAS CONSULTAS
        private EmpleadosContext context;

        //EL OBJETO CONTEXT NO LO CREAREMOS NOSOTROS AQUI, SINO 
        //QUE NOS LO PROPORCIONARA NUESTRO CONTAINER MEDIANTE INYECCION
        //DE DEPENDENCIAS
        public RepositoryEmpleados(EmpleadosContext context)
        {
            this.context = context;
        }

        public List<Empleado> GetEmpleados()
        {
            //CREAMOS UNA CONSULTA LINQ
            var consulta = from datos in this.context.Empleados
                           select datos;
            return consulta.ToList();
        }

        public List<Empleado> GetEmpleadosSalario(int salario)
        {
            var consulta = from datos in this.context.Empleados
                           where datos.Salario >= salario
                           select datos;
            return consulta.ToList();
        }
    }
}
