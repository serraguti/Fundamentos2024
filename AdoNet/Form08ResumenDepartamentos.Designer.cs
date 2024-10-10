namespace AdoNet
{
    partial class Form08ResumenDepartamentos
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
            txtPersonas = new TextBox();
            label3 = new Label();
            txtMaximoSalario = new TextBox();
            label4 = new Label();
            txtMinimoSalario = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 20);
            label1.Name = "label1";
            label1.Size = new Size(156, 30);
            label1.TabIndex = 0;
            label1.Text = "Departamentos";
            // 
            // lstDepartamentos
            // 
            lstDepartamentos.FormattingEnabled = true;
            lstDepartamentos.ItemHeight = 30;
            lstDepartamentos.Location = new Point(22, 52);
            lstDepartamentos.Name = "lstDepartamentos";
            lstDepartamentos.Size = new Size(294, 334);
            lstDepartamentos.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(372, 23);
            label2.Name = "label2";
            label2.Size = new Size(95, 30);
            label2.TabIndex = 2;
            label2.Text = "Personas";
            // 
            // txtPersonas
            // 
            txtPersonas.Location = new Point(379, 55);
            txtPersonas.Name = "txtPersonas";
            txtPersonas.Size = new Size(281, 35);
            txtPersonas.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(380, 104);
            label3.Name = "label3";
            label3.Size = new Size(154, 30);
            label3.TabIndex = 4;
            label3.Text = "Máximo salario";
            // 
            // txtMaximoSalario
            // 
            txtMaximoSalario.Location = new Point(385, 136);
            txtMaximoSalario.Name = "txtMaximoSalario";
            txtMaximoSalario.Size = new Size(275, 35);
            txtMaximoSalario.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(384, 187);
            label4.Name = "label4";
            label4.Size = new Size(150, 30);
            label4.TabIndex = 6;
            label4.Text = "Mínimo salario";
            // 
            // txtMinimoSalario
            // 
            txtMinimoSalario.Location = new Point(384, 221);
            txtMinimoSalario.Name = "txtMinimoSalario";
            txtMinimoSalario.Size = new Size(276, 35);
            txtMinimoSalario.TabIndex = 7;
            // 
            // Form08ResumenDepartamentos
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(735, 454);
            Controls.Add(txtMinimoSalario);
            Controls.Add(label4);
            Controls.Add(txtMaximoSalario);
            Controls.Add(label3);
            Controls.Add(txtPersonas);
            Controls.Add(label2);
            Controls.Add(lstDepartamentos);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form08ResumenDepartamentos";
            Text = "Form08ResumenDepartamentos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstDepartamentos;
        private Label label2;
        private TextBox txtPersonas;
        private Label label3;
        private TextBox txtMaximoSalario;
        private Label label4;
        private TextBox txtMinimoSalario;
    }
}