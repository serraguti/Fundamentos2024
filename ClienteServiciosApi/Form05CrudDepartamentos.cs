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
            foreach (Departamento dept in departamentos)
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

        private async void lsvDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //COMPROBAMOS SI TENEMOS ALGUN DEPARTAMENTO SELECCIONADO
            if (this.lsvDepartamentos.SelectedItems.Count != 0)
            {
                //RECUPERAMOS EL PRIMER ELEMENTO SELECCIONADO
                ListViewItem item = this.lsvDepartamentos.SelectedItems[0];
                //RECUPERAMOS EL ID DEL DEPARTAMENTO
                int id = int.Parse(item.Text);
                Departamento departamento = await this.service.FindDepartamentoAsync(id);
                this.txtNumero.Text = departamento.Numero.ToString();
                this.txtNombre.Text = departamento.Nombre;
                this.txtLocalidad.Text = departamento.Localidad;
            }
        }

        private async void btnInsertar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtNumero.Text);
            string nombre = this.txtNombre.Text;
            string localidad = this.txtLocalidad.Text;
            await this.service.InsertarDepartamentoAsync(id, nombre, localidad);
            this.txtNumero.Text = "";
            this.txtNombre.Text = "";
            this.txtLocalidad.Text = "";
            await this.CargarDepartamentos();
        }
    }
}
