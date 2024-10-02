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
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(55, 44);
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
            lblRaton.Location = new Point(280, 39);
            lblRaton.Name = "lblRaton";
            lblRaton.Size = new Size(496, 233);
            lblRaton.TabIndex = 3;
            lblRaton.Text = "lblRaton";
            lblRaton.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form09EventosMetodos
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 519);
            Controls.Add(lblRaton);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form09EventosMetodos";
            Text = "Form09EventosMetodos";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label lblRaton;
    }
}