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
        public string Nombre;
        public string Apellidos;
        //NECESITAMOS COMPROBAR SI LA EDAD ES CORRECTA
        //CAMPO/VARIABLE DE PROPIEDAD/CLASE (private)
        private int _CampoPropiedad;

        public int Propiedad
        {
            get {
                return VALOR;
            }
            set
            {
                //value es la variable que es asignada
            }
        }
    }
}
