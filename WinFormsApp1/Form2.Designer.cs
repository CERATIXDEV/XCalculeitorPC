namespace WinFormsApp1
{
    partial class Form2
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
            textBox1 = new TextBox();
            customButton1 = new CustomButton();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(442, 266);
            textBox1.TabIndex = 0;
            // 
            // customButton1
            // 
            customButton1.BackColor = Color.DarkGray;
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatStyle = FlatStyle.Flat;
            customButton1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customButton1.ForeColor = Color.Black;
            customButton1.Location = new Point(149, 274);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(150, 40);
            customButton1.TabIndex = 1;
            customButton1.Text = "Cerrar";
            customButton1.UseVisualStyleBackColor = false;
            customButton1.Click += customButton1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(448, 325);
            Controls.Add(customButton1);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            HelpButton = true;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Terminos de Licencia";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private CustomButton customButton1;
    }
}