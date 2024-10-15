using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNet
{
    public partial class Form11TestSettings : Form
    {
        public Form11TestSettings()
        {
            InitializeComponent();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            IConfigurationRoot configuration = Program.GetConfiguration();
            //SIMPLEMENTE TENEMOS QUE RECUPERAR LOS DATOS DE NUESTRO FICHERO
            //DENTRO DEL FICHERO, TENEMOS ZONAS CONOCIDAS Y ZONAS INVENTADAS
            //SI ES UNA ZONA CONOCIDA COMO ConnectionStrings SE UTILIZA EL 
            //METODO GetConnectionString("KEY")
            //string connectionString = configuration.GetConnectionString("HospitalExpress");
            //this.lblCadenaConexion.Text = connectionString;
            this.lblCadenaConexion.Text = Program.GetConnectionString();
            //SI ES UNA ZONA NO CONOCIDA (Imagenes) DEBEMOS RECUPERAR LOS ELEMENTOS
            //CON GetSection("KEY:SUBKEY")
            string imagen1 = configuration.GetSection("Imagenes:Imagen1").Value;
            string imagen2 = configuration.GetSection("Imagenes:Imagen2").Value;
            this.pictureBox1.Load(imagen1);
            this.pictureBox2.Load(imagen2);
        }
    }
}
