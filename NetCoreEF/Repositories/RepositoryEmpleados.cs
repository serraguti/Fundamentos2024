using NetCoreEF.Data;
using NetCoreEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreEF.Repositories
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
            var consulta = from datos in context.Empleados
                           select datos;
            return consulta.ToList();
        }

        public List<Empleado> GetEmpleadosSalario(int salario)
        {
            var consulta = from datos in context.Empleados
                           where datos.Salario >= salario
                           select datos;
            return consulta.ToList();
        }

        public List<Empleado> GetEmpleadosOficio(string oficio)
        {
            var consulta = from datos in context.Empleados
                           where datos.Oficio == oficio
                           select datos;
            return consulta.ToList();
        }

        public void IncrementarSalarioEmpleados(string oficio, int incremento)
        {
            //A QUIEN QUEREMOS INCREMENTAR EL SALARIO?
            //RECUPERAMOS LOS EMPLEADOS QUE TENGAN UN DETERMINADO OFICIO
            List<Empleado> empleados = this.GetEmpleadosOficio(oficio);
            //RECORREMOS TODOS LOS DATOS DE LOS EMPLEADOS Y 
            //MODIFICAMOS SU SALARIO CON UN INCREMENTO
            foreach (Empleado empleado in empleados)
            {
                empleado.Salario += incremento;
            }
            //GUARDAMOS LOS CAMBIOS EN LA BBDD Y LO TENEMOS
            this.context.SaveChanges();
        }

        //si escribes algo en el codigo tuyo
        //NECESITAMOS UN METODO PARA RECUPERAR LOS DISTINTOS OFICIOS
        public List<string> GetOficios()
        {
            var consulta = from datos in this.context.Empleados
                           select datos.Oficio;
            return consulta.Distinct().ToList();
        }

        //NECESITAMOS UN METODO PARA RECUPERAR PERSONAS, MAXIMO Y MINIMO POR OFICIO
        public ResumenEmpleados GetResumenPersonas(string oficio)
        {
            var consulta = from datos in this.context.Empleados
                           where datos.Oficio == oficio
                           select datos;
            //CREAMOS VARIABLES PARA RECUPERAR LOS DATOS DEL RESUMEN
            int personas = consulta.Count();
            int maximoSalario = consulta.Max(z => z.Salario);
            int minimoSalario = consulta.Min(x => x.Salario);
            ResumenEmpleados resumen = new ResumenEmpleados();
            resumen.Personas = personas;
            resumen.MaximoSalario = maximoSalario;
            resumen.MinimoSalario = minimoSalario;
            return resumen;
        }
    }
}
