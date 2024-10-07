namespace Fundamentos2024
{
    partial class Form15ColeccionPersonas
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
            lblMensaje = new Label();
            btnMostrarPersonas = new Button();
            brtnGuardarPersona = new Button();
            txtNombre = new TextBox();
            label2 = new Label();
            lstPersonas = new ListBox();
            label1 = new Label();
            label3 = new Label();
            txtApellidos = new TextBox();
            label4 = new Label();
            txtEdad = new TextBox();
            SuspendLayout();
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(43, 438);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(113, 30);
            lblMensaje.TabIndex = 13;
            lblMensaje.Text = "lblMensaje";
            // 
            // btnMostrarPersonas
            // 
            btnMostrarPersonas.Location = new Point(385, 363);
            btnMostrarPersonas.Name = "btnMostrarPersonas";
            btnMostrarPersonas.Size = new Size(285, 55);
            btnMostrarPersonas.TabIndex = 12;
            btnMostrarPersonas.Text = "Mostrar personas";
            btnMostrarPersonas.UseVisualStyleBackColor = true;
            // 
            // brtnGuardarPersona
            // 
            brtnGuardarPersona.Location = new Point(385, 301);
            brtnGuardarPersona.Name = "brtnGuardarPersona";
            brtnGuardarPersona.Size = new Size(285, 51);
            brtnGuardarPersona.TabIndex = 11;
            brtnGuardarPersona.Text = "Guardar persona";
            brtnGuardarPersona.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(381, 70);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(285, 35);
            txtNombre.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(376, 39);
            label2.Name = "label2";
            label2.Size = new Size(195, 30);
            label2.TabIndex = 9;
            label2.Text = "Introduzca nombre:";
            // 
            // lstPersonas
            // 
            lstPersonas.FormattingEnabled = true;
            lstPersonas.ItemHeight = 30;
            lstPersonas.Location = new Point(43, 54);
            lstPersonas.Name = "lstPersonas";
            lstPersonas.Size = new Size(272, 364);
            lstPersonas.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 17);
            label1.Name = "label1";
            label1.Size = new Size(95, 30);
            label1.TabIndex = 7;
            label1.Text = "Personas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(381, 115);
            label3.Name = "label3";
            label3.Size = new Size(98, 30);
            label3.TabIndex = 14;
            label3.Text = "Apellidos";
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(383, 153);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(283, 35);
            txtApellidos.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(385, 199);
            label4.Name = "label4";
            label4.Size = new Size(64, 30);
            label4.TabIndex = 16;
            label4.Text = "Edad:";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(384, 231);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 35);
            txtEdad.TabIndex = 17;
            // 
            // Form15ColeccionPersonas
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 540);
            Controls.Add(txtEdad);
            Controls.Add(label4);
            Controls.Add(txtApellidos);
            Controls.Add(label3);
            Controls.Add(lblMensaje);
            Controls.Add(btnMostrarPersonas);
            Controls.Add(brtnGuardarPersona);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(lstPersonas);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form15ColeccionPersonas";
            Text = "Form15ColeccionPersonas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMensaje;
        private Button btnMostrarPersonas;
        private Button brtnGuardarPersona;
        private TextBox txtNombre;
        private Label label2;
        private ListBox lstPersonas;
        private Label label1;
        private Label label3;
        private TextBox txtApellidos;
        private Label label4;
        private TextBox txtEdad;
    }
}