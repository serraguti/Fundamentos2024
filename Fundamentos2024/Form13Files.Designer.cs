namespace Fundamentos2024
{
    partial class Form13Files
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
            txtContenido = new TextBox();
            btnLeerFichero = new Button();
            btnGuardarFichero = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 22);
            label1.Name = "label1";
            label1.Size = new Size(179, 30);
            label1.TabIndex = 0;
            label1.Text = "Contenido fichero";
            // 
            // txtContenido
            // 
            txtContenido.Location = new Point(33, 58);
            txtContenido.Multiline = true;
            txtContenido.Name = "txtContenido";
            txtContenido.Size = new Size(468, 369);
            txtContenido.TabIndex = 1;
            // 
            // btnLeerFichero
            // 
            btnLeerFichero.Location = new Point(562, 73);
            btnLeerFichero.Name = "btnLeerFichero";
            btnLeerFichero.Size = new Size(212, 65);
            btnLeerFichero.TabIndex = 2;
            btnLeerFichero.Text = "Leer fichero";
            btnLeerFichero.UseVisualStyleBackColor = true;
            btnLeerFichero.Click += btnLeerFichero_Click;
            // 
            // btnGuardarFichero
            // 
            btnGuardarFichero.Location = new Point(564, 169);
            btnGuardarFichero.Name = "btnGuardarFichero";
            btnGuardarFichero.Size = new Size(210, 61);
            btnGuardarFichero.TabIndex = 3;
            btnGuardarFichero.Text = "Guardar fichero";
            btnGuardarFichero.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(593, 288);
            label2.Name = "label2";
            label2.Size = new Size(68, 30);
            label2.TabIndex = 4;
            label2.Text = "label2";
            // 
            // Form13Files
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 476);
            Controls.Add(label2);
            Controls.Add(btnGuardarFichero);
            Controls.Add(btnLeerFichero);
            Controls.Add(txtContenido);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form13Files";
            Text = "Form13Files";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtContenido;
        private Button btnLeerFichero;
        private Button btnGuardarFichero;
        private Label label2;
    }
}