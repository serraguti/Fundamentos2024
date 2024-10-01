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
    public partial class Form03DateTime : Form
    {
        public Form03DateTime()
        {
            InitializeComponent();
            //QUIERO PONER LA FECHA ACTUAL EN LA CAJA
            DateTime fecha = DateTime.Now;
            this.txtFechaActual.Text = fecha.ToString();
        }

        private void chkCambiarFormato_CheckedChanged(object sender, EventArgs e)
        {
            //CAPTURAMOS LA FECHA DE LA CAJA DE TEXTO
            DateTime fecha = DateTime.Parse(this.txtFechaActual.Text);
            //PREGUNTAMOS POR EL ESTADO DEL CHECKBOX
            if (this.chkCambiarFormato.Checked == true)
            {
                this.txtFechaActual.Text = fecha.ToLongDateString();
            }
            else
            {
                this.txtFechaActual.Text = fecha.ToShortDateString();
            }
        }

        private void btnIncrementar_Click(object sender, EventArgs e)
        {
            //CAPTURAMOS LA FECHA ACTUAL DE LA CAJA
            DateTime fecha = DateTime.Parse(this.txtFechaActual.Text);
            int incremento = int.Parse(this.txtIncremento.Text);
            if (this.rdbDias.Checked == true)
            {
                fecha = fecha.AddDays(incremento);
            }else if (this.rdbAnyos.Checked == true)
            {
                fecha = fecha.AddYears(incremento);
            }
            else
            {
                fecha = fecha.AddMonths(incremento);
            }
            this.txtNuevaFecha.Text = fecha.ToString();
        }
    }
}
