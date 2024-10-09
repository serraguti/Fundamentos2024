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
            //Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;User ID=SA;Encrypt=True;Persist Security Info=True;
            this.connectionString = @"Data Source=LOCALHOST;Initial Catalog=HOSPITAL;User ID=SA;Persist Security Info=True;";
            //CREAMOS LA CONEXION
            //INDICAMOS LA CADENA DE CONEXION PARA CONECTAR CON SQL SERVER
            this.cn = new SqlConnection(this.connectionString);
            //CREAMOS EL COMANDO
            this.com = new SqlCommand();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            //PREGUNTAMOS POR EL ESTADO DE LA CONEXION
            if (this.cn.State == ConnectionState.Closed)
            {
                //ABRIMOS LA CONEXION
                this.cn.Open();
                this.lblMensaje.BackColor = Color.LightGreen;
            }
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            //DESCONECTAMOS DE LA BASE DE DATOS
            this.cn.Close();
            this.lblMensaje.BackColor = Color.Red;
        }
    }
}
