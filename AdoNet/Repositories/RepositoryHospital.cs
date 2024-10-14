using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using AdoNet.Models;

namespace AdoNet.Repositories
{
    public class RepositoryHospital
    {
        private string connectionString;
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        public RepositoryHospital()
        {
            //this.connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;User ID=SA;Persist Security Info=True;";
            this.connectionString = @"Data Source=LOCALHOST;Initial Catalog=HOSPITAL;User ID=SA;Persist Security Info=True;";
            this.cn = new SqlConnection(this.connectionString);
            this.com = new SqlCommand();
        }

        public List<Hospital> GetHospitales()
        {
            string sql = "select * from HOSPITAL";
            this.com.Connection = this.cn;
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            //CREAMOS LA COLECCION DE HOSPITALES
            List<Hospital> lista = new List<Hospital>();
            while (this.reader.Read())
            {
                //CREAMOS UN OBJETO DE LA CLASE HOSPITAL
                Hospital hospital = new Hospital();
                //EXTRAEMOS LOS DATOS DE CADA HOSPITAL
                //Y ASIGNAMOS SUS PROPIEDADES
                hospital.IdHospital = int.Parse(this.reader["HOSPITAL_COD"].ToString());
                hospital.Nombre = this.reader["NOMBRE"].ToString();
                hospital.Direccion = this.reader["DIRECCION"].ToString();
                hospital.Telefono = this.reader["TELEFONO"].ToString();
                hospital.Camas = int.Parse(this.reader["NUM_CAMA"].ToString());
                //AGREGAMOS CADA HOSPITAL A LA LISTA
                lista.Add(hospital);
            }
            this.reader.Close();
            this.cn.Close();
            return lista;
        }
    }
}
