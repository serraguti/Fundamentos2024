using ClienteServiciosApi.Models;
using ClienteServiciosApi.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteServiciosApi
{
    public partial class Form02BuscadorDoctorID : Form
    {
        private ServiceDoctores service;

        public Form02BuscadorDoctorID()
        {
            InitializeComponent();
            this.service = new ServiceDoctores();
        }

        private async void btnBuscarDoctor_Click(object sender, EventArgs e)
        {
            int idDoctor = int.Parse(this.txtIdDoctor.Text);
            Doctor doctor = await this.service.FindDoctorAsync(idDoctor);
            //SI NO ENCUENTRA DOCTOR, DEVOLVERA UN NULL
            if (doctor != null)
            {
                this.txtApellido.Text = doctor.Apellido;
                this.txtEspecialidad.Text = doctor.Especialidad;
                this.txtSalario.Text = doctor.Salario.ToString();
                this.txtHospital.Text = doctor.IdHospital.ToString();
            }
            else
            {
                MessageBox.Show("No hemos encontrado doctor con ID " + idDoctor);
            }
        }
    }
}
