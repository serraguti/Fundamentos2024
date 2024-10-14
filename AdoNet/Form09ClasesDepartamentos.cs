using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtNumero.Text);
            string nombre = this.txtNombre.Text;
            string localidad = this.txtLocalidad.Text;
            //EJECUTAMOS EL METODO INSERTAR QUE NOS DEVUELVE UN int
            int resultados = this.repo.InsertarDepartamento(id, nombre, localidad);
            MessageBox.Show("Departamentos insertados: " + resultados);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtNumero.Text);
            int resultados = this.repo.EliminarDepartamento(id);
            MessageBox.Show("Eliminados: " + resultados);
        }
    }
}
