using Microsoft.Extensions.DependencyInjection;
using NetCoreEF.Models;
using NetCoreEF.Repositories;
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
    public partial class Form02BuscadorEmpleadosSalario : Form
    {
        private RepositoryEmpleados repo;

        public Form02BuscadorEmpleadosSalario()
        {
            InitializeComponent();
            //RECUPERAMOS EL REPOSITORY PARA NUESTRAS CONSULTAS
            this.repo =
                Program.provider.GetService<RepositoryEmpleados>();
        }

        private void btnBuscarSalarios_Click(object sender, EventArgs e)
        {
            //RECUPERAMOS EL SALARIO DE LA CAJA
            int salario = int.Parse(this.txtSalario.Text);
            //TRAEMOS LOS EMPLEADOS DE LA BUSQUEDA DESDE EL REPO
            List<Empleado> empleados = this.repo.GetEmpleadosSalario(salario);
            this.lstEmpleados.Items.Clear();
            //PINTAMOS LOS EMPLEADOS EN LA LISTA
            foreach (Empleado emp in empleados)
            {
                this.lstEmpleados.Items.Add(emp.Apellido + " - " + emp.Salario);
            }
        }

        private void btnBuscarOficios_Click(object sender, EventArgs e)
        {
            //RECUPERAMOS EL OFICIO DE LA CAJA
            string oficio = this.txtOficio.Text;
            //TRAEMOS LOS EMPLEADOS DE LA BUSQUEDA DEL REPO
            List<Empleado> empleados = this.repo.GetEmpleadosOficio(oficio);
            this.lstEmpleados.Items.Clear();
            //PINTAMOS LOS EMPLEADOS EN LA LISTA
            foreach (Empleado emp in empleados)
            {
                this.lstEmpleados.Items.Add(emp.Apellido + " - " + emp.Oficio);
            }
        }
    }
}
