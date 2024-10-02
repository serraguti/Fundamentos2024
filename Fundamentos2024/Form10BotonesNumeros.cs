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
    public partial class Form10BotonesNumeros : Form
    {
        public Form10BotonesNumeros()
        {
            InitializeComponent();
            //RECORREMOS TODOS LOS BOTONES (Button) DENTRO DEL 
            //FORMULARIO MEDIANTE LA COLECCION Controls
            foreach (Button boton in this.Controls)
            {
                boton.BackColor = Color.LightGreen;
            }
        }
    }
}
