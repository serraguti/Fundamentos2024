using Microsoft.Extensions.DependencyInjection;
using NetCoreEFFinal.Models;
using NetCoreEFFinal.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetCoreEFFinal
{
    public partial class Form01HospitalesCRUD : Form
    {
        RepositoryHospitales repo;

        public Form01HospitalesCRUD()
        {
            InitializeComponent();
            this.repo = Program.provider.GetService<RepositoryHospitales>();
            this.CargarHospitales();
        }

        private void CargarHospitales()
        {
            List<Hospital> hospitales = this.repo.GetHospitales();
            this.lsvHospitales.Items.Clear();
            foreach (Hospital h in hospitales)
            {
                ListViewItem item = new ListViewItem();
                item.Text = h.IdHospital.ToString();
                item.SubItems.Add(h.Nombre);
                item.SubItems.Add(h.Direccion);
                item.SubItems.Add(h.Telefono);
                item.SubItems.Add(h.Camas.ToString());
                this.lsvHospitales.Items.Add(item);
            }
        }

        private async void btnInsertar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtIdHospital.Text);
            string nombre = this.txtNombre.Text;
            string direccion = this.txtDireccion.Text;
            string telefono = this.txtTelefono.Text;
            int camas = int.Parse(this.txtCamas.Text);
            await this.repo.InsertarHospitalAsync(id, nombre, direccion, telefono, camas);
            this.CargarHospitales();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtIdHospital.Text);
            await this.repo.EliminarHospitalAsync(id);
            this.CargarHospitales();
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtIdHospital.Text);
            string nombre = this.txtNombre.Text;
            string direccion = this.txtDireccion.Text;
            string telefono = this.txtTelefono.Text;
            int camas = int.Parse(this.txtCamas.Text);
            await this.repo.ModificarHospitalAsync(id, nombre, direccion, telefono, camas);
            this.CargarHospitales();
        }
    }
}
