using ClienteServiciosApi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ClienteServiciosApi.Services
{
    public class ServiceDoctores
    {
        //NECESITAMOS LA URL DE ACCESO AL SERVICIO
        private string ApiUrlDoctores;

        //CUANDO CONSUMIMOS UN SERVICIO, DEBEMOS INDICAR EL 
        //FORMATO DE DATOS QUE VAMOS A CONSUMIR
        private MediaTypeWithQualityHeaderValue header;

        public ServiceDoctores()
        {
            this.ApiUrlDoctores = "https://apidoctoresroutes2023.azurewebsites.net/";
            this.header =
                new MediaTypeWithQualityHeaderValue("application/json");
        }

        //DEBEMOS CREAR UN METODO QUE NOS DEVOLVERA TODOS LOS DOCTORES
        //EL METODO DEBE SER ASINCRONO (async/await)
        public async Task<List<Doctor>> GetDoctoresAsync()
        {
            //MEDIANTE LA CLASE HttpClient REALIZAREMOS LAS PETICIONES AL 
            //SERVICIO
            using (HttpClient client = new HttpClient())
            {
                //NECESITAMOS SABER EL EndPoint O EL Request DE ACCESO A LOS DATOS
                string request = "api/doctores";
                //INDICAMOS A NUESTRO CLIENTE LA URL DE ACCESO AL SERVICIO
                client.BaseAddress = new Uri(this.ApiUrlDoctores);
                //LAS CABECERAS SON INFORMACION QUE ENVIAMOS A UN SERVICIO
                //POR EJEMPLO, EN EL POST DE ANTES, HE ENVIADO INFORMACION DE UN HOSPITAL
                //DICHA INFORMACION TAMBIEN PUEDEN SER CREDENCIALES DEL SERVICIO
                //POR NORMA, PARA NO CRUZAR PETICIONES, DEBEMOS LIMPIAR LAS 
                //CABECERAS CADA VEZ QUE HAGAMOS UNA PETICION
                client.DefaultRequestHeaders.Clear();
                //RELLENAMOS LAS CABECERAS CON EL FORMATO QUE VAMOS A CONSUMIR DEL SERVICIO (JSON)
                client.DefaultRequestHeaders.Accept.Add(this.header);
                //EL SIGUIENTE PASO ES REALIZAR LA PETICION Y ALMACENAR EL RESULTADO
                //EN UNA RESPUESTA.
                //LAS RESPUESTAS SON CODIGOS STANDARD DE PETICIONES WEB
                HttpResponseMessage response =
                    await client.GetAsync(request);
                //COMPROBAMOS SI LA RESPUESTA ES CORRECTA O NO
                if (response.IsSuccessStatusCode)
                {
                    //SI LA PETICION ES CORRECTA, CONTIENE DATOS DE LOS DOCTORES
                    //EN FORMATO JSON
                    //VAMOS A LEER EL CONTENIDO string DE LA PETICION JSON
                    string json = await response.Content.ReadAsStringAsync();
                    //NECESITAMOS CONVERTIR ESE TEXTO A OBJETOS
                    List<Doctor> doctores = JsonConvert.DeserializeObject<List<Doctor>>(json);
                    return doctores;
                }
                else
                {
                    //SI LA PETICION NO ES CORRECTA, POR NORMA SE SUELE
                    //DEVOLVER UN NULL
                    return null;
                }
            }
        }

        public async Task<Doctor> FindDoctorAsync(int iddoctor)
        {
            string request = "api/doctores/" + iddoctor;
            using (HttpClient client = new HttpClient())
            {
                //INDICAMOS LA DIRECCION DONDE ESTA NUESTRO SERVICIO (URL)
                client.BaseAddress = new Uri(this.ApiUrlDoctores);
                //DEBEMOS LIMPIAR LAS CABECERAS ANTES DE CONSUMIRLAS
                client.DefaultRequestHeaders.Clear();
                //INDICAMOS EL TIPO DE DATO QUE VAMOS A CONSUMIR
                client.DefaultRequestHeaders.Accept.Add(this.header);
                //REALIZAMOS EL TIPO DE PETICION GET QUE NOS PERMITE RECUPERAR 
                //DATOS.
                HttpResponseMessage response =
                    await client.GetAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    //LOS DATOS VIENEN ALMACENADOS DENTRO DE response Y EN 
                    //SU PROPIEDAD Content
                    Doctor doctor = await response.Content.ReadAsAsync<Doctor>();
                    return doctor;
                }
                else
                {
                    return null;
                }
            }
        }

        //METODO PARA RECUPERAR TODAS LAS ESPECILIDADES
        public async Task<List<string>> GetEspecialidadesAsync()
        {
            string request = "api/doctores/especialidades";
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(this.ApiUrlDoctores);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(this.header);
                HttpResponseMessage response =
                    await client.GetAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    List<string> especialidades = await
                        response.Content.ReadAsAsync<List<string>>();
                    return especialidades;
                }
                else
                {
                    return null;
                }
            }
        }

        //METODO PARA BUSCAR DOCTORES POR ESPECIALIDAD
        public async Task<List<Doctor>> GetDoctoresEspecialidadAsync(string especialidad)
        {
            string request = "api/doctores/doctoresespecialidad/" + especialidad;
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(this.ApiUrlDoctores);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(this.header);
                HttpResponseMessage response =
                    await client.GetAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    List<Doctor> doctores = await response.Content.ReadAsAsync<List<Doctor>>();
                    return doctores;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
