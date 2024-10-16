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
    public partial class Form03Hospitales : Form
    {
        private RepositoryHospital repo;

        public Form03Hospitales()
        {
            InitializeComponent();
            this.repo = Program.provider.GetService<RepositoryHospital>();
        }

        private void btnCargarHospitales_Click(object sender, EventArgs e)
        {
            List<Hospital> hospitales = this.repo.GetHospitales();
            this.lstHospitales.Items.Clear();
            foreach (Hospital h in hospitales)
            {
                this.lstHospitales.Items.Add(h.Nombre + " - " + h.Camas);
            }
        }
    }
}
