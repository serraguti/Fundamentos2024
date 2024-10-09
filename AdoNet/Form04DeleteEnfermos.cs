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
    public partial class Form04DeleteEnfermos : Form
    {
        string connectionString;
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form04DeleteEnfermos()
        {
            InitializeComponent();
            //this.connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;User ID=SA;Persist Security Info=True;";
            this.connectionString = @"Data Source=LOCALHOST;Initial Catalog=HOSPITAL;User ID=SA;Persist Security Info=True;";
            this.cn = new SqlConnection(this.connectionString);
            this.com = new SqlCommand();
            this.CargarEnfermos();
        }

        private void CargarEnfermos()
        {
            //AL INICIAR EL FORMULARIO QUEREMOS DIBUJAR LOS ENFERMOS
            string sql = "select * from ENFERMO";
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            //ENTRAR
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            //ELIMINAMOS LOS DATOS DEL DIBUJO
            this.lstEnfermos.Items.Clear();
            //RECORREMOS TODOS LOS DATOS DEL READER
            while (this.reader.Read())
            {
                string inscripcion = this.reader["INSCRIPCION"].ToString();
                string apellido = this.reader["APELLIDO"].ToString();
                this.lstEnfermos.Items.Add(inscripcion + " - " + apellido);
            }
            //SALIMOS
            this.cn.Close();
            this.reader.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //AQUI UNA CONSULTA PARA ELIMINAR UN ENFERMO POR SU INSCRIPCION
            //MOSTRAMOS EN EL LABEL EL NUMERO DE ENFERMOS ELIMINADOS
            string inscripcion = this.txtInscripcion.Text;
            string sql = "delete from ENFERMO where INSCRIPCION=" + inscripcion;
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            int registrosEliminados = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.lblMensaje.Text = "Enfermos eliminados: " + registrosEliminados;
            this.CargarEnfermos();
        }
    }
}
