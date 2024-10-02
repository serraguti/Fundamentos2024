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
    public partial class Form09EventosMetodos : Form
    {
        public Form09EventosMetodos()
        {
            InitializeComponent();
            this.button1.Click += BotonPulsado;
            this.button2.Click += BotonPulsado;
            this.button3.Click += BotonPulsado;
        }

        //CREAMOS UN METODO DE EVENTO
        void BotonPulsado(object sender, EventArgs e)
        {
            //Y SI NECESITO SABER QUE BOTON HEMOS PULSADO????
            //LA SOLUCION ES UTILIZAR SENDER
            //sender SON BOTONES
            //DEBEMOS CONVERTIR SENDER EN UN OBJETO Button
            Button boton = (Button)sender;
            boton.BackColor = Color.Yellow;
            MessageBox.Show("Boton pulsado!!!!");
        }

        private void lblRaton_Click(object sender, EventArgs e)
        {

        }

        private void lblRaton_MouseMove(object sender, MouseEventArgs e)
        {
            //SIEMPRE QUE SEA DISTINTO A EventArgs TENEMOS INFORMACION
            //QUE PODRIA SER UTIL...
            this.lblRaton.Text = "X: " + e.X + ", Y: " + e.Y;
        }

        private void txtSoloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.KeyChar CARACTER QUE HEMOS PULSADO
            //ME PERMITE MANEJAR EL EVENTO DE FORMA MANUAL
            //e.Handled = true;
            //TENEMOS ALGUNA FORMA DE SABER SI UN CHAR ES LETRA O NO????
            if (char.IsLetter(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }
    }
}
