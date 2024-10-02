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

        void CambiarColoresBotones(Color miColorPersonal)
        {
            this.btnAgregarNumero.BackColor = miColorPersonal;
            this.btnSumarNumerosIndice.BackColor = miColorPersonal;
            this.btnSumarNumerosReferencia.BackColor = miColorPersonal;
        }

        void btnAgregarNumero_Click(object sender, EventArgs e)
        {
            int dato = this.SumarNumeros(7, 8);

            this.CambiarColoresBotones(Color.DarkTurquoise);
            int numero = int.Parse(this.txtNumero.Text);
            this.lstNumeros.Items.Add(numero);
        }

        int SumarNumeros(int num1, int num2)
        {
            //AQUI ESCRIBIMOS LA LOGICA
            int suma = num1 + num2;
            //DEVOLVEMOS UN VALOR QUE CORRESPONDE CON EL TIPO DEL METODO
            return suma;
        }




        private void btnSumarNumeros_Click(object sender, EventArgs e)
        {
            this.CambiarColoresBotones(Color.Red);
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

        private void btnSumarNumerosReferencia_Click(object sender, EventArgs e)
        {
            //UNA VARIABLE PARA ALMACENAR LA SUMA
            int suma = 0;
            //SOLAMENTE NECESITAMOS SABER QUE TIPO DE ELEMENTOS (DATO)
            //VAMOS A RECORRER
            foreach (int numero in this.lstNumeros.Items)
            {
                //VAMOS SUMANDO CADA VALOR DE LA VARIABLE DE REFERENCIA (numero)
                suma = suma + numero;
            }
            this.lblSuma.Text = suma.ToString();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            //DEBEMOS RECORRER TODO EL CONTENIDO STRING DE LA CAJA
            string contenido = this.textBox1.Text;
            for (int i = 0; i < contenido.Length; i++)
            {
                //CAPTURAMOS CADA LETRA
                char letra = contenido[i];
                //CON LA CLASE CHAR REALIZAMOS VALIDACION
                if (char.IsLetter(letra) == false)
                {
                    MessageBox.Show("Solo letras!!!");
                    break;
                }
            }
        }
    }
}
