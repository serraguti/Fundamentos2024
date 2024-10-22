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
    public partial class Form04DoctoresHospital : Form
    {
        private ServiceDoctores service;

        public Form04DoctoresHospital()
        {
            InitializeComponent();
            this.service = new ServiceDoctores();
        }

        private async void btnBuscarDoctores_Click(object sender, EventArgs e)
        {
            int idhospital = int.Parse(this.txtHospital.Text);
            List<Doctor> doctores = await this.service.GetDoctoresHospitalAsync(idhospital);
            this.lstDoctores.Items.Clear();
            if (doctores != null)
            {
                foreach (Doctor doc in doctores)
                {
                    this.lstDoctores.Items.Add(doc.Apellido);
                }
            }
            else
            {
                MessageBox.Show("No existen doctores en el hospital " + idhospital);
            }
        }
    }
}
