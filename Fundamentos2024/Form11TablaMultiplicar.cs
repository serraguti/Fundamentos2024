﻿using System;
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
    public partial class Form11TablaMultiplicar : Form
    {
        public Form11TablaMultiplicar()
        {
            InitializeComponent();
            Random random = new Random();
            foreach (Control miControl in this.Controls)
            {
                if (miControl is Button)
                {
                    int numeroAleatorio = random.Next(1, 40);
                    miControl.Text = numeroAleatorio.ToString();
                    miControl.Click += TablaMultiplicar;
                }
            }
        }

        void TablaMultiplicar(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            int numeroBoton = int.Parse(boton.Text);
            //LIMPIAMOS EL CONTENIDO DEL LISTBOX
            this.lstTablaMultiplicar.Items.Clear();
            //REALIZAMOS UN BUCLE DE 1 A 10
            for (int i = 1; i <= 10; i++)
            {
                //REALIZAMOS LA OPERACION DE MULTIPLICAR EL NUMERO
                //DEL BOTON POR LA VARIABLE i DEL BUCLE
                int operacion = numeroBoton * i;
                //AÑADIMOS CADA NUMERO A LA COLECCION DEL LISTBOX
                this.lstTablaMultiplicar.Items.Add(operacion);
            }
        }
    }
}
