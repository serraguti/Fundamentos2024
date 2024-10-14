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

        private void CargarHospitales() {
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
    }
}
