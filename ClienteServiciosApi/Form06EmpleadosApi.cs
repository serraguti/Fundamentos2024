using ClienteServiciosApi.Models;
using ClienteServiciosApi.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteServiciosApi
{
    public partial class Form06EmpleadosApi : Form
    {
        private ServiceEmpleados service;

        public Form06EmpleadosApi()
        {
            InitializeComponent();
            this.service = new ServiceEmpleados();
        }

        private async void Form06EmpleadosApi_Load(object sender, EventArgs e)
        {
            List<Empleado> empleados =
                await this.service.GetEmpleadosAsync();
            this.lstEmpleados.Items.Clear();
            foreach (Empleado empleado in empleados)
            {
                this.lstEmpleados.Items.Add(empleado.Apellido);
            }
        }

        private async void btnBuscarEmpleados_Click(object sender, EventArgs e)
        {
            string oficio = this.txtOficio.Text;
            List<Empleado> empleados =
                await this.service.GetEmpleadosOficiosAsync(oficio);
            this.lstEmpleados.Items.Clear();
            //PREGUNTAMOS SI EL SERVICIO NOS HA DEVUELTO EMPLEADOS
            if (empleados != null)
            {
                foreach (Empleado emp in empleados)
                {
                    this.lstEmpleados.Items.Add(emp.Apellido + " - " + emp.Oficio);
                }
            }
        }
    }
}
