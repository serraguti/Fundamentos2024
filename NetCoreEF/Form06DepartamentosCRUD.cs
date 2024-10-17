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
    public partial class Form06DepartamentosCRUD : Form
    {
        private RepositoryDepartamentos repo; 

        public Form06DepartamentosCRUD()
        {
            InitializeComponent();
            this.repo = Program.provider.GetService<RepositoryDepartamentos>();
            this.CargarDepartamentos();
        }

        private void CargarDepartamentos()
        {
            List<Departamento> departamentos = this.repo.GetDepartamentos();
            this.lsvDepartamentos.Items.Clear();
            foreach (Departamento departamento in departamentos)
            {
                ListViewItem item = new ListViewItem();
                item.Text = departamento.IdDepartamento.ToString();
                item.SubItems.Add(departamento.Nombre);
                item.SubItems.Add(departamento.Localidad);
                this.lsvDepartamentos.Items.Add(item);
            }
        }
    }
}
