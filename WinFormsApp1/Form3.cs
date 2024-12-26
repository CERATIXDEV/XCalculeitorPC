using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

using static ColorInterface.MaterialUI1;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();


        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label3.Text += " " + Application.ProductVersion;

        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
             Form2 frmLicencia = new Form2();    
             frmLicencia.ShowDialog();

        }
    }
}
