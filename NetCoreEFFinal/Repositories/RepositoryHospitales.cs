using Microsoft.EntityFrameworkCore;
using NetCoreEFFinal.Data;
using NetCoreEFFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreEFFinal.Repositories
{
    public class RepositoryHospitales
    {
        private HospitalContext context;

        public RepositoryHospitales(HospitalContext context)
        {
            this.context = context;
        }

        //SIEMPRE QUE TENGAMOS UN METODO ASINCRONO, DEBEMOS DEVOLVER
        //Task<>
        public async Task<List<Hospital>> GetHospitalesAsync()
        {
            var consulta = from datos in this.context.Hospitales
                           select datos;
            return await consulta.ToListAsync();
        }

        public List<Hospital> GetHospitales()
        {
            var consulta = from datos in this.context.Hospitales
                           select datos;
            return consulta.ToList();
        }

        public async Task<Hospital> FindHospitalAsync(int idhospital)
        {
            var consulta = from datos in this.context.Hospitales
                           where datos.IdHospital == idhospital
                           select datos;
            return await consulta.FirstAsync();
        }

        //EL METODO INSERTAR NO DEVOLVERA NADA, POR LO QUE 
        //SI ES ASINCRONO, SOLAMENTE SE DECLARA COMO Task
        public async Task InsertarHospitalAsync(int idhospital, string nombre
            , string direccion, string telefono, int camas)
        {
            Hospital hospital = new Hospital();
            hospital.IdHospital = idhospital;
            hospital.Nombre = nombre;
            hospital.Direccion = direccion;
            hospital.Telefono = telefono;
            hospital.Camas = camas;
            //AGREGAMOS LA CLASE HOSPITAL AL DBCONTEXT
            await this.context.Hospitales.AddAsync(hospital);
            //GUARDAMOS CAMBIOS EN LA BASE DE DATOS
            await this.context.SaveChangesAsync();
        }

        public async Task ModificarHospitalAsync(int id, string nombre, string direccion
            , string telefono, int camas)
        {
            //DEBEMOS BUSCAR EL HOSPITAL POR SU ID
            Hospital hospital = await this.FindHospitalAsync(id);
            hospital.Nombre = nombre;
            hospital.Direccion = direccion;
            hospital.Telefono = telefono;
            hospital.Camas = camas;
            //GUARDAMOS LOS CAMBIOS EN LA BASE DE DATOS
            await this.context.SaveChangesAsync();
        }

        public async Task EliminarHospitalAsync(int id)
        {
            Hospital hospital = await this.FindHospitalAsync(id);
            //ELIMINAMOS EL HOSPITAL DE LA COLECCION DEL CONTEXT
            this.context.Hospitales.Remove(hospital);
            //GUARDAMOS LOS CAMBIOS EN LA BASE DE DATOS
            await this.context.SaveChangesAsync();
        }
    }
}
