namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        
        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            configuracionToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            salirToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            toolTip1 = new ToolTip(components);
            customButton1 = new CustomButton();
            customButton2 = new CustomButton();
            customButton3 = new CustomButton();
            customButton4 = new CustomButton();
            customButton5 = new CustomButton();
            customButton6 = new CustomButton();
            customButton7 = new CustomButton();
            customButton8 = new CustomButton();
            customButton9 = new CustomButton();
            customButton10 = new CustomButton();
            customButton11 = new CustomButton();
            customButton12 = new CustomButton();
            customButton13 = new CustomButton();
            customButton14 = new CustomButton();
            customButton15 = new CustomButton();
            customButton16 = new CustomButton();
            customButton17 = new CustomButton();
            customButton18 = new CustomButton();
            customButton19 = new CustomButton();
            customButton20 = new CustomButton();
            customButton21 = new CustomButton();
            customButton22 = new CustomButton();
            customButton23 = new CustomButton();
            customButton24 = new CustomButton();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(0, 28);
            label1.Name = "label1";
            label1.Size = new Size(297, 27);
            label1.TabIndex = 0;
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(-1, 55);
            label2.Name = "label2";
            label2.Size = new Size(307, 90);
            label2.TabIndex = 21;
            label2.Text = "0";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, ayudaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(297, 28);
            menuStrip1.TabIndex = 22;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { configuracionToolStripMenuItem, toolStripMenuItem1, salirToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(61, 24);
            menuToolStripMenuItem.Text = "&Menu";
            // 
            // configuracionToolStripMenuItem
            // 
            configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            configuracionToolStripMenuItem.Size = new Size(176, 24);
            configuracionToolStripMenuItem.Text = "&Configuración";
            configuracionToolStripMenuItem.Click += configuracionToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(173, 6);
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(176, 24);
            salirToolStripMenuItem.Text = "&Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { acercaDeToolStripMenuItem });
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(66, 24);
            ayudaToolStripMenuItem.Text = "&Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(158, 24);
            acercaDeToolStripMenuItem.Text = "Acerca de...";
            acercaDeToolStripMenuItem.Click += acercaDeToolStripMenuItem_Click;
            // 
            // customButton1
            // 
            customButton1.BackColor = Color.Khaki;
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatStyle = FlatStyle.Flat;
            customButton1.Font = new Font("Arial", 14.25F);
            customButton1.ForeColor = Color.Black;
            customButton1.Location = new Point(0, 145);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(73, 37);
            customButton1.TabIndex = 30;
            customButton1.Text = "Sen";
            customButton1.UseVisualStyleBackColor = false;
            customButton1.Click += customButton1_Click;
            // 
            // customButton2
            // 
            customButton2.BackColor = Color.Khaki;
            customButton2.FlatAppearance.BorderSize = 0;
            customButton2.FlatStyle = FlatStyle.Flat;
            customButton2.Font = new Font("Arial", 14.25F);
            customButton2.ForeColor = Color.Black;
            customButton2.Location = new Point(74, 145);
            customButton2.Name = "customButton2";
            customButton2.Size = new Size(73, 37);
            customButton2.TabIndex = 31;
            customButton2.Text = "Cos";
            customButton2.UseVisualStyleBackColor = false;
            customButton2.Click += customButton2_Click;
            // 
            // customButton3
            // 
            customButton3.BackColor = Color.Khaki;
            customButton3.FlatAppearance.BorderSize = 0;
            customButton3.FlatStyle = FlatStyle.Flat;
            customButton3.Font = new Font("Arial", 14.25F);
            customButton3.ForeColor = Color.Black;
            customButton3.Location = new Point(148, 145);
            customButton3.Name = "customButton3";
            customButton3.Size = new Size(73, 37);
            customButton3.TabIndex = 32;
            customButton3.Text = "Tan";
            customButton3.UseVisualStyleBackColor = false;
            customButton3.Click += customButton3_Click;
            // 
            // customButton4
            // 
            customButton4.BackColor = Color.Khaki;
            customButton4.FlatAppearance.BorderSize = 0;
            customButton4.FlatStyle = FlatStyle.Flat;
            customButton4.Font = new Font("Arial", 14.25F);
            customButton4.ForeColor = Color.Black;
            customButton4.Location = new Point(222, 145);
            customButton4.Name = "customButton4";
            customButton4.Size = new Size(73, 37);
            customButton4.TabIndex = 33;
            customButton4.Text = "√³";
            customButton4.UseVisualStyleBackColor = false;
            customButton4.Click += customButton4_Click;
            // 
            // customButton5
            // 
            customButton5.BackColor = SystemColors.ActiveCaption;
            customButton5.FlatAppearance.BorderSize = 0;
            customButton5.FlatStyle = FlatStyle.Flat;
            customButton5.Font = new Font("Arial Black", 20F, FontStyle.Bold);
            customButton5.ForeColor = Color.Black;
            customButton5.Location = new Point(0, 183);
            customButton5.Name = "customButton5";
            customButton5.Size = new Size(73, 73);
            customButton5.TabIndex = 34;
            customButton5.Text = "C";
            customButton5.UseVisualStyleBackColor = false;
            customButton5.Click += customButton5_Click;
            // 
            // customButton6
            // 
            customButton6.BackColor = SystemColors.ActiveCaption;
            customButton6.FlatAppearance.BorderSize = 0;
            customButton6.FlatStyle = FlatStyle.Flat;
            customButton6.Font = new Font("Arial Black", 20F, FontStyle.Bold);
            customButton6.ForeColor = Color.Black;
            customButton6.Location = new Point(74, 183);
            customButton6.Name = "customButton6";
            customButton6.Size = new Size(73, 73);
            customButton6.TabIndex = 35;
            customButton6.Text = "√²";
            customButton6.UseVisualStyleBackColor = false;
            customButton6.Click += customButton6_Click;
            // 
            // customButton7
            // 
            customButton7.BackColor = SystemColors.ActiveCaption;
            customButton7.FlatAppearance.BorderSize = 0;
            customButton7.FlatStyle = FlatStyle.Flat;
            customButton7.Font = new Font("Arial Black", 20F, FontStyle.Bold);
            customButton7.ForeColor = Color.Black;
            customButton7.Location = new Point(148, 183);
            customButton7.Name = "customButton7";
            customButton7.Size = new Size(73, 73);
            customButton7.TabIndex = 36;
            customButton7.Text = "xʸ";
            customButton7.UseVisualStyleBackColor = false;
            customButton7.Click += customButton7_Click;
            // 
            // customButton8
            // 
            customButton8.BackColor = SystemColors.ActiveCaption;
            customButton8.FlatAppearance.BorderSize = 0;
            customButton8.FlatStyle = FlatStyle.Flat;
            customButton8.Font = new Font("Arial Black", 20F, FontStyle.Bold);
            customButton8.ForeColor = Color.Black;
            customButton8.Location = new Point(222, 183);
            customButton8.Name = "customButton8";
            customButton8.Size = new Size(73, 73);
            customButton8.TabIndex = 37;
            customButton8.Text = "CE";
            customButton8.UseVisualStyleBackColor = false;
            customButton8.Click += customButton8_Click;
            // 
            // customButton9
            // 
            customButton9.BackColor = Color.LightGray;
            customButton9.FlatAppearance.BorderSize = 0;
            customButton9.FlatStyle = FlatStyle.Flat;
            customButton9.Font = new Font("Arial Black", 24F, FontStyle.Bold);
            customButton9.ForeColor = Color.Black;
            customButton9.Location = new Point(0, 257);
            customButton9.Name = "customButton9";
            customButton9.Size = new Size(73, 73);
            customButton9.TabIndex = 38;
            customButton9.Text = "7";
            customButton9.UseVisualStyleBackColor = false;
            customButton9.Click += customButton9_Click;
            // 
            // customButton10
            // 
            customButton10.BackColor = Color.LightGray;
            customButton10.FlatAppearance.BorderSize = 0;
            customButton10.FlatStyle = FlatStyle.Flat;
            customButton10.Font = new Font("Arial Black", 24F, FontStyle.Bold);
            customButton10.ForeColor = Color.Black;
            customButton10.Location = new Point(74, 257);
            customButton10.Name = "customButton10";
            customButton10.Size = new Size(73, 73);
            customButton10.TabIndex = 39;
            customButton10.Text = "8";
            customButton10.UseVisualStyleBackColor = false;
            customButton10.Click += customButton10_Click;
            // 
            // customButton11
            // 
            customButton11.BackColor = Color.LightGray;
            customButton11.FlatAppearance.BorderSize = 0;
            customButton11.FlatStyle = FlatStyle.Flat;
            customButton11.Font = new Font("Arial Black", 24F, FontStyle.Bold);
            customButton11.ForeColor = Color.Black;
            customButton11.Location = new Point(148, 257);
            customButton11.Name = "customButton11";
            customButton11.Size = new Size(73, 73);
            customButton11.TabIndex = 40;
            customButton11.Text = "9";
            customButton11.UseVisualStyleBackColor = false;
            customButton11.Click += customButton11_Click;
            // 
            // customButton12
            // 
            customButton12.BackColor = SystemColors.ActiveCaption;
            customButton12.FlatAppearance.BorderSize = 0;
            customButton12.FlatStyle = FlatStyle.Flat;
            customButton12.Font = new Font("Arial Black", 20F, FontStyle.Bold);
            customButton12.ForeColor = Color.Black;
            customButton12.Location = new Point(222, 257);
            customButton12.Name = "customButton12";
            customButton12.Size = new Size(73, 73);
            customButton12.TabIndex = 41;
            customButton12.Text = "+";
            customButton12.UseVisualStyleBackColor = false;
            customButton12.Click += customButton12_Click;
            // 
            // customButton13
            // 
            customButton13.BackColor = Color.LightGray;
            customButton13.FlatAppearance.BorderSize = 0;
            customButton13.FlatStyle = FlatStyle.Flat;
            customButton13.Font = new Font("Arial Black", 24F, FontStyle.Bold);
            customButton13.ForeColor = Color.Black;
            customButton13.Location = new Point(0, 331);
            customButton13.Name = "customButton13";
            customButton13.Size = new Size(73, 73);
            customButton13.TabIndex = 42;
            customButton13.Text = "4";
            customButton13.UseVisualStyleBackColor = false;
            customButton13.Click += customButton13_Click;
            // 
            // customButton14
            // 
            customButton14.BackColor = Color.LightGray;
            customButton14.FlatAppearance.BorderSize = 0;
            customButton14.FlatStyle = FlatStyle.Flat;
            customButton14.Font = new Font("Arial Black", 24F, FontStyle.Bold);
            customButton14.ForeColor = Color.Black;
            customButton14.Location = new Point(74, 331);
            customButton14.Name = "customButton14";
            customButton14.Size = new Size(73, 73);
            customButton14.TabIndex = 43;
            customButton14.Text = "5";
            customButton14.UseVisualStyleBackColor = false;
            customButton14.Click += customButton14_Click;
            // 
            // customButton15
            // 
            customButton15.BackColor = Color.LightGray;
            customButton15.FlatAppearance.BorderSize = 0;
            customButton15.FlatStyle = FlatStyle.Flat;
            customButton15.Font = new Font("Arial Black", 24F, FontStyle.Bold);
            customButton15.ForeColor = Color.Black;
            customButton15.Location = new Point(148, 331);
            customButton15.Name = "customButton15";
            customButton15.Size = new Size(73, 73);
            customButton15.TabIndex = 44;
            customButton15.Text = "6";
            customButton15.UseVisualStyleBackColor = false;
            customButton15.Click += customButton15_Click;
            // 
            // customButton16
            // 
            customButton16.BackColor = SystemColors.ActiveCaption;
            customButton16.FlatAppearance.BorderSize = 0;
            customButton16.FlatStyle = FlatStyle.Flat;
            customButton16.Font = new Font("Arial Black", 20F, FontStyle.Bold);
            customButton16.ForeColor = Color.Black;
            customButton16.Location = new Point(222, 331);
            customButton16.Name = "customButton16";
            customButton16.Size = new Size(73, 73);
            customButton16.TabIndex = 45;
            customButton16.Text = "-";
            customButton16.UseVisualStyleBackColor = false;
            customButton16.Click += customButton16_Click;
            // 
            // customButton17
            // 
            customButton17.BackColor = Color.LightGray;
            customButton17.FlatAppearance.BorderSize = 0;
            customButton17.FlatStyle = FlatStyle.Flat;
            customButton17.Font = new Font("Arial Black", 24F, FontStyle.Bold);
            customButton17.ForeColor = Color.Black;
            customButton17.Location = new Point(0, 405);
            customButton17.Name = "customButton17";
            customButton17.Size = new Size(73, 73);
            customButton17.TabIndex = 46;
            customButton17.Text = "1";
            customButton17.UseVisualStyleBackColor = false;
            customButton17.Click += customButton17_Click;
            // 
            // customButton18
            // 
            customButton18.BackColor = Color.LightGray;
            customButton18.FlatAppearance.BorderSize = 0;
            customButton18.FlatStyle = FlatStyle.Flat;
            customButton18.Font = new Font("Arial Black", 24F, FontStyle.Bold);
            customButton18.ForeColor = Color.Black;
            customButton18.Location = new Point(74, 405);
            customButton18.Name = "customButton18";
            customButton18.Size = new Size(73, 73);
            customButton18.TabIndex = 47;
            customButton18.Text = "2";
            customButton18.UseVisualStyleBackColor = false;
            customButton18.Click += customButton18_Click;
            // 
            // customButton19
            // 
            customButton19.BackColor = Color.LightGray;
            customButton19.FlatAppearance.BorderSize = 0;
            customButton19.FlatStyle = FlatStyle.Flat;
            customButton19.Font = new Font("Arial Black", 24F, FontStyle.Bold);
            customButton19.ForeColor = Color.Black;
            customButton19.Location = new Point(148, 405);
            customButton19.Name = "customButton19";
            customButton19.Size = new Size(73, 73);
            customButton19.TabIndex = 48;
            customButton19.Text = "3";
            customButton19.UseVisualStyleBackColor = false;
            customButton19.Click += customButton19_Click;
            // 
            // customButton20
            // 
            customButton20.BackColor = SystemColors.ActiveCaption;
            customButton20.FlatAppearance.BorderSize = 0;
            customButton20.FlatStyle = FlatStyle.Flat;
            customButton20.Font = new Font("Arial Black", 20F, FontStyle.Bold);
            customButton20.ForeColor = Color.Black;
            customButton20.Location = new Point(222, 405);
            customButton20.Name = "customButton20";
            customButton20.Size = new Size(73, 73);
            customButton20.TabIndex = 49;
            customButton20.Text = "/";
            customButton20.UseVisualStyleBackColor = false;
            customButton20.Click += customButton20_Click;
            // 
            // customButton21
            // 
            customButton21.BackColor = SystemColors.ActiveCaption;
            customButton21.FlatAppearance.BorderSize = 0;
            customButton21.FlatStyle = FlatStyle.Flat;
            customButton21.Font = new Font("Arial Black", 20F, FontStyle.Bold);
            customButton21.ForeColor = Color.Black;
            customButton21.Location = new Point(0, 479);
            customButton21.Name = "customButton21";
            customButton21.Size = new Size(73, 73);
            customButton21.TabIndex = 50;
            customButton21.Text = "=";
            customButton21.UseVisualStyleBackColor = false;
            customButton21.Click += customButton21_Click;
            // 
            // customButton22
            // 
            customButton22.BackColor = Color.LightGray;
            customButton22.FlatAppearance.BorderSize = 0;
            customButton22.FlatStyle = FlatStyle.Flat;
            customButton22.Font = new Font("Arial Black", 24F, FontStyle.Bold);
            customButton22.ForeColor = Color.Black;
            customButton22.Location = new Point(74, 479);
            customButton22.Name = "customButton22";
            customButton22.Size = new Size(73, 73);
            customButton22.TabIndex = 51;
            customButton22.Text = "0";
            customButton22.UseVisualStyleBackColor = false;
            customButton22.Click += customButton22_Click;
            // 
            // customButton23
            // 
            customButton23.BackColor = Color.LightGray;
            customButton23.FlatAppearance.BorderSize = 0;
            customButton23.FlatStyle = FlatStyle.Flat;
            customButton23.Font = new Font("Arial Black", 24F, FontStyle.Bold);
            customButton23.ForeColor = Color.Black;
            customButton23.Location = new Point(148, 479);
            customButton23.Name = "customButton23";
            customButton23.Size = new Size(73, 73);
            customButton23.TabIndex = 52;
            customButton23.Text = ",";
            customButton23.UseVisualStyleBackColor = false;
            customButton23.Click += customButton23_Click;
            // 
            // customButton24
            // 
            customButton24.BackColor = SystemColors.ActiveCaption;
            customButton24.FlatAppearance.BorderSize = 0;
            customButton24.FlatStyle = FlatStyle.Flat;
            customButton24.Font = new Font("Arial Black", 20F, FontStyle.Bold);
            customButton24.ForeColor = Color.Black;
            customButton24.Location = new Point(222, 479);
            customButton24.Name = "customButton24";
            customButton24.Size = new Size(73, 73);
            customButton24.TabIndex = 53;
            customButton24.Text = "*";
            customButton24.UseVisualStyleBackColor = false;
            customButton24.Click += customButton24_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(297, 558);
            Controls.Add(customButton24);
            Controls.Add(customButton23);
            Controls.Add(customButton22);
            Controls.Add(customButton21);
            Controls.Add(customButton20);
            Controls.Add(customButton19);
            Controls.Add(customButton18);
            Controls.Add(customButton17);
            Controls.Add(customButton16);
            Controls.Add(customButton15);
            Controls.Add(customButton14);
            Controls.Add(customButton13);
            Controls.Add(customButton12);
            Controls.Add(customButton11);
            Controls.Add(customButton10);
            Controls.Add(customButton9);
            Controls.Add(customButton8);
            Controls.Add(customButton7);
            Controls.Add(customButton6);
            Controls.Add(customButton5);
            Controls.Add(customButton4);
            Controls.Add(customButton3);
            Controls.Add(customButton2);
            Controls.Add(customButton1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Controls.Add(label2);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "XCalculeitor";
            Activated += Form1_Activated;
            Load += Form1_Load;
            KeyPress += Form1_KeyPress;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem configuracionToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolTip toolTip1;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private CustomButton customButton1;
        private CustomButton customButton2;
        private CustomButton customButton3;
        private CustomButton customButton4;
        private CustomButton customButton5;
        private CustomButton customButton6;
        private CustomButton customButton7;
        private CustomButton customButton8;
        private CustomButton customButton9;
        private CustomButton customButton10;
        private CustomButton customButton11;
        private CustomButton customButton12;
        private CustomButton customButton13;
        private CustomButton customButton14;
        private CustomButton customButton15;
        private CustomButton customButton16;
        private CustomButton customButton17;
        private CustomButton customButton18;
        private CustomButton customButton19;
        private CustomButton customButton20;
        private CustomButton customButton21;
        private CustomButton customButton22;
        private CustomButton customButton23;
        private CustomButton customButton24;
    }
}
