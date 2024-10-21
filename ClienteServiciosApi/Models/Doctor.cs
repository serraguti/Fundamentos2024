using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteServiciosApi.Models
{
    public class Doctor
    {
        [JsonProperty("idDoctor")]
        public int IdDoctor { get; set; }
        [JsonProperty("apellido")]
        public string Apellido { get; set; }
        [JsonProperty("especialidad")]
        public string Especialidad { get; set; }
        [JsonProperty("salario")]
        public int Salario { get; set; }
        [JsonProperty("idHospital")]
        public int IdHospital { get; set; }
    }
}
