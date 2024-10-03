using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Persona
    {
        //VAMOS A DECLARAR TRES PROPIEDADES/CARACTERISTICAS
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        //NECESITAMOS COMPROBAR SI LA EDAD ES CORRECTA
        //CAMPO/VARIABLE DE PROPIEDAD/CLASE (private)
        private int _CampoEdad;

        public int Edad
        {
            get {
                return this._CampoEdad;
            }
            set
            {
                //value es la variable que es asignada
                //AQUI TENEMOS UN CODIGO PARA COMPROBAR LA EDAD
                if (value < 0)
                {
                    throw new Exception("Edad no puede ser negativa");
                }
                else
                {
                    this._CampoEdad = value;
                }
            }
        }
    }
}
