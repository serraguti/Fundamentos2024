using ClienteServiciosApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ClienteServiciosApi.Services
{
    public class ServiceEmpleados
    {
        private string ApiUrlEmpleados;

        private MediaTypeWithQualityHeaderValue Header;

        public ServiceEmpleados()
        {
            this.ApiUrlEmpleados = "https://localhost:7166/";
            this.Header =
                new MediaTypeWithQualityHeaderValue("application/json");
        }

        public async Task<List<Empleado>> GetEmpleadosAsync()
        {
            string request = "api/empleados";
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(this.ApiUrlEmpleados);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(this.Header);
                HttpResponseMessage response =
                    await client.GetAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    List<Empleado> empleados =
                        await response.Content.ReadAsAsync<List<Empleado>>();
                    return empleados;
                }
                else
                {
                    return null;
                }
            }
        }

        public async Task<List<Empleado>> GetEmpleadosOficiosAsync(string oficio)
        {
            string request = "api/empleados/empleadosoficios/" + oficio;
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(this.ApiUrlEmpleados);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(this.Header);
                HttpResponseMessage response =
                    await client.GetAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    List<Empleado> empleados =
                        await response.Content.ReadAsAsync<List<Empleado>>();
                    return empleados;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
