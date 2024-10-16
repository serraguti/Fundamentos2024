﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoClases;

namespace Fundamentos2024
{
    public partial class Form12TestClases : Form
    {
        public Form12TestClases()
        {
            InitializeComponent();
        }

        private void btnCrearPersona_Click(object sender, EventArgs e)
        {
            //COMENZAMOS CREANDO UNA NUEVA PERSONA
            Persona miPersona = new Persona("Nombre", "Apellidos", 66);
            miPersona.Nombre = "Andres";
            miPersona.Apellidos = "Leon";
            miPersona.Edad = 25;
            miPersona.Nacionalidad = Paises.Andorra;

            this.lstPropiedadesPersona.Items.Add
                (miPersona.Nombre + " " + miPersona.Apellidos + " " + miPersona.Edad);
            this.lstPropiedadesPersona.Items.Add(miPersona.GetNombreCompleto());
            this.lstPropiedadesPersona.Items.Add(miPersona.GetNombreCompleto(true));
        }
    }
}
