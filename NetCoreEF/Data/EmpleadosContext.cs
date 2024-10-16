using Microsoft.EntityFrameworkCore;
using NetCoreEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreEF.Data
{
    public class EmpleadosContext: DbContext
    {
        //EN EL CONSTRUCTOR DE LA CLASE, DEBEMOS RECIBIR LAS 
        //OPCIONES DE LA BASE DE DATOS QUE VAMOS A UTILIZAR
        //ESTO DEBEMOS HACERLO MEDIANTE INYECCION DE DEPENDENCIAS
        public EmpleadosContext(DbContextOptions<EmpleadosContext> options):base(options) { }
        //CONTENDRA EL CONJUNTO DE DATOS DE EMPLEADOS MEDIANTE DbSet
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Hospital> Hospitales { get; set; }
    }
}
