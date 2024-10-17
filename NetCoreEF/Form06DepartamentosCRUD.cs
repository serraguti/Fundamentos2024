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
    public partial class Form06DepartamentosCRUD : Form
    {
        private RepositoryDepartamentos repo;

        public Form06DepartamentosCRUD()
        {
            InitializeComponent();
            this.repo = Program.provider.GetService<RepositoryDepartamentos>();
            this.CargarDepartamentos();
        }

        private void CargarDepartamentos()
        {
            List<Departamento> departamentos = this.repo.GetDepartamentos();
            this.lsvDepartamentos.Items.Clear();
            foreach (Departamento departamento in departamentos)
            {
                ListViewItem item = new ListViewItem();
                item.Text = departamento.IdDepartamento.ToString();
                item.SubItems.Add(departamento.Nombre);
                item.SubItems.Add(departamento.Localidad);
                this.lsvDepartamentos.Items.Add(item);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            //RECUPERAMOS LOS DATOS DE CADA CAJA
            //int idDepartamento = int.Parse(this.txtIdDepartamento.Text);
            string nombre = this.txtNombre.Text;
            string localidad = this.txtLocalidad.Text;
            this.repo.InsertarDepartamento(nombre, localidad);
            this.CargarDepartamentos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //RECUPERAMOS EL ID DEL DEPARTAMENTO SELECCIONADO DENTRO DE LA LISTA
            ListViewItem item = this.lsvDepartamentos.SelectedItems[0];
            int id = int.Parse(item.Text);
            this.repo.EliminarDepartamento(id);
            this.CargarDepartamentos();
        }

        private void lsvDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lsvDepartamentos.SelectedItems.Count != 0)
            {
                ListViewItem item = this.lsvDepartamentos.SelectedItems[0];
                int id = int.Parse(item.Text);
                Departamento departamento = this.repo.FindDepartamento(id);
                this.txtIdDepartamento.Text = departamento.IdDepartamento.ToString();
                this.txtNombre.Text = departamento.Nombre;
                this.txtLocalidad.Text = departamento.Localidad;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //RECUPERAMOS EL ID DEL DEPARTAMENTO A MODIFICAR
            int id = int.Parse(this.txtIdDepartamento.Text);
            string nombre = this.txtNombre.Text;
            string localidad = this.txtLocalidad.Text;
            this.repo.ModificarDepartamento(id, nombre, localidad);
            this.CargarDepartamentos();
        }
    }
}
