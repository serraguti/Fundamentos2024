using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdoNet.Models;
using AdoNet.Repositories;

namespace AdoNet
{
    public partial class Form10HospitalesDoctores : Form
    {
        private RepositoryHospital repo;

        public Form10HospitalesDoctores()
        {
            InitializeComponent();
            this.repo = new RepositoryHospital();
            this.CargarHospitales();
        }

        private void CargarHospitales()
        {
            List<Hospital> hospitales = this.repo.GetHospitales();
            this.lsvHospitales.Items.Clear();
            foreach (Hospital hospital in hospitales)
            {
                //CREAMOS UN ListViewItem
                ListViewItem item = new ListViewItem();
                item.Text = hospital.IdHospital.ToString();
                item.SubItems.Add(hospital.Nombre);
                item.SubItems.Add(hospital.Direccion);
                item.SubItems.Add(hospital.Telefono);
                item.SubItems.Add(hospital.Camas.ToString());
                //AGREGAMOS EL Item A LA LISTA DEL DIBUJO
                this.lsvHospitales.Items.Add(item);
            }
        }

        private void lsvHospitales_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DEBEMOS PREGUNTAR SI TENEMOS ALGUN HOSPITAL SELECCIONADO
            //PARA PODER MOSTRAR LOS DOCTORES
            if (this.lsvHospitales.SelectedItems.Count != 0)
            {
                //EL SIGUIENTE PASO ES RECUPERAR EL ELEMENTO SELECCIONADO
                //PARA ELLO, SE REALIZA MEDIANTE SelectedItems[0]
                ListViewItem itemSeleccionado = this.lsvHospitales.SelectedItems[0];
                //RECUPERAMOS EL TEXTO DEL ITEM QUE ES LA PRIMERA COLUMNA DEL 
                //CONTROL LISTVIEW
                int idHospital = int.Parse(itemSeleccionado.Text);
                this.CargarDoctores(idHospital);
            }
        }

        private void btnIncrementarSalarios_Click(object sender, EventArgs e)
        {
            int incremento = int.Parse(this.txtIncremento.Text);
            int idHospital = int.Parse(this.lsvHospitales.SelectedItems[0].Text);
            int modificados = this.repo.IncrementarSalarioDoctores(idHospital, incremento);
            MessageBox.Show("Doctores modificados: " + modificados);
            //VOLVEMOS A DIBUJAR LOS DOCTORES
            this.CargarDoctores(idHospital);
        }

        private void CargarDoctores(int idHospital)
        {
            List<Doctor> doctores = this.repo.GetDoctoresHospital(idHospital);
            this.lsvDoctor.Items.Clear();
            foreach (Doctor doc in doctores)
            {
                ListViewItem item = new ListViewItem();
                item.Text = doc.IdDoctor.ToString();
                item.SubItems.Add(doc.Apellido);
                item.SubItems.Add(doc.Especialidad);
                item.SubItems.Add(doc.Salario.ToString());
                item.SubItems.Add(doc.IdHospital.ToString());
                //DIBUJAR CADA ITEM DENTRO DEL DIBUJO DEL LISTVIEW
                this.lsvDoctor.Items.Add(item);
            }
        }

        private void btnCambiarEspecialidad_Click(object sender, EventArgs e)
        {
            int iddoctor = int.Parse(this.lsvDoctor.SelectedItems[0].Text);
            string especialidad = this.txtEspecialidad.Text;
            int afectados = this.repo.ModificarEspecialidadDoctor(iddoctor, especialidad);
            MessageBox.Show("Doctores modificados: " + afectados);
            int idhospital = int.Parse(this.lsvHospitales.SelectedItems[0].Text);
            this.CargarDoctores(idhospital);
        }
    }
}
