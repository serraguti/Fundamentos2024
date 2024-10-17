namespace NetCoreEF
{
    partial class Form06DepartamentosCRUD
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
            lsvDepartamentos = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            label2 = new Label();
            txtIdDepartamento = new TextBox();
            label3 = new Label();
            txtNombre = new TextBox();
            label4 = new Label();
            txtLocalidad = new TextBox();
            btnInsertar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 21);
            label1.Name = "label1";
            label1.Size = new Size(156, 30);
            label1.TabIndex = 0;
            label1.Text = "Departamentos";
            // 
            // lsvDepartamentos
            // 
            lsvDepartamentos.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lsvDepartamentos.FullRowSelect = true;
            lsvDepartamentos.GridLines = true;
            lsvDepartamentos.Location = new Point(28, 54);
            lsvDepartamentos.Name = "lsvDepartamentos";
            lsvDepartamentos.Size = new Size(535, 274);
            lsvDepartamentos.TabIndex = 1;
            lsvDepartamentos.UseCompatibleStateImageBehavior = false;
            lsvDepartamentos.View = View.Details;
            lsvDepartamentos.SelectedIndexChanged += lsvDepartamentos_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "NOMBRE";
            columnHeader2.Width = 180;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "LOCALIDAD";
            columnHeader3.Width = 180;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(613, 21);
            label2.Name = "label2";
            label2.Size = new Size(168, 30);
            label2.TabIndex = 2;
            label2.Text = "Id departamento";
            // 
            // txtIdDepartamento
            // 
            txtIdDepartamento.Location = new Point(618, 59);
            txtIdDepartamento.Name = "txtIdDepartamento";
            txtIdDepartamento.Size = new Size(164, 35);
            txtIdDepartamento.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(620, 110);
            label3.Name = "label3";
            label3.Size = new Size(89, 30);
            label3.TabIndex = 4;
            label3.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(621, 143);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(290, 35);
            txtNombre.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(621, 190);
            label4.Name = "label4";
            label4.Size = new Size(101, 30);
            label4.TabIndex = 6;
            label4.Text = "Localidad";
            // 
            // txtLocalidad
            // 
            txtLocalidad.Location = new Point(623, 222);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(288, 35);
            txtLocalidad.TabIndex = 7;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(623, 282);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(288, 55);
            btnInsertar.TabIndex = 8;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(623, 357);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(286, 54);
            btnModificar.TabIndex = 9;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.ForeColor = SystemColors.ButtonHighlight;
            btnEliminar.Location = new Point(28, 355);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(277, 56);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // Form06DepartamentosCRUD
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 457);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnInsertar);
            Controls.Add(txtLocalidad);
            Controls.Add(label4);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(txtIdDepartamento);
            Controls.Add(label2);
            Controls.Add(lsvDepartamentos);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form06DepartamentosCRUD";
            Text = "Form06DepartamentosCRUD";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView lsvDepartamentos;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Label label2;
        private TextBox txtIdDepartamento;
        private Label label3;
        private TextBox txtNombre;
        private Label label4;
        private TextBox txtLocalidad;
        private Button btnInsertar;
        private Button btnModificar;
        private Button btnEliminar;
    }
}