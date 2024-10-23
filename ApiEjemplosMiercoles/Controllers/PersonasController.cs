using ApiEjemplosMiercoles.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiEjemplosMiercoles.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonasController : ControllerBase
    {
        //CADE METODO QUE TENGAMOS EN ESTA CLASE, DEBE IR
        //DECORADO CON [HttpGet] Y DEVOLVER "ALGO"
        //LO QUE DEVOLVAMOS IRA EN FORMATO JSON
        //QUEREMOS DEVOLVER UN CONJUNTO DE PERSONAS
        [HttpGet]
        public List<Persona> GetPersonas()
        {
            //VAMOS A CREAR UNA SERIE DE PERSONAS Y LAS DEVOLVEMOS
            List<Persona> lista = new List<Persona>();
            Persona persona1 = new Persona();
            persona1.Nombre = "Adrian";
            persona1.Apellidos = "Ramos";
            persona1.Edad = 24;
            lista.Add(persona1);
            Persona persona2 = new Persona();
            persona2.Nombre = "Lucia";
            persona2.Apellidos = "Serrano";
            persona2.Edad = 22;
            lista.Add(persona2);
            Persona persona3 = new Persona();
            persona3.Nombre = "Carlos";
            persona3.Apellidos = "Campayo";
            persona3.Edad = 44;
            lista.Add(persona3);
            return lista;
        }

        [HttpGet]
        [Route("[action]")]
        public Persona GetPersona()
        {
            Persona persona = new Persona();
            persona.Nombre = "Antonia";
            persona.Apellidos = "Martinez";
            persona.Edad = 74;
            return persona;
        }
    }
}
