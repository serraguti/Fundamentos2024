using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos2024
{
    public partial class Form14ColeccionesNoGraficas : Form
    {
        List<string> coleccionNombres;

        public Form14ColeccionesNoGraficas()
        {
            InitializeComponent();
            this.coleccionNombres = new List<string>();
        }

        private void brtnGuardarNombre_Click(object sender, EventArgs e)
        {
            string nombre = this.txtNombre.Text;
            this.coleccionNombres.Add(nombre);
            this.lblMensaje.Text = "Nombres almacenados: " + this.coleccionNombres.Count;
            this.txtNombre.Text = "";
        }

        private void btnMostrarNombres_Click(object sender, EventArgs e)
        {
            this.lstNombres.Items.Clear();
            foreach (string name in this.coleccionNombres)
            {
                this.lstNombres.Items.Add(name);
            }
        }
    }
}
