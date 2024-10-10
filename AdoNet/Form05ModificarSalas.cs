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
    public partial class Form05ModificarSalas : Form
    {
        string connectionString;
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form05ModificarSalas()
        {
            InitializeComponent();
            //this.connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;User ID=SA;Persist Security Info=True;";
            this.connectionString = @"Data Source=LOCALHOST;Initial Catalog=HOSPITAL;User ID=SA;Persist Security Info=True;";
            this.cn = new SqlConnection(this.connectionString);
            this.com = new SqlCommand();
            //DIBUJAR LOS NOMBRES DE SALA
            this.CargarSalas();
        }

        public void CargarSalas()
        {
            string sql = "select distinct nombre from sala";
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.lstSalas.Items.Clear();
            while (this.reader.Read())
            {
                string nombre = this.reader["NOMBRE"].ToString();
                this.lstSalas.Items.Add(nombre);
            }
            this.reader.Close();
            this.cn.Close();
        }

        private void btnModificarSalas_Click(object sender, EventArgs e)
        {
            string nuevoNombre = this.txtNombreSala.Text;
            string antiguoNombre = this.lstSalas.SelectedItem.ToString();
            string sql = "update SALA set NOMBRE=@nuevonombre where NOMBRE=@antiguonombre";
            //DEBEMOS CREAR DOS PARAMETROS
            SqlParameter pamNuevoNombre = new SqlParameter();
            pamNuevoNombre.ParameterName = "@nuevonombre";
            pamNuevoNombre.Value = nuevoNombre;
            //AÑADIMOS AL COMANDO EL PARAMETRO
            this.com.Parameters.Add(pamNuevoNombre);
            SqlParameter pamAntiguoNombre = new SqlParameter();
            pamAntiguoNombre.ParameterName = "@antiguonombre";
            pamAntiguoNombre.Value = antiguoNombre;
            this.com.Parameters.Add(pamAntiguoNombre);
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            int registros = this.com.ExecuteNonQuery();
            //CERRAMOS LA CONEXION
            this.cn.Close();
            //CUANDO TENEMOS PARAMETROS DEBEMOS ELIMINARLOS DEL COMANDO
            this.com.Parameters.Clear();
            this.CargarSalas();
            MessageBox.Show("Salas modificadas: " + registros);
        }
    }
}
