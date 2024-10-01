namespace Fundamentos2024
{
    partial class Form06ValidarEmail
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
            txtEmail = new TextBox();
            btnValidarEmail = new Button();
            lblMensaje = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 20);
            label1.Name = "label1";
            label1.Size = new Size(195, 30);
            label1.TabIndex = 0;
            label1.Text = "Introduzca su email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(51, 63);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(381, 35);
            txtEmail.TabIndex = 1;
            // 
            // btnValidarEmail
            // 
            btnValidarEmail.Location = new Point(51, 116);
            btnValidarEmail.Name = "btnValidarEmail";
            btnValidarEmail.Size = new Size(381, 48);
            btnValidarEmail.TabIndex = 2;
            btnValidarEmail.Text = "Validar email";
            btnValidarEmail.UseVisualStyleBackColor = true;
            btnValidarEmail.Click += btnValidarEmail_Click;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(52, 192);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(68, 30);
            lblMensaje.TabIndex = 3;
            lblMensaje.Text = "label2";
            // 
            // Form06ValidarEmail
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 278);
            Controls.Add(lblMensaje);
            Controls.Add(btnValidarEmail);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form06ValidarEmail";
            Text = "Form06ValidarEmail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtEmail;
        private Button btnValidarEmail;
        private Label lblMensaje;
    }
}