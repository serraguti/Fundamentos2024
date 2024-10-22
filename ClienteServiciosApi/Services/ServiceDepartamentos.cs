using ClienteServiciosApi.Models;
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
    }
}
