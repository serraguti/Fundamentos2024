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
    public partial class Form02BuscadorSalarios : Form
    {
        string connectionString;
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form02BuscadorSalarios()
        {
            InitializeComponent();
            //this.connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;User ID=SA;Persist Security Info=True;";
            this.connectionString = @"Data Source=LOCALHOST;Initial Catalog=HOSPITAL;User ID=SA;Persist Security Info=True;";
            this.cn = new SqlConnection(this.connectionString);
            this.com = new SqlCommand();
        }

        private void btnBuscarEmpleados_Click(object sender, EventArgs e)
        {
            string sql = "select * from EMP where SALARIO >= " + this.txtSalario.Text;
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            //ABRIMOS CONEXION
            this.cn.Open();
            //EJECUTAMOS EL COMANDO CON LA CONSULTA
            this.reader = this.com.ExecuteReader();
            //LIMPIAMOS LA LISTA VISUAL
            this.lstEmpleados.Items.Clear();
            //RECORREMOS EL LECTOR FILA A FILA
            while (this.reader.Read())
            {
                //EXTRAEMOS LOS DATOS QUE NECESITEMOS
                string apellido = this.reader["APELLIDO"].ToString();
                string salario = this.reader["SALARIO"].ToString();
                //DIBUJAMOS LOS DATOS
                this.lstEmpleados.Items.Add(apellido + " - " + salario);
            }
            //CERRAMOS TODOS LOS RECURSOS PARA PODER REUTILIZARLOS
            this.reader.Close();
            this.cn.Close();
        }
    }
}
