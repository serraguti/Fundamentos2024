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
    public partial class Form07ColeccionGrafica : Form
    {
        public Form07ColeccionGrafica()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string elemento = this.txtElemento.Text;
            this.lstElementos.Items.Add(elemento);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //PARA PODER ELIMINAR UN ELEMENTO DE UNA COLECCION TENEMOS DOS 
            //OPCIONES: 
            //1) BORRAR POR EL ELEMENTO
            //2) BORRAR POR EL INDICE
            //RECUPERAMOS EL INDICE SELECCIONADO DE LA LISTA
            int indiceSeleccionado = this.lstElementos.SelectedIndex;
            //ELIMINAMOS EL ELEMENTO POR EL INDICE
            this.lstElementos.Items.RemoveAt(indiceSeleccionado);
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            this.lstElementos.Items.Clear();
        }

        private void lstElementos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //PREGUNTAMOS SI EXISTE ELEMENTO SELECCIONADO
            if (this.lstElementos.SelectedIndex != -1)
            {
                this.lblIndiceSeleccionado.Text = "Indice seleccionado " +
                    this.lstElementos.SelectedIndex;
                this.lblItemSeleccionado.Text = "Item seleccionado " +
                    this.lstElementos.SelectedItem.ToString();
            }
        }
    }
}
