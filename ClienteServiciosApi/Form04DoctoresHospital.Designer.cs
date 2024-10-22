namespace ClienteServiciosApi
{
    partial class Form04DoctoresHospital
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
            txtHospital = new TextBox();
            btnBuscarDoctores = new Button();
            label2 = new Label();
            lstDoctores = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 17);
            label1.Name = "label1";
            label1.Size = new Size(118, 30);
            label1.TabIndex = 0;
            label1.Text = "Id Hospital:";
            // 
            // txtHospital
            // 
            txtHospital.Location = new Point(45, 50);
            txtHospital.Name = "txtHospital";
            txtHospital.Size = new Size(230, 35);
            txtHospital.TabIndex = 1;
            // 
            // btnBuscarDoctores
            // 
            btnBuscarDoctores.Location = new Point(43, 100);
            btnBuscarDoctores.Name = "btnBuscarDoctores";
            btnBuscarDoctores.Size = new Size(232, 47);
            btnBuscarDoctores.TabIndex = 2;
            btnBuscarDoctores.Text = "Buscar doctores";
            btnBuscarDoctores.UseVisualStyleBackColor = true;
            btnBuscarDoctores.Click += btnBuscarDoctores_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(339, 15);
            label2.Name = "label2";
            label2.Size = new Size(98, 30);
            label2.TabIndex = 3;
            label2.Text = "Apellidos";
            // 
            // lstDoctores
            // 
            lstDoctores.FormattingEnabled = true;
            lstDoctores.ItemHeight = 30;
            lstDoctores.Location = new Point(346, 46);
            lstDoctores.Name = "lstDoctores";
            lstDoctores.Size = new Size(381, 394);
            lstDoctores.TabIndex = 4;
            // 
            // Form04DoctoresHospital
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 526);
            Controls.Add(lstDoctores);
            Controls.Add(label2);
            Controls.Add(btnBuscarDoctores);
            Controls.Add(txtHospital);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form04DoctoresHospital";
            Text = "Form04DoctoresHospital";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtHospital;
        private Button btnBuscarDoctores;
        private Label label2;
        private ListBox lstDoctores;
    }
}