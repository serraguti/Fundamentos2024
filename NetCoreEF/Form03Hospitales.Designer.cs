namespace NetCoreEF
{
    partial class Form03Hospitales
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
            btnCargarHospitales = new Button();
            lstHospitales = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCargarHospitales
            // 
            btnCargarHospitales.Location = new Point(50, 19);
            btnCargarHospitales.Name = "btnCargarHospitales";
            btnCargarHospitales.Size = new Size(188, 50);
            btnCargarHospitales.TabIndex = 0;
            btnCargarHospitales.Text = "Cargar Hospitales";
            btnCargarHospitales.UseVisualStyleBackColor = true;
            btnCargarHospitales.Click += btnCargarHospitales_Click;
            // 
            // lstHospitales
            // 
            lstHospitales.FormattingEnabled = true;
            lstHospitales.ItemHeight = 30;
            lstHospitales.Location = new Point(50, 130);
            lstHospitales.Name = "lstHospitales";
            lstHospitales.Size = new Size(313, 364);
            lstHospitales.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 84);
            label1.Name = "label1";
            label1.Size = new Size(109, 30);
            label1.TabIndex = 2;
            label1.Text = "Hospitales";
            // 
            // Form03Hospitales
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(771, 506);
            Controls.Add(label1);
            Controls.Add(lstHospitales);
            Controls.Add(btnCargarHospitales);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form03Hospitales";
            Text = "Form03Hospitales";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCargarHospitales;
        private ListBox lstHospitales;
        private Label label1;
    }
}