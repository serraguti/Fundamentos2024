using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
