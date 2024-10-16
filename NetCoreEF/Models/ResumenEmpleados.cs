using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreEF.Models
{
    public class ResumenEmpleados
    {
        public int Personas { get; set; }
        public int MaximoSalario { get; set; }
        public int MinimoSalario { get; set; }
    }
}
