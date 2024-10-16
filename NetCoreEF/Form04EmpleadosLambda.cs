using Microsoft.Extensions.DependencyInjection;
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
    public partial class Form04EmpleadosLambda : Form
    {
        private RepositoryEmpleados repo;

        public Form04EmpleadosLambda()
        {
            InitializeComponent();
            this.repo = Program.provider.GetService<RepositoryEmpleados>();
            //RECUPERAMOS LOS DATOS DE LOS OFICIOS
            List<string> oficios = this.repo.GetOficios();
            //SIMPLEMENTE DIBUJAMOS LOS OFICIOS EN EL Combobox
            foreach (string ofi in oficios)
            {
                this.cmbOficios.Items.Add(ofi);
            }
        }


    }
}
