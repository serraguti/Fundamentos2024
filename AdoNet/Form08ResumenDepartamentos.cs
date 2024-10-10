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
    public partial class Form08ResumenDepartamentos : Form
    {
        string connectionString;
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form08ResumenDepartamentos()
        {
            InitializeComponent();
            //this.connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;User ID=SA;Persist Security Info=True;";
            this.connectionString = @"Data Source=LOCALHOST;Initial Catalog=HOSPITAL;User ID=SA;Persist Security Info=True;";
            this.cn = new SqlConnection(this.connectionString);
            this.com = new SqlCommand();
            string sql = "select * from DEPT";
            //CONFIGURAMOS LA CONEXION DEL COMANDO (SOTA)
            this.com.Connection = this.cn;
            //CONFIGURAMOS EL TIPO DE CONSULTA QUE VAMOS A UTILIZAR (CABALLO)
            this.com.CommandType = CommandType.Text;
            //INDICAMOS LA PROPIA CONSULTA SQL (REY)
            this.com.CommandText = sql;
            //ABRIMOS LA CONEXION
            this.cn.Open();
            //COMO ES UNA CONSULTA DE SELECCION UTILIZAMOS UN READER
            //EJECUTAMOS LA CONSULTA
            this.reader = this.com.ExecuteReader();
            //AHORA MISMO TENEMOS LOS DATOS DENTRO DEL READER
            //EL SIGUIENTE PASO ES DECIDIR DONDE LO DIBUJAMOS (ListBox)
            this.lstDepartamentos.Items.Clear();
            //RECORREMOS LOS DATOS DEL READER
            while (this.reader.Read())
            {
                //RECUPERAMOS EL NOMBRE DEL DEPARTAMENTO POR SU COLUMNA
                string nombre = this.reader["DNOMBRE"].ToString();
                this.lstDepartamentos.Items.Add(nombre);
            }
            //DEBEMOS CERRAR Y LIMPIAR TODOS LOS RECURSOS UTILIZADOS EN BBDD
            this.reader.Close();
            this.cn.Close();
        }
    }
}
