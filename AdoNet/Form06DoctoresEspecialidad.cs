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
    public partial class Form06DoctoresEspecialidad : Form
    {
        string connectionString;
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form06DoctoresEspecialidad()
        {
            InitializeComponent();
            //this.connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;User ID=SA;Persist Security Info=True;";
            this.connectionString = @"Data Source=LOCALHOST;Initial Catalog=HOSPITAL;User ID=SA;Persist Security Info=True;";
            this.cn = new SqlConnection(this.connectionString);
            this.com = new SqlCommand();
            //CARGAMOS LAS ESPECIALIDADES
            string sql = "select distinct ESPECIALIDAD from DOCTOR";
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.lstEspecialidades.Items.Clear();
            while (this.reader.Read())
            {
                string especialidad = this.reader["ESPECIALIDAD"].ToString();
                this.lstEspecialidades.Items.Add(especialidad);
            }
            this.reader.Close();
            this.cn.Close();
        }
    }
}
