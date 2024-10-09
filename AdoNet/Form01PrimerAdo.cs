using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AdoNet
{
    public partial class Form01PrimerAdo : Form
    {
        //DECLARAMOS LOS SIGUIENTES OBJETOS PARA CONECTAR CON BBDD
        //LA CADENA DE CONEXION A LA BASE DE DATOS
        string connectionString;
        //NECESITAMOS UN OBJETO CONNECTION PARA CONECTAR
        SqlConnection cn;
        //NECESITAMOS UN OBJETO COMMAND PARA LAS CONSULTAS
        SqlCommand com;
        //NECESITAMOS UN OBJETO DATAREADER PARA LEER
        SqlDataReader reader;

        public Form01PrimerAdo()
        {
            InitializeComponent();
            //Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;User ID=SA;Encrypt=True;Trust Server Certificate=True
            this.connectionString = @"Data Source=LOCALHOST;Initial Catalog=HOSPITAL;User ID=SA;Encrypt=True;Trust Server Certificate=True";
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {

        }
    }
}
