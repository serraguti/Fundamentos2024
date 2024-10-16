namespace NetCoreEF
{
    partial class Form02BuscadorEmpleadosSalario
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
            txtSalario = new TextBox();
            btnBuscarSalarios = new Button();
            label2 = new Label();
            lstEmpleados = new ListBox();
            label3 = new Label();
            txtOficio = new TextBox();
            btnBuscarOficios = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 27);
            label1.Name = "label1";
            label1.Size = new Size(80, 30);
            label1.TabIndex = 0;
            label1.Text = "Salario:";
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(39, 61);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(250, 35);
            txtSalario.TabIndex = 1;
            // 
            // btnBuscarSalarios
            // 
            btnBuscarSalarios.Location = new Point(40, 112);
            btnBuscarSalarios.Name = "btnBuscarSalarios";
            btnBuscarSalarios.Size = new Size(249, 54);
            btnBuscarSalarios.TabIndex = 2;
            btnBuscarSalarios.Text = "Buscar Salarios";
            btnBuscarSalarios.UseVisualStyleBackColor = true;
            btnBuscarSalarios.Click += btnBuscarSalarios_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 180);
            label2.Name = "label2";
            label2.Size = new Size(114, 30);
            label2.TabIndex = 3;
            label2.Text = "Empleados";
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.ItemHeight = 30;
            lstEmpleados.Location = new Point(45, 215);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(416, 274);
            lstEmpleados.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(378, 27);
            label3.Name = "label3";
            label3.Size = new Size(68, 30);
            label3.TabIndex = 5;
            label3.Text = "Oficio";
            // 
            // txtOficio
            // 
            txtOficio.Location = new Point(382, 58);
            txtOficio.Name = "txtOficio";
            txtOficio.Size = new Size(297, 35);
            txtOficio.TabIndex = 6;
            // 
            // btnBuscarOficios
            // 
            btnBuscarOficios.Location = new Point(383, 114);
            btnBuscarOficios.Name = "btnBuscarOficios";
            btnBuscarOficios.Size = new Size(296, 52);
            btnBuscarOficios.TabIndex = 7;
            btnBuscarOficios.Text = "Buscar oficios";
            btnBuscarOficios.UseVisualStyleBackColor = true;
            btnBuscarOficios.Click += btnBuscarOficios_Click;
            // 
            // Form02BuscadorEmpleadosSalario
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 511);
            Controls.Add(btnBuscarOficios);
            Controls.Add(txtOficio);
            Controls.Add(label3);
            Controls.Add(lstEmpleados);
            Controls.Add(label2);
            Controls.Add(btnBuscarSalarios);
            Controls.Add(txtSalario);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form02BuscadorEmpleadosSalario";
            Text = "Form02BuscadorEmpleadosSalario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSalario;
        private Button btnBuscarSalarios;
        private Label label2;
        private ListBox lstEmpleados;
        private Label label3;
        private TextBox txtOficio;
        private Button btnBuscarOficios;
    }
}