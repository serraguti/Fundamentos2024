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
    public partial class Form08SumaNumerosListbox : Form
    {
        public Form08SumaNumerosListbox()
        {
            InitializeComponent();
        }

        private void btnAgregarNumero_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(this.txtNumero.Text);
            this.lstNumeros.Items.Add(numero);
        }

        private void btnSumarNumeros_Click(object sender, EventArgs e)
        {
            //NECESITAMOS UNA VARIABLE PARA ALMACENAR LA SUMA DE CADA NUMERO
            int suma = 0;
            //VAMOS A RECORRER TODOS LOS NUMEROS DE LA LISTA
            //NECESITAMOS SABER CUANTOS ELEMENTOS TIENE LA LISTA
            int numeroElementos = this.lstNumeros.Items.Count;
            //RECORREMOS TODOS LOS ELEMENTOS DE LA LISTA.  LAS COLECCIONES
            //COMIENZAN EN CERO.
            for (int i = 0; i < numeroElementos; i++)
            {
                //ALMACENAMOS CADA OBJETO DE LA COLECCION
                object dato = this.lstNumeros.Items[i];
                //CONVERTIMOS EL DATO A NUMERO
                int numero = int.Parse(dato.ToString());
                //VAMOS SUMANDO CADA NUMERO
                suma = suma + numero;
            }
            this.lblSuma.Text = suma.ToString();
        }
    }
}
