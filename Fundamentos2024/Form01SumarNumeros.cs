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
    public partial class Form01SumarNumeros : Form
    {
        public Form01SumarNumeros()
        {
            InitializeComponent();
        }

        private void btnSumarNumeros_Click(object sender, EventArgs e)
        {
            //CAPTURAMOS EN VARIABLES LOS NUMEROS DE LAS CAJAS
            //EN LA CAJA VIENE UN TIPO DE DATO string
            if (this.txtNumero1.Text == "" || this.txtNumero2.Text == "")
            {
                MessageBox.Show("No has escrito nada en las cajas");
            }
            else
            {
                int numero1 = int.Parse(this.txtNumero1.Text);
                int numero2 = int.Parse(this.txtNumero2.Text);
                int suma = numero1 + numero2;
                //ESCRIBIMOS EN EL LABEL EL RESULTADO DE LA SUMA
                this.lblResultado.Text = suma.ToString();
            }
        }
    }
}
