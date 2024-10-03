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
        string rutaFichero;

        public Form13Files()
        {
            InitializeComponent();
            //INICIAMOS LA RUTA DENTRO DEL CONSTRUCTOR
            //EL SIMBOLO DE \ ES UN SIMBOLO DEL LENGUAJE, POR EJEMPLO
            //ES UTILIZADO PARA DAR UN ENTER EN UN STRING \n
            //TENEMOS DOS OPCIONES: 
            //1) PONER DOBLE CONTRABARRA
            this.rutaFichero = "C:\\Users\\Serra\\Documents\\test.txt";
            //2) UTILIZAR @ ANTES DEL STRING
            this.rutaFichero = @"C:\Users\Serra\Documents\test.txt";
        }

        private async void btnLeerFichero_Click(object sender, EventArgs e)
        {
            //NECESITAMOS LA RUTA QUE YA LA TENEMOS A NIVEL DE CLASE
            FileInfo file = new FileInfo(this.rutaFichero);
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
    }
}
