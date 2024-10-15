using Microsoft.Extensions.DependencyInjection;
using NetCoreEF.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetCoreEF
{
    public partial class Form01TodosEmpleados : Form
    {
        public Form01TodosEmpleados()
        {
            InitializeComponent();
        }

        private void btnCargarEmpleados_Click(object sender, EventArgs e)
        {
            //RECUPERAMOS EL REPOSITORIO DEL PROVIDER DE PROGRAM
            RepositoryEmpleados repo = 
                Program.provider.GetService<RepositoryEmpleados>();
            //RECUPERAMOS LOS EMPLEADOS DE LA BASE DE DATOS
            List<Empleado> empleados = repo.GetEmpleados();
            //DIBUJAMOS LOS EMPLEADOS EN LA LISTA
            this.lstEmpleados.Items.Clear();
            foreach (Empleado emp in empleados)
            {
                this.lstEmpleados.Items.Add(emp.Apellido + " - " + emp.Oficio);
            }
        }
    }
}
