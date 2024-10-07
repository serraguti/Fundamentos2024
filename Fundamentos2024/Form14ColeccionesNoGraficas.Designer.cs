namespace Fundamentos2024
{
    partial class Form14ColeccionesNoGraficas
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
            lstNombres = new ListBox();
            label2 = new Label();
            txtNombre = new TextBox();
            brtnGuardarNombre = new Button();
            btnMostrarNombres = new Button();
            lblMensaje = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 9);
            label1.Name = "label1";
            label1.Size = new Size(98, 30);
            label1.TabIndex = 0;
            label1.Text = "Nombres";
            // 
            // lstNombres
            // 
            lstNombres.FormattingEnabled = true;
            lstNombres.ItemHeight = 30;
            lstNombres.Location = new Point(32, 46);
            lstNombres.Name = "lstNombres";
            lstNombres.Size = new Size(255, 304);
            lstNombres.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(365, 31);
            label2.Name = "label2";
            label2.Size = new Size(195, 30);
            label2.TabIndex = 2;
            label2.Text = "Introduzca nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(370, 62);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(285, 35);
            txtNombre.TabIndex = 3;
            // 
            // brtnGuardarNombre
            // 
            brtnGuardarNombre.Location = new Point(370, 108);
            brtnGuardarNombre.Name = "brtnGuardarNombre";
            brtnGuardarNombre.Size = new Size(285, 51);
            brtnGuardarNombre.TabIndex = 4;
            brtnGuardarNombre.Text = "Guardar nombre";
            brtnGuardarNombre.UseVisualStyleBackColor = true;
            brtnGuardarNombre.Click += brtnGuardarNombre_Click;
            // 
            // btnMostrarNombres
            // 
            btnMostrarNombres.Location = new Point(370, 170);
            btnMostrarNombres.Name = "btnMostrarNombres";
            btnMostrarNombres.Size = new Size(285, 55);
            btnMostrarNombres.TabIndex = 5;
            btnMostrarNombres.Text = "Mostrar Nombres";
            btnMostrarNombres.UseVisualStyleBackColor = true;
            btnMostrarNombres.Click += btnMostrarNombres_Click;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(374, 260);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(113, 30);
            lblMensaje.TabIndex = 6;
            lblMensaje.Text = "lblMensaje";
            // 
            // Form14ColeccionesNoGraficas
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 398);
            Controls.Add(lblMensaje);
            Controls.Add(btnMostrarNombres);
            Controls.Add(brtnGuardarNombre);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(lstNombres);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form14ColeccionesNoGraficas";
            Text = "Form14ColeccionesNoGraficas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstNombres;
        private Label label2;
        private TextBox txtNombre;
        private Button brtnGuardarNombre;
        private Button btnMostrarNombres;
        private Label lblMensaje;
    }
}