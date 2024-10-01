using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos2024
{
    public partial class Form05SumarTextoNumeros : Form
    {
        public Form05SumarTextoNumeros()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            //CAPTURAMOS EL TEXTO DE LA CAJA DE NUMEROS
            string textoSuma = this.txtNumeros.Text;

        }
    }
}
