namespace Fundamentos2024
{
    partial class Form04Char
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
            txtLetras = new TextBox();
            txtNumeros = new TextBox();
            label2 = new Label();
            txtSimbolos = new TextBox();
            label3 = new Label();
            txtPuntuacion = new TextBox();
            label4 = new Label();
            btnIniciarAscii = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 25);
            label1.Name = "label1";
            label1.Size = new Size(68, 30);
            label1.TabIndex = 0;
            label1.Text = "Letras";
            // 
            // txtLetras
            // 
            txtLetras.Location = new Point(38, 66);
            txtLetras.Multiline = true;
            txtLetras.Name = "txtLetras";
            txtLetras.Size = new Size(310, 114);
            txtLetras.TabIndex = 1;
            // 
            // txtNumeros
            // 
            txtNumeros.Location = new Point(465, 66);
            txtNumeros.Multiline = true;
            txtNumeros.Name = "txtNumeros";
            txtNumeros.Size = new Size(310, 114);
            txtNumeros.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(462, 25);
            label2.Name = "label2";
            label2.Size = new Size(98, 30);
            label2.TabIndex = 2;
            label2.Text = "Números";
            // 
            // txtSimbolos
            // 
            txtSimbolos.Location = new Point(38, 238);
            txtSimbolos.Multiline = true;
            txtSimbolos.Name = "txtSimbolos";
            txtSimbolos.Size = new Size(310, 114);
            txtSimbolos.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 197);
            label3.Name = "label3";
            label3.Size = new Size(97, 30);
            label3.TabIndex = 4;
            label3.Text = "Símbolos";
            // 
            // txtPuntuacion
            // 
            txtPuntuacion.Location = new Point(465, 238);
            txtPuntuacion.Multiline = true;
            txtPuntuacion.Name = "txtPuntuacion";
            txtPuntuacion.Size = new Size(310, 114);
            txtPuntuacion.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(462, 197);
            label4.Name = "label4";
            label4.Size = new Size(118, 30);
            label4.TabIndex = 6;
            label4.Text = "Puntuación";
            // 
            // btnIniciarAscii
            // 
            btnIniciarAscii.Location = new Point(325, 378);
            btnIniciarAscii.Name = "btnIniciarAscii";
            btnIniciarAscii.Size = new Size(175, 52);
            btnIniciarAscii.TabIndex = 8;
            btnIniciarAscii.Text = "Iniciar ASCII";
            btnIniciarAscii.UseVisualStyleBackColor = true;
            // 
            // Form04Char
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 451);
            Controls.Add(btnIniciarAscii);
            Controls.Add(txtPuntuacion);
            Controls.Add(label4);
            Controls.Add(txtSimbolos);
            Controls.Add(label3);
            Controls.Add(txtNumeros);
            Controls.Add(label2);
            Controls.Add(txtLetras);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form04Char";
            Text = "Form04Char";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtLetras;
        private TextBox txtNumeros;
        private Label label2;
        private TextBox txtSimbolos;
        private Label label3;
        private TextBox txtPuntuacion;
        private Label label4;
        private Button btnIniciarAscii;
    }
}