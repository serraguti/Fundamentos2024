namespace AdoNet
{
    partial class Form05ModificarSalas
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
            lstSalas = new ListBox();
            label2 = new Label();
            txtNombreSala = new TextBox();
            btnModificarSalas = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 28);
            label1.Name = "label1";
            label1.Size = new Size(60, 30);
            label1.TabIndex = 0;
            label1.Text = "Salas";
            // 
            // lstSalas
            // 
            lstSalas.FormattingEnabled = true;
            lstSalas.ItemHeight = 30;
            lstSalas.Location = new Point(35, 59);
            lstSalas.Name = "lstSalas";
            lstSalas.Size = new Size(257, 274);
            lstSalas.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(356, 37);
            label2.Name = "label2";
            label2.Size = new Size(116, 30);
            label2.TabIndex = 2;
            label2.Text = "Nuevo sala";
            // 
            // txtNombreSala
            // 
            txtNombreSala.Location = new Point(356, 70);
            txtNombreSala.Name = "txtNombreSala";
            txtNombreSala.Size = new Size(253, 35);
            txtNombreSala.TabIndex = 3;
            // 
            // btnModificarSalas
            // 
            btnModificarSalas.Location = new Point(356, 113);
            btnModificarSalas.Name = "btnModificarSalas";
            btnModificarSalas.Size = new Size(253, 51);
            btnModificarSalas.TabIndex = 4;
            btnModificarSalas.Text = "Modificar salas";
            btnModificarSalas.UseVisualStyleBackColor = true;
            // 
            // Form05ModificarSalas
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 361);
            Controls.Add(btnModificarSalas);
            Controls.Add(txtNombreSala);
            Controls.Add(label2);
            Controls.Add(lstSalas);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form05ModificarSalas";
            Text = "Form05ModificarSalas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstSalas;
        private Label label2;
        private TextBox txtNombreSala;
        private Button btnModificarSalas;
    }
}