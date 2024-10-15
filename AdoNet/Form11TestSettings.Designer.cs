namespace AdoNet
{
    partial class Form11TestSettings
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
            btnSettings = new Button();
            lblCadenaConexion = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnSettings
            // 
            btnSettings.Location = new Point(40, 19);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(174, 57);
            btnSettings.TabIndex = 0;
            btnSettings.Text = "Leer Settings";
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // lblCadenaConexion
            // 
            lblCadenaConexion.AutoSize = true;
            lblCadenaConexion.Location = new Point(42, 96);
            lblCadenaConexion.Name = "lblCadenaConexion";
            lblCadenaConexion.Size = new Size(68, 30);
            lblCadenaConexion.TabIndex = 1;
            lblCadenaConexion.Text = "label1";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(46, 149);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(229, 238);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(331, 149);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(241, 238);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // Form11TestSettings
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 439);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lblCadenaConexion);
            Controls.Add(btnSettings);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form11TestSettings";
            Text = "Form11TestSettings";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSettings;
        private Label lblCadenaConexion;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}