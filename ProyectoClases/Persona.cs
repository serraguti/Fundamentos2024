using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    //AQUI VAN LAS ENUMERACIONES
    public enum Paises { España, Francia, Alemania, China, Andorra, Colombia  }

    public class Persona
    {
        //ESTO ES PARA ORGANIZAR EL CODIGO CUANDO ES GIGANTE
        //PODEMOS CREAR BLOQUES DE CODIGO Y CERRARLOS O ABRIRLOS
        #region PROPIEDADES

        public Paises Nacionalidad { get; set; }

        //VAMOS A DECLARAR TRES PROPIEDADES/CARACTERISTICAS
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        //NECESITAMOS COMPROBAR SI LA EDAD ES CORRECTA
        //CAMPO/VARIABLE DE PROPIEDAD/CLASE (private)
        private int _CampoEdad;

        public int Edad
        {
            get
            {
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

        #endregion

        #region METODOS

        //CREAMOS UN METODO PARA DEVOLVER EL NOMBRE COMPLETO 
        //DE UNA PERSONA
        public string GetNombreCompleto()
        {
            return this.Nombre + " " + this.Apellidos;
        }

        #endregion
    }
}
