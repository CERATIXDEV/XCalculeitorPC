using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using ColorInterface;
using MaterialSkin;
using MaterialSkin.Controls;

namespace WinFormsApp1
{

    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();


        }

        private void Form2_Load(object sender, EventArgs e)
        {

            CargarLicencia();
            customButton1.Focus();
        }

        private void CargarLicencia()
        {

            try
            {
                string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "LICENCIA_GPL.txt");

                if (File.Exists(rutaArchivo))
                {
                    //MessageBox.Show("EXISTE");
                    string texto = File.ReadAllText(rutaArchivo);
                    textBox1.Text = texto;
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("NO EXISTE: " + EX.ToString);
            }


        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
