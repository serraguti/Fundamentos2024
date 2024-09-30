namespace Fundamentos2024
{
    partial class Form01SumarNumeros
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
            txtNumero1 = new TextBox();
            label2 = new Label();
            txtNumero2 = new TextBox();
            btnSumarNumeros = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 49);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(106, 30);
            label1.TabIndex = 0;
            label1.Text = "Número 1";
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(146, 44);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(100, 35);
            txtNumero1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 105);
            label2.Name = "label2";
            label2.Size = new Size(106, 30);
            label2.TabIndex = 2;
            label2.Text = "Número 2";
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(145, 102);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(100, 35);
            txtNumero2.TabIndex = 3;
            // 
            // btnSumarNumeros
            // 
            btnSumarNumeros.Location = new Point(17, 161);
            btnSumarNumeros.Name = "btnSumarNumeros";
            btnSumarNumeros.Size = new Size(228, 66);
            btnSumarNumeros.TabIndex = 4;
            btnSumarNumeros.Text = "Sumar números";
            btnSumarNumeros.UseVisualStyleBackColor = true;
            btnSumarNumeros.Click += btnSumarNumeros_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(55, 250);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(68, 30);
            lblResultado.TabIndex = 5;
            lblResultado.Text = "label3";
            // 
            // Form01SumarNumeros
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 327);
            Controls.Add(lblResultado);
            Controls.Add(btnSumarNumeros);
            Controls.Add(txtNumero2);
            Controls.Add(label2);
            Controls.Add(txtNumero1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form01SumarNumeros";
            Text = "Form01SumarNumeros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumero1;
        private Label label2;
        private TextBox txtNumero2;
        private Button btnSumarNumeros;
        private Label lblResultado;
    }
}