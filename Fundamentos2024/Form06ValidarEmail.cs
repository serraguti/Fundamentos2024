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
    public partial class Form06ValidarEmail : Form
    {
        public Form06ValidarEmail()
        {
            InitializeComponent();
        }

        private void btnValidarEmail_Click(object sender, EventArgs e)
        {
            string email = this.txtEmail.Text;
            //NECESITAMOS BUSCAR UNA @
            if (email.Contains("@") == false)
            {
                this.lblMensaje.Text = "No existe @ en el mail";
            }
            else
            {
                this.lblMensaje.Text = "Mail correcto";
            }
            //VUESTROS IF A PARTIR DE AQUI

        }
    }
}
