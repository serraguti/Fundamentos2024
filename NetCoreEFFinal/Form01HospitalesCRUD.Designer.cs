namespace NetCoreEFFinal
{
    partial class Form01HospitalesCRUD
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
            lsvHospitales = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            label2 = new Label();
            txtIdHospital = new TextBox();
            label3 = new Label();
            txtNombre = new TextBox();
            label4 = new Label();
            txtDireccion = new TextBox();
            label5 = new Label();
            txtTelefono = new TextBox();
            label6 = new Label();
            txtCamas = new TextBox();
            btnInsertar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 18);
            label1.Name = "label1";
            label1.Size = new Size(109, 30);
            label1.TabIndex = 0;
            label1.Text = "Hospitales";
            // 
            // lsvHospitales
            // 
            lsvHospitales.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            lsvHospitales.FullRowSelect = true;
            lsvHospitales.Location = new Point(26, 53);
            lsvHospitales.Name = "lsvHospitales";
            lsvHospitales.Size = new Size(600, 334);
            lsvHospitales.TabIndex = 1;
            lsvHospitales.UseCompatibleStateImageBehavior = false;
            lsvHospitales.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nombre";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Dirección";
            columnHeader3.Width = 180;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Teléfono";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Camas";
            columnHeader5.Width = 100;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(648, 22);
            label2.Name = "label2";
            label2.Size = new Size(110, 30);
            label2.TabIndex = 2;
            label2.Text = "Id hospital";
            // 
            // txtIdHospital
            // 
            txtIdHospital.Location = new Point(651, 52);
            txtIdHospital.Name = "txtIdHospital";
            txtIdHospital.Size = new Size(100, 35);
            txtIdHospital.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(652, 96);
            label3.Name = "label3";
            label3.Size = new Size(89, 30);
            label3.TabIndex = 4;
            label3.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(654, 125);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(264, 35);
            txtNombre.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(654, 172);
            label4.Name = "label4";
            label4.Size = new Size(100, 30);
            label4.TabIndex = 6;
            label4.Text = "Dirección";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(659, 205);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(259, 35);
            txtDireccion.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(657, 255);
            label5.Name = "label5";
            label5.Size = new Size(92, 30);
            label5.TabIndex = 8;
            label5.Text = "Teléfono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(663, 286);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(255, 35);
            txtTelefono.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(664, 333);
            label6.Name = "label6";
            label6.Size = new Size(75, 30);
            label6.TabIndex = 10;
            label6.Text = "Camas";
            // 
            // txtCamas
            // 
            txtCamas.Location = new Point(665, 361);
            txtCamas.Name = "txtCamas";
            txtCamas.Size = new Size(100, 35);
            txtCamas.TabIndex = 11;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(666, 409);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(252, 49);
            btnInsertar.TabIndex = 12;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(664, 469);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(252, 51);
            btnModificar.TabIndex = 13;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(29, 412);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(225, 46);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // Form01HospitalesCRUD
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 538);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnInsertar);
            Controls.Add(txtCamas);
            Controls.Add(label6);
            Controls.Add(txtTelefono);
            Controls.Add(label5);
            Controls.Add(txtDireccion);
            Controls.Add(label4);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(txtIdHospital);
            Controls.Add(label2);
            Controls.Add(lsvHospitales);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form01HospitalesCRUD";
            Text = "Form01HospitalesCRUD";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView lsvHospitales;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Label label2;
        private TextBox txtIdHospital;
        private Label label3;
        private TextBox txtNombre;
        private Label label4;
        private TextBox txtDireccion;
        private Label label5;
        private TextBox txtTelefono;
        private Label label6;
        private TextBox txtCamas;
        private Button btnInsertar;
        private Button btnModificar;
        private Button btnEliminar;
    }
}