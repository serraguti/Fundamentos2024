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
            if (email.StartsWith("@") == true)
            {
                this.lblMensaje.Text = "Email con @ al inicio";
            }
            else
            {
                this.lblMensaje.Text = "Mail correcto";
            }
            if (email.IndexOf("@") == 0)
            {
                this.lblMensaje.Text = "Email con @ al inicio";
            }
            else
            {
                this.lblMensaje.Text = "Mail correcto";
            }
            if (email.EndsWith("@") == true)
            {
                this.lblMensaje.Text = "@ al final del Email";
            }
            else
            {
                this.lblMensaje.Text = "Mail correcto";
            }
            if (email.IndexOf("@") == email.Length - 1)
            {
                this.lblMensaje.Text = "Email con @ al final";
            }
            else
            {
                this.lblMensaje.Text = "Mail correcto";
            }
            //pacoserranox@gmail.com
            int ultimoPunto = email.LastIndexOf(".");
            string dominio = email.Substring(ultimoPunto + 1);
            if (dominio.Length >= 2 && dominio.Length <= 4)
            {
                this.lblMensaje.Text = "Mail correcto";
            }
            else
            {
                this.lblMensaje.Text = "El dominio debe ser de 2 a 4 caracteres";
            }
        }
    }
}
