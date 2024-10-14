using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AdoNet.Repositories
{
    public class RepositoryDepartamentos
    {
        private string connectionString;
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        public RepositoryDepartamentos()
        {
            //this.connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;User ID=SA;Persist Security Info=True;";
            this.connectionString = @"Data Source=LOCALHOST;Initial Catalog=HOSPITAL;User ID=SA;Persist Security Info=True;";
            this.cn = new SqlConnection(this.connectionString);
            this.com = new SqlCommand();
        }

        //METODO PARA INSERTAR UN DEPARTAMENTO
        //NECESITAMOS EL NUMERO, EL NOMBRE Y LA LOCALIDAD
        public int InsertarDepartamento(int id, string nombre, string localidad)
        {
            string sql = "insert into DEPT values (@numero, @nombre, @localidad)";
            SqlParameter pamId = new SqlParameter();
            pamId.ParameterName = "@numero";
            pamId.Value = id;
            this.com.Parameters.Add(pamId);
            SqlParameter pamNombre = new SqlParameter();
            pamNombre.ParameterName = "@nombre";
            pamNombre.Value = nombre;
            this.com.Parameters.Add(pamNombre);
            SqlParameter pamLocalidad = new SqlParameter();
            pamLocalidad.ParameterName = "@localidad";
            pamLocalidad.Value = localidad;
            this.com.Parameters.Add(pamLocalidad);
            this.com.Connection = this.cn;
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            int insertados = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            return insertados;
        }
    }
}
