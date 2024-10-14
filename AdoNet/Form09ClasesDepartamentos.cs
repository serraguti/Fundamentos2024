using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdoNet.Models;
using AdoNet.Repositories;

namespace AdoNet
{
    public partial class Form09ClasesDepartamentos : Form
    {
        private RepositoryDepartamentos repo;

        public Form09ClasesDepartamentos()
        {
            InitializeComponent();
            //CREAMOS EL REPOSITORIO
            this.repo = new RepositoryDepartamentos();
            this.CargarDepartamentos();
            this.CargarDepartamentosListView();
        }

        private void CargarDepartamentosListView()
        {
            List<Departamento> departamentos = this.repo.GetDepartamentos();
            //LIMPIAMOS LOS ITEMS DEL LISTVIEW
            this.lsvDepartamentos.Items.Clear();
            foreach (Departamento dept in departamentos)
            {
                //POR CADA FILA, NOS CREAMOS UN NUEVO ListViewITem
                ListViewItem item = new ListViewItem();
                item.Text = dept.IdDepartamento.ToString();
                //CADA DATO DE LAS SIGUIENTES COLUMNAS DE HACE MEDIANTE SubItems
                item.SubItems.Add(dept.Nombre);
                item.SubItems.Add(dept.Localidad);
                //AÑADIMOS CADA ITEM AL ListView
                this.lsvDepartamentos.Items.Add(item);
            }
        }

        private void CargarDepartamentos()
        {
            List<Departamento> departamentos = this.repo.GetDepartamentos();
            this.lstDepartamentos.Items.Clear();
            //RECORREMOS CADA DEPARTAMENTO DE LA LISTA
            foreach (Departamento dept in departamentos)
            {
                string texto = dept.IdDepartamento + " - " + dept.Nombre + " - " + dept.Localidad;
                this.lstDepartamentos.Items.Add(texto);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtNumero.Text);
            string nombre = this.txtNombre.Text;
            string localidad = this.txtLocalidad.Text;
            //EJECUTAMOS EL METODO INSERTAR QUE NOS DEVUELVE UN int
            int resultados = this.repo.InsertarDepartamento(id, nombre, localidad);
            MessageBox.Show("Departamentos insertados: " + resultados);
            this.CargarDepartamentos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtNumero.Text);
            int resultados = this.repo.EliminarDepartamento(id);
            MessageBox.Show("Eliminados: " + resultados);
            this.CargarDepartamentos();
        }

        private void brnModificar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtNumero.Text);
            string nombre = this.txtNombre.Text;
            string localidad = this.txtLocalidad.Text;
            int resultados = this.repo.ModificarDepartamento(id, nombre, localidad);
            MessageBox.Show("Modificados: " + resultados);
            this.CargarDepartamentos();
        }
    }
}
