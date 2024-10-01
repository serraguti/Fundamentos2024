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
    public partial class Form04Char : Form
    {
        public Form04Char()
        {
            InitializeComponent();
        }

        private void btnIniciarAscii_Click(object sender, EventArgs e)
        {
            string cadena = "hola coca cola";
            //DEVUELVE A PARTIR DE UN INDICE
            string subCadena = cadena.Substring(6, 3); //oca
            this.txtLetras.Text = subCadena;





            ////RECORREMOS TODOS LOS CARACTERES DEL CODIGO ASCII 0-255
            //for (int i = 0; i <= 255; i++)
            //{
            //    //CONVERTIMOS CADA NUMERO ASCII EN LETRA/CARACTER
            //    char caracter = (char) i;
            //    //PREGUNTAR POR CADA VALOR DEL CARACTER
            //    if (char.IsLetter(caracter) == true)
            //    {
            //        this.txtLetras.Text += caracter;
            //    }
            //    else if (char.IsNumber(caracter) == true)
            //    {
            //        this.txtNumeros.Text += caracter;
            //    }
            //    else if (char.IsSymbol(caracter) == true)
            //    {
            //        this.txtSimbolos.Text += caracter;
            //    }
            //    else if (char.IsPunctuation(caracter) == true)
            //    {
            //        this.txtPuntuacion.Text += caracter;
            //    }
            //}
        }
    }
}
