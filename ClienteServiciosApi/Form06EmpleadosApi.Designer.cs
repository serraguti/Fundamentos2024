namespace ClienteServiciosApi
{
    partial class Form06EmpleadosApi
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
            txtOficio = new TextBox();
            btnBuscarEmpleados = new Button();
            label2 = new Label();
            lstEmpleados = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 19);
            label1.Name = "label1";
            label1.Size = new Size(173, 30);
            label1.TabIndex = 0;
            label1.Text = "Introduzca Oficio";
            // 
            // txtOficio
            // 
            txtOficio.Location = new Point(47, 49);
            txtOficio.Name = "txtOficio";
            txtOficio.Size = new Size(256, 35);
            txtOficio.TabIndex = 1;
            // 
            // btnBuscarEmpleados
            // 
            btnBuscarEmpleados.Location = new Point(338, 31);
            btnBuscarEmpleados.Name = "btnBuscarEmpleados";
            btnBuscarEmpleados.Size = new Size(209, 53);
            btnBuscarEmpleados.TabIndex = 2;
            btnBuscarEmpleados.Text = "Buscar empleados";
            btnBuscarEmpleados.UseVisualStyleBackColor = true;
            btnBuscarEmpleados.Click += btnBuscarEmpleados_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 106);
            label2.Name = "label2";
            label2.Size = new Size(114, 30);
            label2.TabIndex = 3;
            label2.Text = "Empleados";
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.ItemHeight = 30;
            lstEmpleados.Location = new Point(51, 139);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(647, 394);
            lstEmpleados.TabIndex = 4;
            // 
            // Form06EmpleadosApi
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 560);
            Controls.Add(lstEmpleados);
            Controls.Add(label2);
            Controls.Add(btnBuscarEmpleados);
            Controls.Add(txtOficio);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form06EmpleadosApi";
            Text = "Form06EmpleadosApi";
            Load += Form06EmpleadosApi_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtOficio;
        private Button btnBuscarEmpleados;
        private Label label2;
        private ListBox lstEmpleados;
    }
}