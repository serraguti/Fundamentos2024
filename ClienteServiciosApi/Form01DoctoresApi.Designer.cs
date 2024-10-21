namespace ClienteServiciosApi
{
    partial class Form01DoctoresApi
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
            lsvDoctores = new ListView();
            btnCargarDoctores = new Button();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 49);
            label1.Name = "label1";
            label1.Size = new Size(96, 30);
            label1.TabIndex = 0;
            label1.Text = "Doctores";
            // 
            // lsvDoctores
            // 
            lsvDoctores.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            lsvDoctores.FullRowSelect = true;
            lsvDoctores.Location = new Point(32, 82);
            lsvDoctores.Name = "lsvDoctores";
            lsvDoctores.Size = new Size(713, 354);
            lsvDoctores.TabIndex = 1;
            lsvDoctores.UseCompatibleStateImageBehavior = false;
            lsvDoctores.View = View.Details;
            // 
            // btnCargarDoctores
            // 
            btnCargarDoctores.Location = new Point(392, 12);
            btnCargarDoctores.Name = "btnCargarDoctores";
            btnCargarDoctores.Size = new Size(187, 54);
            btnCargarDoctores.TabIndex = 2;
            btnCargarDoctores.Text = "Cargar doctores";
            btnCargarDoctores.UseVisualStyleBackColor = true;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Apellido";
            columnHeader2.Width = 160;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Especialidad";
            columnHeader3.Width = 180;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Salario";
            columnHeader4.Width = 140;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Id hospital";
            columnHeader5.Width = 120;
            // 
            // Form01DoctoresApi
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 567);
            Controls.Add(btnCargarDoctores);
            Controls.Add(lsvDoctores);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form01DoctoresApi";
            Text = "Form01DoctoresApi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView lsvDoctores;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Button btnCargarDoctores;
    }
}