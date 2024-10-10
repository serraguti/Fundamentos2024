namespace AdoNet
{
    partial class Form06DoctoresEspecialidad
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
            lstEspecialidades = new ListBox();
            label2 = new Label();
            lstDoctores = new ListBox();
            txtIncremento = new TextBox();
            label3 = new Label();
            btnIncrementarSalario = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 20);
            label1.Name = "label1";
            label1.Size = new Size(147, 30);
            label1.TabIndex = 0;
            label1.Text = "Especialidades";
            // 
            // lstEspecialidades
            // 
            lstEspecialidades.FormattingEnabled = true;
            lstEspecialidades.ItemHeight = 30;
            lstEspecialidades.Location = new Point(28, 53);
            lstEspecialidades.Name = "lstEspecialidades";
            lstEspecialidades.Size = new Size(261, 244);
            lstEspecialidades.TabIndex = 1;
            lstEspecialidades.SelectedIndexChanged += lstEspecialidades_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(341, 25);
            label2.Name = "label2";
            label2.Size = new Size(96, 30);
            label2.TabIndex = 2;
            label2.Text = "Doctores";
            // 
            // lstDoctores
            // 
            lstDoctores.FormattingEnabled = true;
            lstDoctores.ItemHeight = 30;
            lstDoctores.Location = new Point(347, 58);
            lstDoctores.Name = "lstDoctores";
            lstDoctores.Size = new Size(249, 334);
            lstDoctores.TabIndex = 3;
            // 
            // txtIncremento
            // 
            txtIncremento.Location = new Point(636, 90);
            txtIncremento.Name = "txtIncremento";
            txtIncremento.Size = new Size(189, 35);
            txtIncremento.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(637, 55);
            label3.Name = "label3";
            label3.Size = new Size(194, 30);
            label3.TabIndex = 5;
            label3.Text = "Incremento salarial:";
            // 
            // btnIncrementarSalario
            // 
            btnIncrementarSalario.Location = new Point(636, 141);
            btnIncrementarSalario.Name = "btnIncrementarSalario";
            btnIncrementarSalario.Size = new Size(189, 84);
            btnIncrementarSalario.TabIndex = 6;
            btnIncrementarSalario.Text = "Incrementar salarios";
            btnIncrementarSalario.UseVisualStyleBackColor = true;
            // 
            // Form06DoctoresEspecialidad
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 427);
            Controls.Add(btnIncrementarSalario);
            Controls.Add(label3);
            Controls.Add(txtIncremento);
            Controls.Add(lstDoctores);
            Controls.Add(label2);
            Controls.Add(lstEspecialidades);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form06DoctoresEspecialidad";
            Text = "Form06DoctoresEspecialidad";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstEspecialidades;
        private Label label2;
        private ListBox lstDoctores;
        private TextBox txtIncremento;
        private Label label3;
        private Button btnIncrementarSalario;
    }
}