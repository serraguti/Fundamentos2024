using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using AdoNet.Models;

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
            this.cn = new SqlConnection(Program.GetConnectionString());
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

        //METODO ELIMINAR
        public int EliminarDepartamento(int id)
        {
            string sql = "delete from DEPT where DEPT_NO=@numero";
            //TENEMOS UNA FORMA MAS SIMPLE DE GUARDAR PARAMETROS EN UNA SOLA LINEA
            this.com.Parameters.AddWithValue("@numero", id);
            this.com.Connection = this.cn;
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            int resultados = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            return resultados;
        }

        //METODO PARA MODIFICAR
        public int ModificarDepartamento(int id, string nombre, string localidad)
        {
            string sql = "update DEPT set DNOMBRE=@nombre, LOC=@localidad "
                + " where DEPT_NO=@numero";
            this.com.Parameters.AddWithValue("@numero", id);
            this.com.Parameters.AddWithValue("@nombre", nombre);
            this.com.Parameters.AddWithValue("@localidad", localidad);
            this.com.Connection = this.cn;
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            int resultados = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            return resultados;
        }

        //NECESITAMOS UN METODO PARA DEVOLVER EL CONJUNTO DE LOS DEPARTAMENTOS
        //DEVOLVEREMOS UN List<Departamento>
        public List<Departamento> GetDepartamentos()
        {
            string sql = "select * from DEPT";
            this.com.Connection = this.cn;
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            //CREAMOS UNA NUEVA LISTA DE DEPARTAMENTOS PARA GUARDAR LOS DATOS
            List<Departamento> lista = new List<Departamento>();
            while (this.reader.Read())
            {
                //EXTRAEMOS LOS DATOS DE LA BBDD
                int id = int.Parse(this.reader["DEPT_NO"].ToString());
                string nombre = this.reader["DNOMBRE"].ToString();
                string localidad = this.reader["LOC"].ToString();
                //POR CADA FILA DE LA BBDD, CREAMOS UN NUEVO Departamento
                Departamento dept = new Departamento();
                dept.IdDepartamento = id;
                dept.Nombre = nombre;
                dept.Localidad = localidad;
                //AÑADIMOS CADA OBJETO Departamento A LA COLECCION/CONJUNTO
                lista.Add(dept);
            }
            this.reader.Close();
            this.cn.Close();
            return lista;
        }
    }
}
