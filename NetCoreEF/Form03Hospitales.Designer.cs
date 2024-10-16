namespace NetCoreEF
{
    partial class Form03Hospitales
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
            btnCargarHospitales = new Button();
            lsvHospitales = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            label1 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            txtDireccion = new TextBox();
            label3 = new Label();
            txtTelefono = new TextBox();
            label4 = new Label();
            txtCamas = new TextBox();
            SuspendLayout();
            // 
            // btnCargarHospitales
            // 
            btnCargarHospitales.Location = new Point(50, 19);
            btnCargarHospitales.Name = "btnCargarHospitales";
            btnCargarHospitales.Size = new Size(188, 50);
            btnCargarHospitales.TabIndex = 0;
            btnCargarHospitales.Text = "Cargar Hospitales";
            btnCargarHospitales.UseVisualStyleBackColor = true;
            btnCargarHospitales.Click += btnCargarHospitales_Click;
            // 
            // lsvHospitales
            // 
            lsvHospitales.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            lsvHospitales.FullRowSelect = true;
            lsvHospitales.Location = new Point(51, 92);
            lsvHospitales.Name = "lsvHospitales";
            lsvHospitales.Size = new Size(637, 385);
            lsvHospitales.TabIndex = 3;
            lsvHospitales.UseCompatibleStateImageBehavior = false;
            lsvHospitales.View = View.Details;
            lsvHospitales.SelectedIndexChanged += lsvHospitales_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nombre";
            columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Dirección";
            columnHeader3.Width = 180;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Teléfono";
            columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Camas";
            columnHeader5.Width = 100;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(749, 42);
            label1.Name = "label1";
            label1.Size = new Size(89, 30);
            label1.TabIndex = 4;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(756, 74);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(244, 35);
            txtNombre.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(758, 123);
            label2.Name = "label2";
            label2.Size = new Size(100, 30);
            label2.TabIndex = 6;
            label2.Text = "Dirección";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(759, 160);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(241, 35);
            txtDireccion.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(759, 214);
            label3.Name = "label3";
            label3.Size = new Size(92, 30);
            label3.TabIndex = 8;
            label3.Text = "Teléfono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(762, 247);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(238, 35);
            txtTelefono.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(763, 295);
            label4.Name = "label4";
            label4.Size = new Size(75, 30);
            label4.TabIndex = 10;
            label4.Text = "Camas";
            // 
            // txtCamas
            // 
            txtCamas.Location = new Point(766, 332);
            txtCamas.Name = "txtCamas";
            txtCamas.Size = new Size(141, 35);
            txtCamas.TabIndex = 11;
            // 
            // Form03Hospitales
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 506);
            Controls.Add(txtCamas);
            Controls.Add(label4);
            Controls.Add(txtTelefono);
            Controls.Add(label3);
            Controls.Add(txtDireccion);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(lsvHospitales);
            Controls.Add(btnCargarHospitales);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form03Hospitales";
            Text = "Form03Hospitales";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCargarHospitales;
        private ListView lsvHospitales;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Label label1;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtDireccion;
        private Label label3;
        private TextBox txtTelefono;
        private Label label4;
        private TextBox txtCamas;
    }
}