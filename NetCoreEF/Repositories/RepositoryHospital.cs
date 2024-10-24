﻿using NetCoreEF.Data;
using NetCoreEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreEF.Repositories
{
    public class RepositoryHospital
    {
        private EmpleadosContext context;

        public RepositoryHospital(EmpleadosContext context)
        {
            this.context = context;
        }

        public List<Hospital> GetHospitales()
        {
            var consulta = from datos in this.context.Hospitales
                           select datos;
            return consulta.ToList();
        }

        public Hospital FindHospital(int idhospital)
        {
            var consulta = from datos in this.context.Hospitales
                           where datos.IdHospital == idhospital
                           select datos;
            //EN LUGAR DE DEVOLVER UNA LISTA, DEVOLVEMOS EL PRIMERO (First)
            return consulta.First();
        }
    }
}
