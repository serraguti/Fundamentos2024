using Microsoft.EntityFrameworkCore;
using NetCoreEFFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreEFFinal.Data
{
    public class HospitalContext: DbContext
    {
        public HospitalContext(DbContextOptions<HospitalContext> options) 
            : base(options) { }
        public DbSet<Hospital> Hospitales { get; set; }
    }
}
