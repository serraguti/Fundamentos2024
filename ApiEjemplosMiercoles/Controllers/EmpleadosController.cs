using ApiEjemplosMiercoles.Models;
using ApiEjemplosMiercoles.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiEjemplosMiercoles.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadosController : ControllerBase
    {
        //PARA REALIZAR LAS CONSULTAS, NECESITAMOS EL REPOSITORY
        private RepositoryEmpleados repo;

        public EmpleadosController(RepositoryEmpleados repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public List<Empleado> GetEmpleados()
        {
            return this.repo.GetEmpleados();
        }

        //NECESITAMOS UN METODO PARA BUSCAR UN EMPLEADO POR SU ID
        //LOS PARAMETROS DEBEMOS INDICARLOS DENTRO DE [Route] MEDIANTE
        //LLAVES:  [Route("Metodo/{parametro}")]
        [HttpGet]
        [Route("[action]/{idempleado}")]
        public Empleado Buscar(int idempleado)
        {
            return this.repo.FindEmpleado(idempleado);
        }

        [HttpGet]
        [Route("[action]/{oficio}")]
        public List<Empleado> EmpleadosOficios(string oficio)
        {
            return this.repo.GetEmpleadosOficio(oficio);
        }
    }
}
