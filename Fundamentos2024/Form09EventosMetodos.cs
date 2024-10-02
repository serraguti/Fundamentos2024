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
            MessageBox.Show("Boton pulsado!!!!");
        }
    }
}
