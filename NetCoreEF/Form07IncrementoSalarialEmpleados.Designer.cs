namespace NetCoreEF
{
    partial class Form07IncrementoSalarialEmpleados
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
            label2 = new Label();
            txtIncremento = new TextBox();
            btnIncrementarSalario = new Button();
            label3 = new Label();
            lstEmpleados = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 31);
            label1.Name = "label1";
            label1.Size = new Size(68, 30);
            label1.TabIndex = 0;
            label1.Text = "Oficio";
            // 
            // txtOficio
            // 
            txtOficio.Location = new Point(33, 67);
            txtOficio.Name = "txtOficio";
            txtOficio.Size = new Size(186, 35);
            txtOficio.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 115);
            label2.Name = "label2";
            label2.Size = new Size(189, 30);
            label2.TabIndex = 2;
            label2.Text = "Incremento salarial";
            // 
            // txtIncremento
            // 
            txtIncremento.Location = new Point(32, 148);
            txtIncremento.Name = "txtIncremento";
            txtIncremento.Size = new Size(187, 35);
            txtIncremento.TabIndex = 3;
            // 
            // btnIncrementarSalario
            // 
            btnIncrementarSalario.Location = new Point(34, 201);
            btnIncrementarSalario.Name = "btnIncrementarSalario";
            btnIncrementarSalario.Size = new Size(185, 102);
            btnIncrementarSalario.TabIndex = 4;
            btnIncrementarSalario.Text = "Incrementar salarios";
            btnIncrementarSalario.UseVisualStyleBackColor = true;
            btnIncrementarSalario.Click += btnIncrementarSalario_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(267, 31);
            label3.Name = "label3";
            label3.Size = new Size(114, 30);
            label3.TabIndex = 5;
            label3.Text = "Empleados";
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.ItemHeight = 30;
            lstEmpleados.Location = new Point(271, 63);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(392, 394);
            lstEmpleados.TabIndex = 6;
            // 
            // Form07IncrementoSalarialEmpleados
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(715, 484);
            Controls.Add(lstEmpleados);
            Controls.Add(label3);
            Controls.Add(btnIncrementarSalario);
            Controls.Add(txtIncremento);
            Controls.Add(label2);
            Controls.Add(txtOficio);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form07IncrementoSalarialEmpleados";
            Text = "Form07IncrementoSalarialEmpleados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtOficio;
        private Label label2;
        private TextBox txtIncremento;
        private Button btnIncrementarSalario;
        private Label label3;
        private ListBox lstEmpleados;
    }
}