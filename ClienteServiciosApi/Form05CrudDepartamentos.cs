using ClienteServiciosApi.Models;
using ClienteServiciosApi.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteServiciosApi
{
    public partial class Form05CrudDepartamentos : Form
    {
        private ServiceDepartamentos service;

        public Form05CrudDepartamentos()
        {
            InitializeComponent();
            this.service = new ServiceDepartamentos();
        }

        private async Task CargarDepartamentos()
        {
            List<Departamento> departamentos = await this.service.GetDepartamentosAsync();
            this.lsvDepartamentos.Items.Clear();
            foreach (Departamento dept  in departamentos)
            {
                ListViewItem item = new ListViewItem();
                item.Text = dept.Numero.ToString();
                item.SubItems.Add(dept.Nombre);
                item.SubItems.Add(dept.Localidad);
                this.lsvDepartamentos.Items.Add(item);
            }
        }

        private async void Form05CrudDepartamentos_Load(object sender, EventArgs e)
        {
            await this.CargarDepartamentos();
        }
    }
}
