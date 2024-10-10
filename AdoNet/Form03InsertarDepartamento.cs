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
    public partial class Form03InsertarDepartamento : Form
    {
        string connectionString;
        SqlConnection cn;
        SqlCommand com;

        public Form03InsertarDepartamento()
        {
            InitializeComponent();
            //this.connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;User ID=SA;Persist Security Info=True;";
            this.connectionString = @"Data Source=LOCALHOST;Initial Catalog=HOSPITAL;User ID=SA;Persist Security Info=True;";
            this.cn = new SqlConnection(this.connectionString);
            this.com = new SqlCommand();
        }

        private void btnInsertarDepartamento_Click(object sender, EventArgs e)
        {
            string numero = this.txtNumero.Text;
            string nombre = this.txtNombre.Text;
            string localidad = this.txtLocalidad.Text;
            //BORRAR, COMILLA DOBLE (2 VECES) Y DOS MAS
            string sql = "insert into DEPT values ("
                + numero + ", '" + nombre + "', '" + localidad + "')";
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            //ABRIMOS CONEXION
            this.cn.Open();
            //AL SER UNA CONSULTA DE ACCION, SE EJECUTA CON EL COMANDO Y 
            //CON EL METODO ExecuteNonQuery() QUE DEVUELVE EL NUMERO DE 
            //REGISTROS INSERTADOS
            int registros = this.com.ExecuteNonQuery();
            //CERRAMOS CONEXION
            this.cn.Close();
            this.lblMensaje.Text = "Insertados: " + registros;
        }
    }
}
