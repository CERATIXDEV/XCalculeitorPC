namespace WinFormsApp1
{
    partial class Form4
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
            label2 = new Label();
            groupBox1 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            button1 = new Button();
            groupBox2 = new GroupBox();
            button4 = new Button();
            button5 = new Button();
            radioButton5 = new RadioButton();
            radioButton4 = new RadioButton();
            button2 = new Button();
            button3 = new Button();
            colorDialog1 = new ColorDialog();
            label3 = new Label();
            button6 = new Button();
            button7 = new Button();
            label4 = new Label();
            button8 = new Button();
            button9 = new Button();
            label5 = new Label();
            comboBox1 = new ComboBox();
            label6 = new Label();
            groupBox3 = new GroupBox();
            radioButton7 = new RadioButton();
            radioButton6 = new RadioButton();
            openFileDialog1 = new OpenFileDialog();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 28);
            label1.Name = "label1";
            label1.Size = new Size(182, 21);
            label1.TabIndex = 0;
            label1.Text = "Color Botones Funciones";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 57);
            label2.Name = "label2";
            label2.Size = new Size(177, 21);
            label2.TabIndex = 1;
            label2.Text = "Color Botones Numeros";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(25, 248);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(152, 67);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tamaño Letra";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton3.Location = new Point(89, 14);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(61, 49);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "A";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton2.Location = new Point(44, 20);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(49, 36);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "A";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton1.Location = new Point(6, 24);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(43, 29);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "A";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(105, 392);
            button1.Name = "button1";
            button1.Size = new Size(144, 47);
            button1.TabIndex = 7;
            button1.Text = "APLICAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(radioButton5);
            groupBox2.Controls.Add(radioButton4);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(25, 119);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(306, 123);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Fondo Pantalla";
            // 
            // button4
            // 
            button4.Location = new Point(225, 70);
            button4.Name = "button4";
            button4.Size = new Size(59, 32);
            button4.TabIndex = 12;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(225, 31);
            button5.Name = "button5";
            button5.Size = new Size(59, 32);
            button5.TabIndex = 11;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Enabled = false;
            radioButton5.Location = new Point(17, 74);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(149, 25);
            radioButton5.TabIndex = 1;
            radioButton5.TabStop = true;
            radioButton5.Text = "Imagen de Fondo";
            radioButton5.UseVisualStyleBackColor = true;
            radioButton5.CheckedChanged += radioButton5_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(17, 35);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(135, 25);
            radioButton4.TabIndex = 0;
            radioButton4.TabStop = true;
            radioButton4.Text = "Color de Fondo";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // button2
            // 
            button2.Location = new Point(211, 25);
            button2.Name = "button2";
            button2.Size = new Size(50, 30);
            button2.TabIndex = 9;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(211, 54);
            button3.Name = "button3";
            button3.Size = new Size(50, 30);
            button3.TabIndex = 10;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(213, 11);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 11;
            label3.Text = "FONDO";
            // 
            // button6
            // 
            button6.Location = new Point(260, 54);
            button6.Name = "button6";
            button6.Size = new Size(50, 30);
            button6.TabIndex = 13;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(260, 25);
            button7.Name = "button7";
            button7.Size = new Size(50, 30);
            button7.TabIndex = 12;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(265, 11);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 14;
            label4.Text = "TEXTO";
            // 
            // button8
            // 
            button8.Location = new Point(260, 83);
            button8.Name = "button8";
            button8.Size = new Size(50, 30);
            button8.TabIndex = 17;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(211, 83);
            button9.Name = "button9";
            button9.Size = new Size(50, 30);
            button9.TabIndex = 16;
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(25, 86);
            label5.Name = "label5";
            label5.Size = new Size(182, 21);
            label5.TabIndex = 15;
            label5.Text = "Color Botones Especiales";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Arial Black", "Times New Roman", "Segoe UI" });
            comboBox1.Location = new Point(25, 339);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(306, 33);
            comboBox1.TabIndex = 18;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(25, 319);
            label6.Name = "label6";
            label6.Size = new Size(100, 21);
            label6.TabIndex = 19;
            label6.Text = "Tipo de Letra";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(radioButton7);
            groupBox3.Controls.Add(radioButton6);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(183, 248);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(146, 67);
            groupBox3.TabIndex = 22;
            groupBox3.TabStop = false;
            groupBox3.Text = "Forma Botones";
            // 
            // radioButton7
            // 
            radioButton7.Appearance = Appearance.Button;
            radioButton7.FlatStyle = FlatStyle.System;
            radioButton7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            radioButton7.Location = new Point(77, 25);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(49, 32);
            radioButton7.TabIndex = 1;
            radioButton7.TabStop = true;
            radioButton7.Text = "C";
            radioButton7.TextAlign = ContentAlignment.MiddleCenter;
            radioButton7.UseVisualStyleBackColor = true;
            radioButton7.CheckedChanged += radioButton7_CheckedChanged;
            // 
            // radioButton6
            // 
            radioButton6.Appearance = Appearance.Button;
            radioButton6.FlatStyle = FlatStyle.System;
            radioButton6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            radioButton6.Location = new Point(17, 24);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(49, 32);
            radioButton6.TabIndex = 0;
            radioButton6.TabStop = true;
            radioButton6.Text = "R";
            radioButton6.TextAlign = ContentAlignment.MiddleCenter;
            radioButton6.UseVisualStyleBackColor = true;
            radioButton6.CheckedChanged += radioButton6_CheckedChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(347, 452);
            Controls.Add(groupBox3);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(groupBox2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Configuracion";
            Load += Form4_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button button1;
        private GroupBox groupBox2;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private Button button4;
        private Button button5;
        private Button button2;
        private Button button3;
        private ColorDialog colorDialog1;
        private Label label3;
        private Button button6;
        private Button button7;
        private Label label4;
        private Button button8;
        private Button button9;
        private Label label5;
        private ComboBox comboBox1;
        private Label label6;
        private GroupBox groupBox3;
        private OpenFileDialog openFileDialog1;
        private RadioButton radioButton6;
        private CustomButton customButton1;
        private Button button10;
        private RadioButton radioButton7;
    }
}