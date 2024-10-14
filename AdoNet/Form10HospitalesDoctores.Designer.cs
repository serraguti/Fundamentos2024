namespace AdoNet
{
    partial class Form10HospitalesDoctores
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
            lsvDoctor = new ListView();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            label3 = new Label();
            txtIncremento = new TextBox();
            btnIncrementarSalarios = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 11);
            label1.Name = "label1";
            label1.Size = new Size(109, 30);
            label1.TabIndex = 0;
            label1.Text = "Hospitales";
            // 
            // lsvHospitales
            // 
            lsvHospitales.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            lsvHospitales.FullRowSelect = true;
            lsvHospitales.Location = new Point(23, 47);
            lsvHospitales.Name = "lsvHospitales";
            lsvHospitales.Size = new Size(724, 248);
            lsvHospitales.TabIndex = 1;
            lsvHospitales.UseCompatibleStateImageBehavior = false;
            lsvHospitales.View = View.Details;
            lsvHospitales.SelectedIndexChanged += lsvHospitales_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID HOSPITAL";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "NOMBRE";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "DIRECCION";
            columnHeader3.Width = 160;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 309);
            label2.Name = "label2";
            label2.Size = new Size(96, 30);
            label2.TabIndex = 2;
            label2.Text = "Doctores";
            // 
            // lsvDoctor
            // 
            lsvDoctor.Columns.AddRange(new ColumnHeader[] { columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10 });
            lsvDoctor.Location = new Point(23, 342);
            lsvDoctor.Name = "lsvDoctor";
            lsvDoctor.Size = new Size(724, 234);
            lsvDoctor.TabIndex = 3;
            lsvDoctor.UseCompatibleStateImageBehavior = false;
            lsvDoctor.View = View.Details;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "ID";
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "APELLIDO";
            columnHeader7.Width = 150;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "ESPECIALIDAD";
            columnHeader8.TextAlign = HorizontalAlignment.Center;
            columnHeader8.Width = 160;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "SALARIO";
            columnHeader9.Width = 150;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "HOSPITAL";
            columnHeader10.Width = 150;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(781, 18);
            label3.Name = "label3";
            label3.Size = new Size(189, 30);
            label3.TabIndex = 4;
            label3.Text = "Incremento salarial";
            // 
            // txtIncremento
            // 
            txtIncremento.Location = new Point(786, 49);
            txtIncremento.Name = "txtIncremento";
            txtIncremento.Size = new Size(262, 35);
            txtIncremento.TabIndex = 5;
            // 
            // btnIncrementarSalarios
            // 
            btnIncrementarSalarios.Location = new Point(786, 92);
            btnIncrementarSalarios.Name = "btnIncrementarSalarios";
            btnIncrementarSalarios.Size = new Size(262, 53);
            btnIncrementarSalarios.TabIndex = 6;
            btnIncrementarSalarios.Text = "Incrementar salarios";
            btnIncrementarSalarios.UseVisualStyleBackColor = true;
            btnIncrementarSalarios.Click += btnIncrementarSalarios_Click;
            // 
            // Form10HospitalesDoctores
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1096, 629);
            Controls.Add(btnIncrementarSalarios);
            Controls.Add(txtIncremento);
            Controls.Add(label3);
            Controls.Add(lsvDoctor);
            Controls.Add(label2);
            Controls.Add(lsvHospitales);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form10HospitalesDoctores";
            Text = "Form10HospitalesDoctores";
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
        private ListView lsvDoctor;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private Label label3;
        private TextBox txtIncremento;
        private Button btnIncrementarSalarios;
    }
}