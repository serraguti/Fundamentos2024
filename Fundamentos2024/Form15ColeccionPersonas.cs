using System;
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
    public partial class Form15ColeccionPersonas : Form
    {
        List<Persona> coleccionPersonas;

        public Form15ColeccionPersonas()
        {
            InitializeComponent();
            this.coleccionPersonas = new List<Persona>();
        }

        private void brtnGuardarPersona_Click(object sender, EventArgs e)
        {
            //CADA VEZ QUE PULSEMOS EL BOTON, CREAMOS UNA NUEVA PERSONA
            Persona persona = new Persona();
            persona.Nombre = this.txtNombre.Text;
            persona.Apellidos = this.txtApellidos.Text;
            persona.Edad = int.Parse(this.txtEdad.Text);
            //ALMACENAMOS LA PERSONA NUEVA EN LA COLECCION
            this.coleccionPersonas.Add(persona);
            this.lblMensaje.Text = "Personas: " + this.coleccionPersonas.Count;
        }
    }
}
