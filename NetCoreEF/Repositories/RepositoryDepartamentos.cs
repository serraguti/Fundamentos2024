using NetCoreEF.Data;
using NetCoreEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreEF.Repositories
{
    public class RepositoryDepartamentos
    {
        private EmpleadosContext context;

        public RepositoryDepartamentos(EmpleadosContext context)
        {
            this.context = context;
        }

        public List<Departamento> GetDepartamentos()
        {
            var consulta = from datos in this.context.Departamentos
                           select datos;
            return consulta.ToList();
        }

        //METODO PARA BUSCAR UN DEPARTAMENTO POR SU ID
        public Departamento FindDepartamento(int id)
        {
            var consulta = from datos in this.context.Departamentos
                           where datos.IdDepartamento == id
                           select datos;
            return consulta.First();
        }

        public void EliminarDepartamento(int id)
        {
            //BUSCAR EL DEPARTAMENTO A ELIMINAR
            Departamento departamento = this.FindDepartamento(id);
            //ELIMINAMOS EL DEPARTAMENTO DENTRO DEL CONTEXT
            this.context.Departamentos.Remove(departamento);
            //GUARDAMOS LOS CAMBIOS EN LA BASE DE DATOS
            this.context.SaveChanges();
        }

        public void InsertarDepartamento(int id, string nombre, string localidad)
        {
            //CREAMOS UNA NUEVA CLASE MODEL DE DEPARTAMENTO
            Departamento departamento = new Departamento();
            //ASIGNAMOS SUS PROPIEDADES
            departamento.IdDepartamento = id;
            departamento.Nombre = nombre;
            departamento.Localidad = localidad;
            //AÑADIMOS LA NUEVA CLASE MODEL AL CONTEXT
            this.context.Departamentos.Add(departamento);
            //GUARDAMOS LOS CAMBIOS EN LA BASE DE DATOS
            this.context.SaveChanges();
        }
    }
}
