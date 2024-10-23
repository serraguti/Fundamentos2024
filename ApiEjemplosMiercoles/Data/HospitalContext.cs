using ApiEjemplosMiercoles.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiEjemplosMiercoles.Data
{
    public class HospitalContext: DbContext
    {
        public HospitalContext
            (DbContextOptions<HospitalContext> options) : base(options) { }
        public DbSet<Empleado> Empleados { get; set; }
    }
}
