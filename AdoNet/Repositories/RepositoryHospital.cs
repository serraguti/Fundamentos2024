﻿using System;
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
            this.cn = new SqlConnection(Program.GetConnectionString());
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

        public List<Doctor> GetDoctoresHospital(int idhospital)
        {
            string sql = "select * from DOCTOR where HOSPITAL_COD=@idhospital";
            this.com.Parameters.AddWithValue("@idhospital", idhospital);
            this.com.Connection = this.cn;
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            List<Doctor> lista = new List<Doctor>();
            while (this.reader.Read())
            {
                Doctor doctor = new Doctor();
                doctor.IdDoctor = int.Parse(this.reader["DOCTOR_NO"].ToString());
                doctor.Apellido = this.reader["APELLIDO"].ToString();
                doctor.Especialidad = this.reader["ESPECIALIDAD"].ToString();
                doctor.Salario = int.Parse(this.reader["SALARIO"].ToString());
                doctor.IdHospital = int.Parse(this.reader["HOSPITAL_COD"].ToString());
                lista.Add(doctor);
            }
            this.reader.Close();
            this.cn.Close();
            this.com.Parameters.Clear();
            return lista;
        }

        public int IncrementarSalarioDoctores(int idHospital, int incremento)
        {
            string sql = "update DOCTOR set SALARIO=SALARIO + @incremento where HOSPITAL_COD=@idhospital";
            this.com.Parameters.AddWithValue("@incremento", incremento);
            this.com.Parameters.AddWithValue("@idhospital", idHospital);
            this.com.Connection = this.cn;
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            int resultados = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            return resultados;
        }

        public int ModificarEspecialidadDoctor(int idDoctor, string especialidad)
        {
            string sql = "update DOCTOR set ESPECIALIDAD=@especialidad where DOCTOR_NO=@iddoctor";
            this.com.Parameters.AddWithValue("@especialidad", especialidad);
            this.com.Parameters.AddWithValue("@iddoctor", idDoctor);
            this.com.Connection = this.cn;
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            int resultados = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            return resultados;
        }
    }
}
