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
    public partial class Form05SumarTextoNumeros : Form
    {
        public Form05SumarTextoNumeros()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            //CAPTURAMOS EL TEXTO DE LA CAJA DE NUMEROS
            string textoSuma = this.txtNumeros.Text;
            int suma = 0;
            //RECORREMOS TODOS LOS CARACTERES DEL TEXTO
            //DE UNO EN UNO
            for (int i = 0; i < textoSuma.Length; i++)
            {
                //CAPTURAMOS CADA CARACTER DEL TEXTO
                char caracter = textoSuma[i]; //"1", "2"
                //DEBEMOS CONVERTIR EL CARACTER A NUMERO
                int numero = int.Parse(caracter.ToString());
                //SUMAMOS CADA CARACTER A LA VARIABLE suma
                suma = suma + numero;
            }
            //DIBUJAMOS LA SUMA EN EL LABEL DE RESULTADO
            this.lblResultado.Text = suma.ToString();
        }
    }
}
