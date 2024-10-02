namespace Fundamentos2024
{
    partial class Form09EventosMetodos
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            lblRaton = new Label();
            lblAccion = new Label();
            label1 = new Label();
            txtSoloLetras = new TextBox();
            label2 = new Label();
            txtSoloNumeros = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(55, 39);
            button1.Name = "button1";
            button1.Size = new Size(152, 60);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(55, 122);
            button2.Name = "button2";
            button2.Size = new Size(152, 61);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(55, 199);
            button3.Name = "button3";
            button3.Size = new Size(152, 63);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // lblRaton
            // 
            lblRaton.BackColor = Color.FromArgb(192, 255, 192);
            lblRaton.BorderStyle = BorderStyle.FixedSingle;
            lblRaton.Location = new Point(271, 36);
            lblRaton.Name = "lblRaton";
            lblRaton.Size = new Size(496, 233);
            lblRaton.TabIndex = 3;
            lblRaton.Text = "lblRaton";
            lblRaton.TextAlign = ContentAlignment.MiddleCenter;
            lblRaton.Click += lblRaton_Click;
            lblRaton.MouseMove += lblRaton_MouseMove;
            // 
            // lblAccion
            // 
            lblAccion.AutoSize = true;
            lblAccion.Location = new Point(58, 300);
            lblAccion.Name = "lblAccion";
            lblAccion.Size = new Size(98, 30);
            lblAccion.TabIndex = 4;
            lblAccion.Text = "lblAccion";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 356);
            label1.Name = "label1";
            label1.Size = new Size(114, 30);
            label1.TabIndex = 5;
            label1.Text = "Solo Letras";
            // 
            // txtSoloLetras
            // 
            txtSoloLetras.Location = new Point(225, 351);
            txtSoloLetras.Name = "txtSoloLetras";
            txtSoloLetras.Size = new Size(329, 35);
            txtSoloLetras.TabIndex = 6;
            txtSoloLetras.KeyPress += txtSoloLetras_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 423);
            label2.Name = "label2";
            label2.Size = new Size(144, 30);
            label2.TabIndex = 7;
            label2.Text = "Solo Números";
            // 
            // txtSoloNumeros
            // 
            txtSoloNumeros.Location = new Point(225, 418);
            txtSoloNumeros.Name = "txtSoloNumeros";
            txtSoloNumeros.Size = new Size(329, 35);
            txtSoloNumeros.TabIndex = 8;
            txtSoloNumeros.KeyPress += txtSoloNumeros_KeyPress;
            // 
            // Form09EventosMetodos
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 519);
            Controls.Add(txtSoloNumeros);
            Controls.Add(label2);
            Controls.Add(txtSoloLetras);
            Controls.Add(label1);
            Controls.Add(lblAccion);
            Controls.Add(lblRaton);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form09EventosMetodos";
            Text = "Form09EventosMetodos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label lblRaton;
        private Label lblAccion;
        private Label label1;
        private TextBox txtSoloLetras;
        private Label label2;
        private TextBox txtSoloNumeros;
    }
}