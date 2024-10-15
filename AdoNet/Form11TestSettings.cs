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
            ConfigurationBuilder builder = new ConfigurationBuilder();
            //DEBEMOS INDICAR DONDE TENEMOS LA CADENA DE CONEXION
            //EL FICHERO Y SU NOMBRE (appsettings.json)
            builder.SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", false, true);
            //CONSTRUIMOS EL FICHERO PARA NUESTRA APP
            IConfigurationRoot configuration = builder.Build();
            //SIMPLEMENTE TENEMOS QUE RECUPERAR LOS DATOS DE NUESTRO FICHERO
            //DENTRO DEL FICHERO, TENEMOS ZONAS CONOCIDAS Y ZONAS INVENTADAS
            //SI ES UNA ZONA CONOCIDA COMO ConnectionStrings SE UTILIZA EL 
            //METODO GetConnectionString("KEY")
            string connectionString = configuration.GetConnectionString("HospitalExpress");
            this.lblCadenaConexion.Text = connectionString; 
        }
    }
}
