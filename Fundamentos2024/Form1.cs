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
            this.txtNombre.Text = "Hola mundo";
            this.txtNombre.Location = new Point(40, 50);
            this.txtNombre.Text = "Soy un texto";
            this.txtNombre.TextAlign = HorizontalAlignment.Center;

            ////UN INT ES MAYOR QUE UN SHORT
            //short pequeño = 888;
            //int grande = pequeño;

            //CONVERSION DE STRING A PRIMITIVO
            string textoNumero = "12345";
            int numeroEntero = int.Parse(textoNumero);
            double numeroDecimal = double.Parse(textoNumero);

            //CONVERTIR CUALQUIER OBJETO A STRING
            string datoCualquiera = numeroEntero.ToString();
            datoCualquiera = numeroDecimal.ToString();
            datoCualquiera = this.txtNombre.ToString();

            //CONVERTIR ENTRE PRIMITIVOS
            int mayor = 888;
            short pequeño = (short) mayor;

        }
    }
}
