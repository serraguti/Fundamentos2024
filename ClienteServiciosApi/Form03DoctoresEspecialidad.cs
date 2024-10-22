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
    public partial class Form03DoctoresEspecialidad : Form
    {
        private ServiceDoctores service;

        public Form03DoctoresEspecialidad()
        {
            InitializeComponent();
            this.service = new ServiceDoctores();
            //DEBEMOS LLAMAR A UN METODO ASINCRONO DENTRO DE UN CONSTRUCTOR
            //Task.Run(
            //    async () =>
            //    {
            //        List<string> especialidades = await
            //            this.service.GetEspecialidadesAsync();
            //        foreach (string espe in especialidades)
            //        {
            //            this.lstEspecialidades.Items.Add(espe);
            //        }
            //    });
        }

        private async void lstEspecialidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            string especialidad = this.lstEspecialidades.SelectedItem.ToString();
            List<Doctor> doctores = await this.service.GetDoctoresEspecialidadAsync(especialidad);
            this.lsvDoctores.Items.Clear();
            foreach (Doctor doc in doctores)
            {
                ListViewItem item = new ListViewItem();
                item.Text = doc.Apellido;
                item.SubItems.Add(doc.Salario.ToString());
                item.SubItems.Add(doc.Especialidad.ToString());
                this.lsvDoctores.Items.Add(item);
            }
        }

        private async void btnCargarEspecialidades_Click(object sender, EventArgs e)
        {
            List<string> especialidades = await
    this.service.GetEspecialidadesAsync();
            foreach (string espe in especialidades)
            {
                this.lstEspecialidades.Items.Add(espe);
            }
        }
    }
}
