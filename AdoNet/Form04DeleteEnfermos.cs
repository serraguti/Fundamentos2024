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
            this.connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;User ID=SA;Persist Security Info=True;";
            //this.connectionString = @"Data Source=LOCALHOST;Initial Catalog=HOSPITAL;User ID=SA;Persist Security Info=True;";

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //AQUI UNA CONSULTA PARA ELIMINAR UN ENFERMO POR SU INSCRIPCION
            //MOSTRAMOS EN EL LABEL EL NUMERO DE ENFERMOS ELIMINADOS
        }
    }
}
