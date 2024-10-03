namespace Fundamentos2024
{
    partial class Form12TestClases
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
            lstPropiedadesPersona = new ListBox();
            btnCrearPersona = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 33);
            label1.Name = "label1";
            label1.Size = new Size(207, 30);
            label1.TabIndex = 0;
            label1.Text = "Propiedades persona";
            // 
            // lstPropiedadesPersona
            // 
            lstPropiedadesPersona.FormattingEnabled = true;
            lstPropiedadesPersona.ItemHeight = 30;
            lstPropiedadesPersona.Location = new Point(50, 66);
            lstPropiedadesPersona.Name = "lstPropiedadesPersona";
            lstPropiedadesPersona.Size = new Size(621, 364);
            lstPropiedadesPersona.TabIndex = 1;
            // 
            // btnCrearPersona
            // 
            btnCrearPersona.Location = new Point(50, 452);
            btnCrearPersona.Name = "btnCrearPersona";
            btnCrearPersona.Size = new Size(185, 54);
            btnCrearPersona.TabIndex = 2;
            btnCrearPersona.Text = "Crear Persona";
            btnCrearPersona.UseVisualStyleBackColor = true;
            btnCrearPersona.Click += btnCrearPersona_Click;
            // 
            // Form12TestClases
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 536);
            Controls.Add(btnCrearPersona);
            Controls.Add(lstPropiedadesPersona);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form12TestClases";
            Text = "Form12TestClases";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstPropiedadesPersona;
        private Button btnCrearPersona;
    }
}