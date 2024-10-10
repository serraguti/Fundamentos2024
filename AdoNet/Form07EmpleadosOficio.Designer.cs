namespace AdoNet
{
    partial class Form07EmpleadosOficio
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
            lstOficios = new ListBox();
            label2 = new Label();
            lstEmpleados = new ListBox();
            label3 = new Label();
            txtIncrementoSalarial = new TextBox();
            btnIncrementarSalarios = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 20);
            label1.Name = "label1";
            label1.Size = new Size(77, 30);
            label1.TabIndex = 0;
            label1.Text = "Oficios";
            // 
            // lstOficios
            // 
            lstOficios.FormattingEnabled = true;
            lstOficios.ItemHeight = 30;
            lstOficios.Location = new Point(25, 53);
            lstOficios.Name = "lstOficios";
            lstOficios.Size = new Size(231, 274);
            lstOficios.TabIndex = 1;
            lstOficios.SelectedIndexChanged += lstOficios_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(310, 20);
            label2.Name = "label2";
            label2.Size = new Size(114, 30);
            label2.TabIndex = 2;
            label2.Text = "Empleados";
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.ItemHeight = 30;
            lstEmpleados.Location = new Point(310, 53);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(228, 334);
            lstEmpleados.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(582, 20);
            label3.Name = "label3";
            label3.Size = new Size(194, 30);
            label3.TabIndex = 4;
            label3.Text = "Incremento salarial:";
            // 
            // txtIncrementoSalarial
            // 
            txtIncrementoSalarial.Location = new Point(586, 53);
            txtIncrementoSalarial.Name = "txtIncrementoSalarial";
            txtIncrementoSalarial.Size = new Size(216, 35);
            txtIncrementoSalarial.TabIndex = 5;
            // 
            // btnIncrementarSalarios
            // 
            btnIncrementarSalarios.Location = new Point(586, 103);
            btnIncrementarSalarios.Name = "btnIncrementarSalarios";
            btnIncrementarSalarios.Size = new Size(216, 79);
            btnIncrementarSalarios.TabIndex = 6;
            btnIncrementarSalarios.Text = "Incrementar salarios";
            btnIncrementarSalarios.UseVisualStyleBackColor = true;
            btnIncrementarSalarios.Click += btnIncrementarSalarios_Click;
            // 
            // Form07EmpleadosOficio
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 421);
            Controls.Add(btnIncrementarSalarios);
            Controls.Add(txtIncrementoSalarial);
            Controls.Add(label3);
            Controls.Add(lstEmpleados);
            Controls.Add(label2);
            Controls.Add(lstOficios);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form07EmpleadosOficio";
            Text = "Form07EmpleadosOficios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstOficios;
        private Label label2;
        private ListBox lstEmpleados;
        private Label label3;
        private TextBox txtIncrementoSalarial;
        private Button btnIncrementarSalarios;
    }
}