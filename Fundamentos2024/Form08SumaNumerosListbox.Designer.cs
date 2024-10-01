namespace Fundamentos2024
{
    partial class Form08SumaNumerosListbox
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
            lstNumeros = new ListBox();
            label2 = new Label();
            txtNumero = new TextBox();
            btnAgregarNumero = new Button();
            btnSumarNumeros = new Button();
            lblSuma = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 25);
            label1.Name = "label1";
            label1.Size = new Size(98, 30);
            label1.TabIndex = 0;
            label1.Text = "Números";
            // 
            // lstNumeros
            // 
            lstNumeros.FormattingEnabled = true;
            lstNumeros.ItemHeight = 30;
            lstNumeros.Location = new Point(41, 65);
            lstNumeros.Name = "lstNumeros";
            lstNumeros.Size = new Size(242, 304);
            lstNumeros.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(369, 24);
            label2.Name = "label2";
            label2.Size = new Size(220, 30);
            label2.TabIndex = 2;
            label2.Text = "Introduzca un número";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(420, 57);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 35);
            txtNumero.TabIndex = 3;
            txtNumero.TextAlign = HorizontalAlignment.Center;
            // 
            // btnAgregarNumero
            // 
            btnAgregarNumero.Location = new Point(378, 104);
            btnAgregarNumero.Name = "btnAgregarNumero";
            btnAgregarNumero.Size = new Size(211, 51);
            btnAgregarNumero.TabIndex = 4;
            btnAgregarNumero.Text = "Agregar número";
            btnAgregarNumero.UseVisualStyleBackColor = true;
            // 
            // btnSumarNumeros
            // 
            btnSumarNumeros.Location = new Point(379, 175);
            btnSumarNumeros.Name = "btnSumarNumeros";
            btnSumarNumeros.Size = new Size(210, 92);
            btnSumarNumeros.TabIndex = 5;
            btnSumarNumeros.Text = "Sumar números colección";
            btnSumarNumeros.UseVisualStyleBackColor = true;
            // 
            // lblSuma
            // 
            lblSuma.AutoSize = true;
            lblSuma.ForeColor = Color.Blue;
            lblSuma.Location = new Point(380, 302);
            lblSuma.Name = "lblSuma";
            lblSuma.Size = new Size(87, 30);
            lblSuma.TabIndex = 6;
            lblSuma.Text = "lblSuma";
            // 
            // Form08SumaNumerosListbox
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 400);
            Controls.Add(lblSuma);
            Controls.Add(btnSumarNumeros);
            Controls.Add(btnAgregarNumero);
            Controls.Add(txtNumero);
            Controls.Add(label2);
            Controls.Add(lstNumeros);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form08SumaNumerosListbox";
            Text = "Form08SumaNumerosListbox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstNumeros;
        private Label label2;
        private TextBox txtNumero;
        private Button btnAgregarNumero;
        private Button btnSumarNumeros;
        private Label lblSuma;
    }
}