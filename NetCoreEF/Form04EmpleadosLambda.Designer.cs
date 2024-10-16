namespace NetCoreEF
{
    partial class Form04EmpleadosLambda
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
            cmbOficios = new ComboBox();
            label2 = new Label();
            txtPersonas = new TextBox();
            label3 = new Label();
            txtMaximoSalario = new TextBox();
            label4 = new Label();
            txtMinimoSalario = new TextBox();
            label5 = new Label();
            lstEmpleados = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 22);
            label1.Name = "label1";
            label1.Size = new Size(77, 30);
            label1.TabIndex = 0;
            label1.Text = "Oficios";
            // 
            // cmbOficios
            // 
            cmbOficios.FormattingEnabled = true;
            cmbOficios.Location = new Point(31, 58);
            cmbOficios.Name = "cmbOficios";
            cmbOficios.Size = new Size(212, 38);
            cmbOficios.TabIndex = 1;
            cmbOficios.SelectedIndexChanged += cmbOficios_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 156);
            label2.Name = "label2";
            label2.Size = new Size(95, 30);
            label2.TabIndex = 2;
            label2.Text = "Personas";
            // 
            // txtPersonas
            // 
            txtPersonas.Location = new Point(38, 188);
            txtPersonas.Name = "txtPersonas";
            txtPersonas.Size = new Size(205, 35);
            txtPersonas.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 236);
            label3.Name = "label3";
            label3.Size = new Size(154, 30);
            label3.TabIndex = 4;
            label3.Text = "Máximo salario";
            // 
            // txtMaximoSalario
            // 
            txtMaximoSalario.Location = new Point(41, 267);
            txtMaximoSalario.Name = "txtMaximoSalario";
            txtMaximoSalario.Size = new Size(202, 35);
            txtMaximoSalario.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 320);
            label4.Name = "label4";
            label4.Size = new Size(152, 30);
            label4.TabIndex = 6;
            label4.Text = "Mínimo Salario";
            // 
            // txtMinimoSalario
            // 
            txtMinimoSalario.Location = new Point(39, 352);
            txtMinimoSalario.Name = "txtMinimoSalario";
            txtMinimoSalario.Size = new Size(204, 35);
            txtMinimoSalario.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(332, 17);
            label5.Name = "label5";
            label5.Size = new Size(114, 30);
            label5.TabIndex = 8;
            label5.Text = "Empleados";
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.ItemHeight = 30;
            lstEmpleados.Location = new Point(338, 49);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(348, 364);
            lstEmpleados.TabIndex = 9;
            // 
            // Form04EmpleadosLambda
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 464);
            Controls.Add(lstEmpleados);
            Controls.Add(label5);
            Controls.Add(txtMinimoSalario);
            Controls.Add(label4);
            Controls.Add(txtMaximoSalario);
            Controls.Add(label3);
            Controls.Add(txtPersonas);
            Controls.Add(label2);
            Controls.Add(cmbOficios);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form04EmpleadosLambda";
            Text = "Form04EmpleadosLambda";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbOficios;
        private Label label2;
        private TextBox txtPersonas;
        private Label label3;
        private TextBox txtMaximoSalario;
        private Label label4;
        private TextBox txtMinimoSalario;
        private Label label5;
        private ListBox lstEmpleados;
    }
}