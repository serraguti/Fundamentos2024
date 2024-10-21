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
    public partial class Form01DoctoresApi : Form
    {
        private ServiceDoctores service;

        public Form01DoctoresApi()
        {
            InitializeComponent();
            this.service = new ServiceDoctores();
        }

        private async void btnCargarDoctores_Click(object sender, EventArgs e)
        {
            List<Doctor> doctores = await this.service.GetDoctoresAsync();
            this.lsvDoctores.Items.Clear();
            foreach (Doctor doc in doctores)
            {
                ListViewItem item = new ListViewItem();
                item.Text = doc.IdDoctor.ToString();
                item.SubItems.Add(doc.Apellido);
                item.SubItems.Add(doc.Especialidad);
                item.SubItems.Add(doc.Salario.ToString());
                item.SubItems.Add(doc.IdHospital.ToString());
                this.lsvDoctores.Items.Add(item);
            }
        }
    }
}
