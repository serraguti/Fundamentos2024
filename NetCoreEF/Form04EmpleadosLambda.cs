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
    public partial class Form04EmpleadosLambda : Form
    {
        private RepositoryEmpleados repo;

        public Form04EmpleadosLambda()
        {
            InitializeComponent();
            this.repo = Program.provider.GetService<RepositoryEmpleados>();
            //RECUPERAMOS LOS DATOS DE LOS OFICIOS
            List<string> oficios = this.repo.GetOficios();
            //SIMPLEMENTE DIBUJAMOS LOS OFICIOS EN EL Combobox
            foreach (string ofi in oficios)
            {
                this.cmbOficios.Items.Add(ofi);
            }
        }

        private void cmbOficios_SelectedIndexChanged(object sender, EventArgs e)
        {
            //CAPTURAMOS EL OFICIO SELECCIONADO
            string oficio = this.cmbOficios.SelectedItem.ToString();
            //RECUPERAMOS LOS DATOS DEL RESUMEN
            ResumenEmpleados resumen = this.repo.GetResumenPersonas(oficio);
            this.txtPersonas.Text = resumen.Personas.ToString();
            this.txtMaximoSalario.Text = resumen.MaximoSalario.ToString();
            this.txtMinimoSalario.Text = resumen.MinimoSalario.ToString();
            //RECUPERAMOS TAMBIEN LOS EMPLEADOS PARA EL DIBUJO
            List<Empleado> empleados = this.repo.GetEmpleadosOficio(oficio);
            this.lstEmpleados.Items.Clear();
            foreach (Empleado emp in empleados)
            {
                this.lstEmpleados.Items.Add(emp.Apellido);
            }
        }
    }
}
