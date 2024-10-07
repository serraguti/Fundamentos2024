using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoClases;
using System.Xml.Serialization;
using System.IO;

namespace Fundamentos2024
{
    public partial class Form16SerializarSimple : Form
    {
        //UN OBJETO PARA PODER REALIZAR LA SERIALIZACION
        XmlSerializer serializer;

        public Form16SerializarSimple()
        {
            InitializeComponent();
            //EN EL MOMENTO DE CREAR EL OBJETO SERIALIZER DEBEMOS
            //INDICAR LO QUE GUARDAREMOS EN SU INTERIOR (LA CLASE)
            //PARA INDICAR EL TIPO DE UNA CLASE SE UTILIZA LA SIGUIENTE SINTAXIS:
            // typeof(CLASE)
            this.serializer = new XmlSerializer(typeof(Mascota));
        }

        private async void btnGuardarMascota_Click(object sender, EventArgs e)
        {
            //CREAMOS UN OBJETO MASCOTA
            Mascota mascota = new Mascota();
            mascota.Nombre = this.txtNombre.Text;
            mascota.Raza = this.txtRaza.Text;
            mascota.Anyos = int.Parse(this.txtAnyos.Text);
            //DEBEMOS GUARDAR LA INFORMACION EN UN FICHERO
            //PARA ELLO SE UTILIZA LA CLASE StreamWriter
            //SI NO LE DECIMOS RUTA, SE ALMACENA EL FICHERO EN EL MISMO 
            //LUGAR DEL PROYECTO
            using (StreamWriter writer = new StreamWriter("mascota.xml")){
                //DEBEMOS SERIALIZAR EL OBJETO MASCOTA, PARA ELLO TENEMOS UN 
                //METODO LLAMADO Serialize
                this.serializer.Serialize(writer, mascota);
                await writer.FlushAsync();
                writer.Close();
            }
            this.txtNombre.Text = "";
            this.txtRaza.Text = "";
            this.txtAnyos.Text = "";
        }
    }
}
