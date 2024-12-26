namespace WinFormsApp1
{
    partial class Form3
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
            materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            customButton1 = new CustomButton();
            label5 = new Label();
            SuspendLayout();
            // 
            // materialContextMenuStrip1
            // 
            materialContextMenuStrip1.BackColor = Color.FromArgb(255, 255, 255);
            materialContextMenuStrip1.Depth = 0;
            materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            materialContextMenuStrip1.Size = new Size(61, 4);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(235, 45);
            label1.TabIndex = 1;
            label1.Text = "XCalculeitor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 75);
            label2.Name = "label2";
            label2.Size = new Size(143, 21);
            label2.TabIndex = 2;
            label2.Text = "© 2024 CeratixDev";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 54);
            label3.Name = "label3";
            label3.Size = new Size(65, 21);
            label3.TabIndex = 3;
            label3.Text = "Version:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 96);
            label4.Name = "label4";
            label4.Size = new Size(167, 21);
            label4.TabIndex = 4;
            label4.Text = "ceratixdev@gmail.com";
            // 
            // customButton1
            // 
            customButton1.BackColor = Color.DarkGray;
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatStyle = FlatStyle.Flat;
            customButton1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customButton1.ForeColor = Color.Black;
            customButton1.Location = new Point(48, 150);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(150, 40);
            customButton1.TabIndex = 5;
            customButton1.Text = "Cerrar";
            customButton1.UseVisualStyleBackColor = false;
            customButton1.Click += customButton1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Blue;
            label5.Location = new Point(12, 117);
            label5.Name = "label5";
            label5.Size = new Size(153, 21);
            label5.TabIndex = 6;
            label5.Text = "Terminos de LIcencia";
            label5.Click += label5_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            ClientSize = new Size(256, 202);
            Controls.Add(label5);
            Controls.Add(customButton1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            KeyPreview = true;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "XCalculeitor";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private CustomButton customButton1;
        private Label label5;
    }
}