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
            lsvHospitales = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
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
            lstHospitales.Location = new Point(727, 92);
            lstHospitales.Name = "lstHospitales";
            lstHospitales.Size = new Size(313, 364);
            lstHospitales.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(727, 46);
            label1.Name = "label1";
            label1.Size = new Size(109, 30);
            label1.TabIndex = 2;
            label1.Text = "Hospitales";
            // 
            // lsvHospitales
            // 
            lsvHospitales.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            lsvHospitales.FullRowSelect = true;
            lsvHospitales.Location = new Point(51, 92);
            lsvHospitales.Name = "lsvHospitales";
            lsvHospitales.Size = new Size(637, 385);
            lsvHospitales.TabIndex = 3;
            lsvHospitales.UseCompatibleStateImageBehavior = false;
            lsvHospitales.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nombre";
            columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Dirección";
            columnHeader3.Width = 180;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Teléfono";
            columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Camas";
            columnHeader5.Width = 100;
            // 
            // Form03Hospitales
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 506);
            Controls.Add(lsvHospitales);
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
        private ListView lsvHospitales;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
    }
}