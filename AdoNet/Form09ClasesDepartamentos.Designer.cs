namespace AdoNet
{
    partial class Form09ClasesDepartamentos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lstDepartamentos = new ListBox();
            label2 = new Label();
            txtNumero = new TextBox();
            label3 = new Label();
            txtNombre = new TextBox();
            label4 = new Label();
            txtLocalidad = new TextBox();
            btnInsertar = new Button();
            brnModificar = new Button();
            btnEliminar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 22);
            label1.Name = "label1";
            label1.Size = new Size(156, 30);
            label1.TabIndex = 0;
            label1.Text = "Departamentos";
            // 
            // lstDepartamentos
            // 
            lstDepartamentos.FormattingEnabled = true;
            lstDepartamentos.ItemHeight = 30;
            lstDepartamentos.Location = new Point(33, 54);
            lstDepartamentos.Name = "lstDepartamentos";
            lstDepartamentos.Size = new Size(401, 424);
            lstDepartamentos.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(503, 20);
            label2.Name = "label2";
            label2.Size = new Size(89, 30);
            label2.TabIndex = 2;
            label2.Text = "Número";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(509, 51);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 35);
            txtNumero.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(511, 101);
            label3.Name = "label3";
            label3.Size = new Size(89, 30);
            label3.TabIndex = 4;
            label3.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(512, 137);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(259, 35);
            txtNombre.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(512, 190);
            label4.Name = "label4";
            label4.Size = new Size(101, 30);
            label4.TabIndex = 6;
            label4.Text = "Localidad";
            // 
            // txtLocalidad
            // 
            txtLocalidad.Location = new Point(517, 230);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(254, 35);
            txtLocalidad.TabIndex = 7;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(517, 294);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(254, 58);
            btnInsertar.TabIndex = 8;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // brnModificar
            // 
            brnModificar.Location = new Point(518, 369);
            brnModificar.Name = "brnModificar";
            brnModificar.Size = new Size(253, 55);
            brnModificar.TabIndex = 9;
            brnModificar.Text = "Modificar";
            brnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(516, 442);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(254, 56);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // Form09ClasesDepartamentos
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 514);
            Controls.Add(btnEliminar);
            Controls.Add(brnModificar);
            Controls.Add(btnInsertar);
            Controls.Add(txtLocalidad);
            Controls.Add(label4);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(txtNumero);
            Controls.Add(label2);
            Controls.Add(lstDepartamentos);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form09ClasesDepartamentos";
            Text = "Form09ClasesDepartamentos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstDepartamentos;
        private Label label2;
        private TextBox txtNumero;
        private Label label3;
        private TextBox txtNombre;
        private Label label4;
        private TextBox txtLocalidad;
        private Button btnInsertar;
        private Button brnModificar;
        private Button btnEliminar;
    }
}