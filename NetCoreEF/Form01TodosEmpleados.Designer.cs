namespace NetCoreEF
{
    partial class Form01TodosEmpleados
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
            lstEmpleados = new ListBox();
            btnCargarEmpleados = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 20);
            label1.Name = "label1";
            label1.Size = new Size(114, 30);
            label1.TabIndex = 0;
            label1.Text = "Empleados";
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.ItemHeight = 30;
            lstEmpleados.Location = new Point(31, 60);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(321, 334);
            lstEmpleados.TabIndex = 1;
            // 
            // btnCargarEmpleados
            // 
            btnCargarEmpleados.Location = new Point(417, 80);
            btnCargarEmpleados.Name = "btnCargarEmpleados";
            btnCargarEmpleados.Size = new Size(180, 106);
            btnCargarEmpleados.TabIndex = 2;
            btnCargarEmpleados.Text = "Cargar Empleados";
            btnCargarEmpleados.UseVisualStyleBackColor = true;
            // 
            // Form01TodosEmpleados
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 443);
            Controls.Add(btnCargarEmpleados);
            Controls.Add(lstEmpleados);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form01TodosEmpleados";
            Text = "Form01TodosEmpleados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstEmpleados;
        private Button btnCargarEmpleados;
    }
}