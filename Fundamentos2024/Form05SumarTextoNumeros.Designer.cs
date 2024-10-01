namespace Fundamentos2024
{
    partial class Form05SumarTextoNumeros
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
            txtNumeros = new TextBox();
            btnSumar = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 23);
            label1.Name = "label1";
            label1.Size = new Size(199, 30);
            label1.TabIndex = 0;
            label1.Text = "Introduzca números";
            // 
            // txtNumeros
            // 
            txtNumeros.Location = new Point(44, 56);
            txtNumeros.Name = "txtNumeros";
            txtNumeros.Size = new Size(336, 35);
            txtNumeros.TabIndex = 1;
            txtNumeros.Text = "1234";
            // 
            // btnSumar
            // 
            btnSumar.Location = new Point(42, 122);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(338, 59);
            btnSumar.TabIndex = 2;
            btnSumar.Text = "Sumar";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += btnSumar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(45, 208);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(223, 30);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "La suma de 1234 es 10";
            // 
            // Form05SumarTextoNumeros
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 277);
            Controls.Add(lblResultado);
            Controls.Add(btnSumar);
            Controls.Add(txtNumeros);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form05SumarTextoNumeros";
            Text = "Form05SumarTextoNumeros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumeros;
        private Button btnSumar;
        private Label lblResultado;
    }
}