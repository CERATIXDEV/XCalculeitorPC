using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form4 : Form
    {

        System.Drawing.Color colorFondoApp;
        System.Drawing.Color colorBotonNumeros;
        System.Drawing.Color colorBotonFunciones;
        System.Drawing.Color colorBotonEspecial;
        string rutaImgaenFondo = "";
        System.Drawing.Font tipoTextoTamaño;
        System.Drawing.Color colorTextoBotonNumeros;
        System.Drawing.Color colorTextoBotonFunciones;
        System.Drawing.Color colorTextoBotonEspeciales;
        float tamLetra;
        string tipoLetra;
        int opcionFondo;
        int BorderRadio;

        public Form4()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //BOTON BUSCAR IMAGEN DE FONDO
            openFileDialog1.Filter = " Imagen PNG (*.png)|*.png|Imagen JPG (*.jpg)|*.jpg|Imagen JPEG (*.jpeg)|*.jpeg |Imagen BMP (*.bmp)|*.bmp|Imagen TIFF (*.tiff)|*.tiff ";
            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                rutaImgaenFondo = openFileDialog1.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //COLOR FONDO BOTONES FUNCIONES
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button2.BackColor = colorDialog1.Color;
                colorBotonFunciones = colorDialog1.Color;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //COLOR FONDO BOTONES NUMEROS
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button3.BackColor = colorDialog1.Color;
                colorBotonNumeros = colorDialog1.Color;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //BOTON COLOR DE FONDO PANTALLA
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button5.BackColor = colorDialog1.Color;
                colorFondoApp = colorDialog1.Color;
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

            colorFondoApp = Settings.Default.ColorFondoApp;
            BorderRadio = Settings.Default.borderRadio;

            colorBotonNumeros = Settings.Default.ColorBotonNumeros; ;
            colorBotonFunciones = Settings.Default.ColorBotonFunciones; ;
            colorBotonEspecial = Settings.Default.ColorBotonEspecial; ;
            rutaImgaenFondo = Settings.Default.ImagenFondo;

            colorTextoBotonNumeros = Settings.Default.ColorTextoBotonNum; ;
            colorTextoBotonFunciones = Settings.Default.ColorTextoBotonFun; ;
            colorTextoBotonEspeciales = Settings.Default.ColorTextoBotonEsp; ;


            button5.BackColor = Settings.Default.ColorFondoApp; //COLOR DE FONDO DE LA APP

            //COLOR DE FONDO Y TEXTO BOTONES FUNCIONES
            button2.BackColor = Settings.Default.ColorBotonFunciones; //COLOR FONDO BOTON
            button7.BackColor = Settings.Default.ColorTextoBotonFun; //COLOR TEXTO

            //COLOR DE FONDO Y TEXTO BOTONES NUMEROS
            button3.BackColor = Settings.Default.ColorBotonNumeros; //COLOR FONDO BOTON
            button6.BackColor = Settings.Default.ColorTextoBotonNum; //COLOR TEXTO

            //COLOR DE FONDO Y TEXTO BOTONES ESPECIALES
            button9.BackColor = Settings.Default.ColorBotonEspecial; //COLOR FONDO BOTON
            button8.BackColor = Settings.Default.ColorTextoBotonEsp; //COLOR TEXTO

            // TAMAÑO DE LETRA
            tamLetra = Settings.Default.TipoLetraTam.Size;
            if (tamLetra == 14)
            {
                radioButton1.Checked = true;
            }
            else if (tamLetra == 18)
            {
                radioButton2.Checked = true;
            }
            else if (tamLetra == 24)
            {
                radioButton3.Checked = true;
            }
            /////////////////////////////////////////

            // TIPO DE LETRA
            tipoLetra = Settings.Default.TipoLetraTam.Name;
            comboBox1.Text = tipoLetra;
            ////////////////////////

            /// CONTROLA SI LA OPCION DE FONDO COLOR O IMAGENE STA HABILITADA
            opcionFondo = Settings.Default.OpcionFondo;
            if (opcionFondo == 1)
            {
                radioButton4.Checked = true;
                button4.Enabled = false;
            }
            else
            {
                radioButton5.Checked = true;
                button5.Enabled = false;
            }
            //////////////////////////////////////


            if (BorderRadio == 30)
            {
                radioButton6.Checked = true;
            }
            else
            {
                radioButton7.Checked = true;
            }


        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                button5.Enabled = true;
                button4.Enabled = false;
                opcionFondo = 1;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                button5.Enabled = false;
                button4.Enabled = true;
                opcionFondo = 2;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Settings.Default["ColorFondoApp"] = colorFondoApp;

            Font Letra = new Font(tipoLetra, tamLetra);
            Settings.Default["TipoLetraTam"] = Letra;

            Settings.Default["ColorBotonFunciones"] = colorBotonFunciones;
            Settings.Default["ColorTextoBotonFun"] = colorTextoBotonFunciones;

            Settings.Default["ColorBotonNumeros"] = colorBotonNumeros;
            Settings.Default["ColorTextoBotonNum"] = colorTextoBotonNumeros;

            Settings.Default["ColorBotonEspecial"] = colorBotonEspecial;
            Settings.Default["ColorTextoBotonEsp"] = colorTextoBotonEspeciales;
            Settings.Default["ImagenFondo"] = rutaImgaenFondo;

            Settings.Default["OpcionFondo"] = opcionFondo;

            Settings.Default["borderRadio"] = BorderRadio;

            Settings.Default.Save();

            //MessageBox.Show("Opciones Guardadas Satisfactoriamente","CONFIGURACION",MessageBoxButtons.OK,MessageBoxIcon.Information );
            this.Close();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) { tamLetra = radioButton1.Font.Size; }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked) { tamLetra = radioButton2.Font.Size; }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked) { tamLetra = radioButton3.Font.Size; }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipoLetra = comboBox1.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //COLOR TEXTO BOTONES FUNCIONES
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button7.BackColor = colorDialog1.Color;
                colorTextoBotonFunciones = colorDialog1.Color;
            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            //COLOR TEXTO BOTONES NUMEROS
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button6.BackColor = colorDialog1.Color;
                colorTextoBotonNumeros = colorDialog1.Color;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //COLOR FONDO BOTONES ESPECIALES
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button9.BackColor = colorDialog1.Color;
                colorBotonEspecial = colorDialog1.Color;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //COLOR TEXTO BOTONES ESPECIALES
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button8.BackColor = colorDialog1.Color;
                colorTextoBotonEspeciales = colorDialog1.Color;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                BorderRadio = 30;
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked) 
            {
                BorderRadio = 0;
            }
        }
    }
}
