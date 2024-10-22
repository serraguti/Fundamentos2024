using ClienteServiciosApi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ClienteServiciosApi.Services
{
    public class ServiceDepartamentos
    {
        private string ApiURlDepartamentos;
        private MediaTypeWithQualityHeaderValue Header;

        public ServiceDepartamentos()
        {
            //ESTA URL SIEMPRE SERA LA BASE, ES DECIR, NO LLEVARA PAGINAS
            this.ApiURlDepartamentos = "https://apicruddepartamentoscore.azurewebsites.net/";
            this.Header =
                new MediaTypeWithQualityHeaderValue("application/json");
        }

        public async Task<List<Departamento>> GetDepartamentosAsync()
        {
            string request = "api/departamentos";
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(this.ApiURlDepartamentos);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(this.Header);
                HttpResponseMessage response =
                    await client.GetAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    List<Departamento> departamentos =
                        await response.Content.ReadAsAsync<List<Departamento>>();
                    return departamentos;
                }
                else
                {
                    return null;
                }
            }
        }

        public async Task<Departamento> FindDepartamentoAsync(int id)
        {
            string request = "api/departamentos/" + id;
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(this.ApiURlDepartamentos);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(this.Header);
                HttpResponseMessage response =
                    await client.GetAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    Departamento departamento =
                        await response.Content.ReadAsAsync<Departamento>();
                    return departamento;
                }
                else
                {
                    return null;
                }
            }
        }

        public async Task InsertarDepartamentoAsync(int id, string nombre, string localidad)
        {
            string request = "api/departamentos";
            using (HttpClient client = new HttpClient())
            {
                //INDICAMOS LA URL BASE DEL SERVICIO
                client.BaseAddress = new Uri(this.ApiURlDepartamentos);
                //LIMPIAMOS LA CABECERA
                client.DefaultRequestHeaders.Clear();
                //ESTO ES OPCIONAL PARA INSERTAR, SOLAMENTE LO PONDRIAMOS PARA 
                //RECUPERAR DATOS DE UN SERVICIO
                //client.DefaultRequestHeaders.Accept.Add(this.Header);
                //DEBEMOS CREAR UN NUEVO MODELO PARA EL SERVICIO
                Departamento departamento = new Departamento();
                //INDICAMOS LAS PROPIEDADES PARA DICHO MODELO
                departamento.Numero = id;
                departamento.Nombre = nombre;
                departamento.Localidad = localidad;
                //DEBEMOS CONVERTIR EL OBJETO MODELO EN FORMATO JSON
                string jsonDepartamento = JsonConvert.SerializeObject(departamento);
                //PARA ENVIAR DATOS AL SERVICIO (data) DEBEMOS UTILIZAR LA CLASE 
                //StringContent QUE TIENE TRES ARGUMENTOS
                //1) OBJETO JSON
                //2) TIPO DE CODIFICACION
                //3) FORMATO DEL OBJETO QUE ENVIAMOS (JSON)
                StringContent content =
                    new StringContent(jsonDepartamento, Encoding.UTF8, "application/json");
                //POR ULTIMO, DEBEMOS REALIZAR LA LLAMADA MEDIANTE POST
                //INDICANDO LA PETICION (request) Y EL CONTENIDO A ENVIAR AL SERVICIO
                HttpResponseMessage response =
                    await client.PostAsync(request, content);
            }
        }

        public async Task UpdateDepartamentoAsync(int id, string nombre, string localidad)
        {
            string request = "api/departamentos";
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(this.ApiURlDepartamentos);
                client.DefaultRequestHeaders.Clear();
                //DEBEMOS CREAR UN NUEVO OBJETO MODEL DEPARTAMENTO
                Departamento departamento = new Departamento();
                departamento.Numero = id;
                departamento.Nombre = nombre;
                departamento.Localidad = localidad;
                //CONVERTIMOS EL MODELO EN FORMATO JSON
                string json = JsonConvert.SerializeObject(departamento);
                //DEBEMOS CREAR LA CLASE StringContent PARA ENVIAR LOS DATOS AL 
                //SERVICIO (data)
                StringContent content =
                    new StringContent(json, Encoding.UTF8, "application/json");
                //REALIZAMOS LA LLAMADA Put ENVIANDO LA PETICION (request)
                //Y EL OBJETO JSON
                await client.PutAsync(request, content);
            }
        }

    }
}
