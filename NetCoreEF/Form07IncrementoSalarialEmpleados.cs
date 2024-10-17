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
    public partial class Form07IncrementoSalarialEmpleados : Form
    {
        private RepositoryEmpleados repo;

        public Form07IncrementoSalarialEmpleados()
        {
            InitializeComponent();
            this.repo = Program.provider.GetService<RepositoryEmpleados>();
        }

        private void btnIncrementarSalario_Click(object sender, EventArgs e)
        {
            int incremento = int.Parse(this.txtIncremento.Text);
            string oficio = this.txtOficio.Text;
            //INCREMENTAMOS EL SALARIO DE LOS EMPLEADOS
            this.repo.IncrementarSalarioEmpleados(oficio, incremento);
            //RECUPERAMOS A LOS EMPLEADOS DEL OFICIO PARA DIBUJARLOS
            List<Empleado> empleados = this.repo.GetEmpleadosOficio(oficio);
            //DIBUJAMOS LOS EMPLEADOS EN LA LISTA
            this.lstEmpleados.Items.Clear();
            foreach (Empleado empleado in empleados)
            {
                this.lstEmpleados.Items.Add(empleado.Apellido + " - " + empleado.Salario);
            }
        }
    }
}
