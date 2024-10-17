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

        public void ModificarDepartamento(int id, string nombre, string localidad)
        {
            //BUSCAMOS EL DEPARTAMENTO A MODIFICAR
            Departamento departamento = this.FindDepartamento(id);
            //MODIFICAMOS LAS PROPIEDADES QUE DESEEMOS
            departamento.Nombre = nombre;
            departamento.Localidad = localidad;
            //GUARDAMOS CAMBIOS EN LA BASE DE DATOS
            this.context.SaveChanges();
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


        private int GetMaxIdDepartamento()
        {
            //REALIZAMOS UNA CONSULTA SOBRE TODOS LOS DEPARTAMENTOS
            var consulta = from datos in this.context.Departamentos
                           select datos;
            //EN ESTA ACCION, TENEMOS DOS POSIBLES ESCENARIOS
            //1) PODRIA SER QUE NO TUVIERAMOS DATOS EN LA CONSULTA
            //SI NO TENEMOS DATOS EN LA CONSULTA, DEVOLVEREMOS EL NUMERO 1
            //PREGUNTAMOS SI TENEMOS DATOS EN LOS DEPARTAMENTOS
            if (consulta.Count() == 0)
            {
                return 1;
            }
            else
            {
                //2) SI TENEMOS DATOS EN LA CONSULTA, DEVOLVEMOS EL MAX CON 
                //EXPRESIONES LAMBDA TAL Y COMO VIMOS AYER
                int idMaximo = consulta.Max(x => x.IdDepartamento) + 1;
                return idMaximo;
            }
        }

        public void InsertarDepartamento(string nombre, string localidad)
        {
            //RECUPERAMOS EL MAXIMO ID DE LOS DEPARTAMENTOS
            int id = this.GetMaxIdDepartamento();
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
