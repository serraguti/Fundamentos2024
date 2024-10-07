namespace Fundamentos2024
{
    partial class Form16SerializarSimple
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
            txtNombre = new TextBox();
            label2 = new Label();
            txtRaza = new TextBox();
            label3 = new Label();
            txtAnyos = new TextBox();
            btnGuardarMascota = new Button();
            btinLeerMascota = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 28);
            label1.Name = "label1";
            label1.Size = new Size(89, 30);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(54, 62);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(267, 35);
            txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 116);
            label2.Name = "label2";
            label2.Size = new Size(58, 30);
            label2.TabIndex = 2;
            label2.Text = "Raza";
            // 
            // txtRaza
            // 
            txtRaza.Location = new Point(58, 149);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(263, 35);
            txtRaza.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 202);
            label3.Name = "label3";
            label3.Size = new Size(60, 30);
            label3.TabIndex = 4;
            label3.Text = "Años";
            // 
            // txtAnyos
            // 
            txtAnyos.Location = new Point(60, 236);
            txtAnyos.Name = "txtAnyos";
            txtAnyos.Size = new Size(100, 35);
            txtAnyos.TabIndex = 5;
            // 
            // btnGuardarMascota
            // 
            btnGuardarMascota.Location = new Point(439, 61);
            btnGuardarMascota.Name = "btnGuardarMascota";
            btnGuardarMascota.Size = new Size(212, 72);
            btnGuardarMascota.TabIndex = 6;
            btnGuardarMascota.Text = "Guardar mascota";
            btnGuardarMascota.UseVisualStyleBackColor = true;
            btnGuardarMascota.Click += btnGuardarMascota_Click;
            // 
            // btinLeerMascota
            // 
            btinLeerMascota.Location = new Point(440, 147);
            btinLeerMascota.Name = "btinLeerMascota";
            btinLeerMascota.Size = new Size(211, 70);
            btinLeerMascota.TabIndex = 7;
            btinLeerMascota.Text = "Leer mascota";
            btinLeerMascota.UseVisualStyleBackColor = true;
            // 
            // Form16SerializarSimple
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(758, 311);
            Controls.Add(btinLeerMascota);
            Controls.Add(btnGuardarMascota);
            Controls.Add(txtAnyos);
            Controls.Add(label3);
            Controls.Add(txtRaza);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form16SerializarSimple";
            Text = "Form16SerializarSimple";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtRaza;
        private Label label3;
        private TextBox txtAnyos;
        private Button btnGuardarMascota;
        private Button btinLeerMascota;
    }
}