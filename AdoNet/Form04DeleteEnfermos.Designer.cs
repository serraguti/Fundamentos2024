namespace AdoNet
{
    partial class Form04DeleteEnfermos
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
            txtInscripcion = new TextBox();
            btnEliminar = new Button();
            label2 = new Label();
            lstEnfermos = new ListBox();
            lblMensaje = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 35);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(113, 30);
            label1.TabIndex = 0;
            label1.Text = "Inscripción";
            // 
            // txtInscripcion
            // 
            txtInscripcion.Location = new Point(32, 71);
            txtInscripcion.Margin = new Padding(5, 6, 5, 6);
            txtInscripcion.Name = "txtInscripcion";
            txtInscripcion.Size = new Size(230, 35);
            txtInscripcion.TabIndex = 1;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(31, 119);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(231, 53);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(286, 32);
            label2.Name = "label2";
            label2.Size = new Size(100, 30);
            label2.TabIndex = 3;
            label2.Text = "Enfermos";
            // 
            // lstEnfermos
            // 
            lstEnfermos.FormattingEnabled = true;
            lstEnfermos.ItemHeight = 30;
            lstEnfermos.Location = new Point(292, 70);
            lstEnfermos.Name = "lstEnfermos";
            lstEnfermos.Size = new Size(348, 334);
            lstEnfermos.TabIndex = 4;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(40, 443);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(113, 30);
            lblMensaje.TabIndex = 5;
            lblMensaje.Text = "lblMensaje";
            // 
            // Form04DeleteEnfermos
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 540);
            Controls.Add(lblMensaje);
            Controls.Add(lstEnfermos);
            Controls.Add(label2);
            Controls.Add(btnEliminar);
            Controls.Add(txtInscripcion);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form04DeleteEnfermos";
            Text = "Form04DeleteEnfermos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtInscripcion;
        private Button btnEliminar;
        private Label label2;
        private ListBox lstEnfermos;
        private Label lblMensaje;
    }
}