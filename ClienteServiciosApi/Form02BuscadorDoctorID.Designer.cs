namespace ClienteServiciosApi
{
    partial class Form02BuscadorDoctorID
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
            txtIdDoctor = new TextBox();
            btnBuscarDoctor = new Button();
            label2 = new Label();
            txtApellido = new TextBox();
            label3 = new Label();
            txtEspecialidad = new TextBox();
            label4 = new Label();
            txtSalario = new TextBox();
            label5 = new Label();
            txtHospital = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 17);
            label1.Name = "label1";
            label1.Size = new Size(97, 30);
            label1.TabIndex = 0;
            label1.Text = "Id doctor";
            // 
            // txtIdDoctor
            // 
            txtIdDoctor.Location = new Point(43, 47);
            txtIdDoctor.Name = "txtIdDoctor";
            txtIdDoctor.Size = new Size(100, 35);
            txtIdDoctor.TabIndex = 1;
            // 
            // btnBuscarDoctor
            // 
            btnBuscarDoctor.Location = new Point(191, 38);
            btnBuscarDoctor.Name = "btnBuscarDoctor";
            btnBuscarDoctor.Size = new Size(215, 44);
            btnBuscarDoctor.TabIndex = 2;
            btnBuscarDoctor.Text = "Buscar doctor";
            btnBuscarDoctor.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 117);
            label2.Name = "label2";
            label2.Size = new Size(89, 30);
            label2.TabIndex = 3;
            label2.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(45, 148);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(310, 35);
            txtApellido.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 201);
            label3.Name = "label3";
            label3.Size = new Size(127, 30);
            label3.TabIndex = 5;
            label3.Text = "Especialidad";
            // 
            // txtEspecialidad
            // 
            txtEspecialidad.Location = new Point(45, 234);
            txtEspecialidad.Name = "txtEspecialidad";
            txtEspecialidad.Size = new Size(310, 35);
            txtEspecialidad.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 286);
            label4.Name = "label4";
            label4.Size = new Size(75, 30);
            label4.TabIndex = 7;
            label4.Text = "Salario";
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(50, 319);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(100, 35);
            txtSalario.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 365);
            label5.Name = "label5";
            label5.Size = new Size(89, 30);
            label5.TabIndex = 9;
            label5.Text = "Hospital";
            // 
            // txtHospital
            // 
            txtHospital.Location = new Point(52, 394);
            txtHospital.Name = "txtHospital";
            txtHospital.Size = new Size(100, 35);
            txtHospital.TabIndex = 10;
            // 
            // Form02BuscadorDoctorID
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 465);
            Controls.Add(txtHospital);
            Controls.Add(label5);
            Controls.Add(txtSalario);
            Controls.Add(label4);
            Controls.Add(txtEspecialidad);
            Controls.Add(label3);
            Controls.Add(txtApellido);
            Controls.Add(label2);
            Controls.Add(btnBuscarDoctor);
            Controls.Add(txtIdDoctor);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form02BuscadorDoctorID";
            Text = "Form02BuscadorDoctorID";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtIdDoctor;
        private Button btnBuscarDoctor;
        private Label label2;
        private TextBox txtApellido;
        private Label label3;
        private TextBox txtEspecialidad;
        private Label label4;
        private TextBox txtSalario;
        private Label label5;
        private TextBox txtHospital;
    }
}