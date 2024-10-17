using Microsoft.Extensions.DependencyInjection;
using NetCoreEF.Models;
using NetCoreEF.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetCoreEF
{
    public partial class Form05DoctoresPracticaPaco : Form
    {
        private RepositoryDoctores repo;

        public Form05DoctoresPracticaPaco()
        {
            InitializeComponent();
            this.repo =
                Program.provider.GetService<RepositoryDoctores>();
        }

        private void btnCargarDoctores_Click(object sender, EventArgs e)
        {
            List<Doctor> doctores = this.repo.GetDoctores();
            this.lstDoctores.Items.Clear();
            foreach (Doctor doc in doctores)
            {
                this.lstDoctores.Items.Add(doc.Apellido + " - " + doc.Especialidad);
            }
        }
    }
}
