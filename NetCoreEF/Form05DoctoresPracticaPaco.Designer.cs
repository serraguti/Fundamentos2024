namespace NetCoreEF
{
    partial class Form05DoctoresPracticaPaco
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
            lstDoctores = new ListBox();
            btnCargarDoctores = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 12);
            label1.Name = "label1";
            label1.Size = new Size(96, 30);
            label1.TabIndex = 0;
            label1.Text = "Doctores";
            // 
            // lstDoctores
            // 
            lstDoctores.FormattingEnabled = true;
            lstDoctores.ItemHeight = 30;
            lstDoctores.Location = new Point(24, 45);
            lstDoctores.Name = "lstDoctores";
            lstDoctores.Size = new Size(435, 364);
            lstDoctores.TabIndex = 1;
            // 
            // btnCargarDoctores
            // 
            btnCargarDoctores.Location = new Point(540, 49);
            btnCargarDoctores.Name = "btnCargarDoctores";
            btnCargarDoctores.Size = new Size(236, 63);
            btnCargarDoctores.TabIndex = 2;
            btnCargarDoctores.Text = "Cargar Doctores";
            btnCargarDoctores.UseVisualStyleBackColor = true;
            btnCargarDoctores.Click += btnCargarDoctores_Click;
            // 
            // Form05DoctoresPracticaPaco
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 436);
            Controls.Add(btnCargarDoctores);
            Controls.Add(lstDoctores);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form05DoctoresPracticaPaco";
            Text = "Form05DoctoresPracticaPaco";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstDoctores;
        private Button btnCargarDoctores;
    }
}