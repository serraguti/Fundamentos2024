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
    public partial class Form07EmpleadosOficio : Form
    {
        string connectionString;
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form07EmpleadosOficio()
        {
            InitializeComponent();
            //this.connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;User ID=SA;Persist Security Info=True;";
            this.connectionString = @"Data Source=LOCALHOST;Initial Catalog=HOSPITAL;User ID=SA;Persist Security Info=True;";
            this.cn = new SqlConnection(this.connectionString);
            this.com = new SqlCommand();
            string sql = "select distinct OFICIO from EMP";
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.lstOficios.Items.Clear();
            while (this.reader.Read())
            {
                string oficio = this.reader["OFICIO"].ToString();
                this.lstOficios.Items.Add(oficio);
            }
            this.reader.Close();
            this.cn.Close();
        }

        private void btnIncrementarSalarios_Click(object sender, EventArgs e)
        {
            //DEBEMOS PREGUNTAR SI TENEMOS ALGUN DATO SELECCIONADO (OFICIOS)
            if (this.lstOficios.SelectedIndex == -1)
            {
                //AQUI NO TENEMOS NADA SELECCIONADO
                MessageBox.Show("Selecciona un oficio primero");
            }
            else
            {
                string incremento = this.txtIncrementoSalarial.Text;
                string oficio = this.lstOficios.SelectedItem.ToString();
                string sql = "update EMP set SALARIO = SALARIO + @incremento where OFICIO=@oficio";
                SqlParameter pamIncremento = new SqlParameter();
                pamIncremento.ParameterName = "@incremento";
                pamIncremento.Value = incremento;
                this.com.Parameters.Add(pamIncremento);
                SqlParameter pamOficio = new SqlParameter();
                pamOficio.ParameterName = "@oficio";
                pamOficio.Value = oficio;
                this.com.Parameters.Add(pamOficio);
                this.com.Connection = this.cn;
                this.com.CommandType = CommandType.Text;
                this.com.CommandText = sql;
                this.cn.Open();
                int modificados = this.com.ExecuteNonQuery();
                this.cn.Close();
                this.com.Parameters.Clear();
                MessageBox.Show("Empleados modificados: " + modificados);
            }
        }

        private void lstOficios_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select * from EMP where OFICIO=@oficio";
            string oficio = this.lstOficios.SelectedItem.ToString();
            SqlParameter pamOficio = new SqlParameter();
            pamOficio.ParameterName = "@oficio";
            pamOficio.Value = oficio;
            this.com.Parameters.Add(pamOficio);
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.lstEmpleados.Items.Clear();
            while (this.reader.Read())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                this.lstEmpleados.Items.Add(apellido);
            }
            this.reader.Close();
            this.cn.Close();
            this.com.Parameters.Clear();
        }
    }
}
