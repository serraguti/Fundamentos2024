namespace Fundamentos2024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPulsar_Click(object sender, EventArgs e)
        {
            //AQUI ESCRIBIMOS QUE DESEAMOS HACER...
            //SOLAMENTE ESCRIBIREMOS AQUI POR AHORA
            //TODO EN UNA CLASE PARA REFERIRSE A LOS OBJETOS UTILIZAMOS
            //LA PALABRA this (Clase en la que estamos programando (FORM))
            this.txtNombre.Location = new Point(40, 50);
            this.txtNombre.Text = "Soy un texto";
            this.txtNombre.TextAlign = HorizontalAlignment.Center;

        }
    }
}
