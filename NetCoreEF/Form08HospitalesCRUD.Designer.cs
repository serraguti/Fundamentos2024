namespace NetCoreEF
{
    partial class Form08HospitalesCRUD
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
            btnEliminar = new Button();
            btnInsertar = new Button();
            btnModificar = new Button();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 15);
            label1.Name = "label1";
            label1.Size = new Size(109, 30);
            label1.TabIndex = 0;
            label1.Text = "Hospitales";
            // 
            // lsvHospitales
            // 
            lsvHospitales.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            lsvHospitales.FullRowSelect = true;
            lsvHospitales.GridLines = true;
            lsvHospitales.HideSelection = true;
            lsvHospitales.Location = new Point(34, 50);
            lsvHospitales.Name = "lsvHospitales";
            lsvHospitales.Size = new Size(732, 345);
            lsvHospitales.TabIndex = 1;
            lsvHospitales.UseCompatibleStateImageBehavior = false;
            lsvHospitales.View = View.Details;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(810, 17);
            label2.Name = "label2";
            label2.Size = new Size(113, 30);
            label2.TabIndex = 2;
            label2.Text = "Id Hospital";
            // 
            // txtIdHospital
            // 
            txtIdHospital.Location = new Point(815, 48);
            txtIdHospital.Name = "txtIdHospital";
            txtIdHospital.Size = new Size(153, 35);
            txtIdHospital.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(816, 94);
            label3.Name = "label3";
            label3.Size = new Size(89, 30);
            label3.TabIndex = 4;
            label3.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(820, 124);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(260, 35);
            txtNombre.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(817, 175);
            label4.Name = "label4";
            label4.Size = new Size(100, 30);
            label4.TabIndex = 6;
            label4.Text = "Dirección";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(822, 207);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(258, 35);
            txtDireccion.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(824, 257);
            label5.Name = "label5";
            label5.Size = new Size(92, 30);
            label5.TabIndex = 8;
            label5.Text = "Teléfono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(823, 287);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(257, 35);
            txtTelefono.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(821, 338);
            label6.Name = "label6";
            label6.Size = new Size(75, 30);
            label6.TabIndex = 10;
            label6.Text = "Camas";
            // 
            // txtCamas
            // 
            txtCamas.Location = new Point(826, 366);
            txtCamas.Name = "txtCamas";
            txtCamas.Size = new Size(100, 35);
            txtCamas.TabIndex = 11;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(34, 413);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(231, 53);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(826, 418);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(254, 48);
            btnInsertar.TabIndex = 13;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(828, 478);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(252, 47);
            btnModificar.TabIndex = 14;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "NOMBRE";
            columnHeader2.Width = 160;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "DIRECCION";
            columnHeader3.Width = 180;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "TELEFONO";
            columnHeader4.Width = 160;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "CAMAS";
            columnHeader5.Width = 100;
            // 
            // Form08HospitalesCRUD
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 551);
            Controls.Add(btnModificar);
            Controls.Add(btnInsertar);
            Controls.Add(btnEliminar);
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
            Name = "Form08HospitalesCRUD";
            Text = "Form08HospitalesCRUD";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView lsvHospitales;
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
        private Button btnEliminar;
        private Button btnInsertar;
        private Button btnModificar;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
    }
}