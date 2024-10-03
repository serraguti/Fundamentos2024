using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Fundamentos2024
{
    public partial class Form10BotonesNumeros : Form
    {
        public Form10BotonesNumeros()
        {
            InitializeComponent();
            FileInfo file;
            
            Random random = new Random();
            //RECORREMOS TODOS LOS BOTONES (Button) DENTRO DEL 
            //FORMULARIO MEDIANTE LA COLECCION Controls
            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    int aleatorio = random.Next(1, 200);
                    control.Text = aleatorio.ToString();
                    control.BackColor = Color.LightGreen;
                    //CADA BOTON LEERA EL EVENTO SUMARNUMEROS()
                    control.Click += SumarNumeros;
                }
            }
        }

        void SumarNumeros(object sender, EventArgs e)
        {
            //CAPTURAMOS EL BOTON PULSADO MEDIANTE sender
            Button boton = (Button)sender;
            //CAPTURAMOS EL TEXTO NUMERICO DEL BOTON QUE HEMOS PULSADO
            int numero = int.Parse(boton.Text);
            //NECESITAMOS UN BUCLE DE 1 A 10
            //DENTRO DEL BUCLE MULTIPLICAR EL NUMERO POR i
            //AÑADIR EL RESULTADO DE ESA OPERACION AL LISTBOX Y SU COLECCION ITEMS
        }
    }
}
