using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Fundamentos2024
{
    public partial class Form13Files : Form
    {
        public Form13Files()
        {
            InitializeComponent();
        }

        private async void btnLeerFichero_Click(object sender, EventArgs e)
        {
            //NECESITAMOS LA RUTA DEL FICHERO
            this.openFileDialog1.ShowDialog();
            string path = this.openFileDialog1.FileName;
            FileInfo file = new FileInfo(path);
            //CON LA CLASE TextReader LEEMOS TEXTO PLANO DE UN FICHERO
            using (TextReader reader = file.OpenText())
            {
                //SI TENEMOS METODOS Async PARA LEER, DEBEMOS UTILIZARLOS
                //LOS METODOS ASYNC FINALIZAN CON ESA PALABRA
                //LEEMOS EL CONTENIDO DEL FILE
                string contenido = await reader.ReadToEndAsync();
                //DEBEMOS CERRAR EL FICHERO
                reader.Close();
                this.txtContenido.Text = contenido;
            }
        }

        private async void btnGuardarFichero_Click(object sender, EventArgs e)
        {
            //NECESITAMOS LA RUTA AL FICHERO
            this.saveFileDialog1.ShowDialog();
            string path = this.saveFileDialog1.FileName;
            FileInfo file = new FileInfo(path);
            using (TextWriter writer = file.CreateText())
            {
                //RECUPERAMOS EL CONTENIDO DE LA CAJA
                string contenido = this.txtContenido.Text;
                //ESCRIBIMOS EL CONTENIDO EN EL FILE
                await writer.WriteAsync(contenido);
                //SIEMPRE QUE ESCRIBAMOS FILES, DEBEMOS LLAMAR AL
                //METODO FLUSH PARA QUE HAGA EL VACIADO DE MEMORIA
                await writer.FlushAsync();
                writer.Close();
                MessageBox.Show("Datos almacenados");
            }
        }
    }
}
