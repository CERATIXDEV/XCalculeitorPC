using Microsoft.VisualBasic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.Runtime.InteropServices.Marshalling;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string Numero1 = "";
        string Numero2 = "";
        string Operador = "";
        bool control = false;
        bool xRes = false;
        string numReal = "0";
        NumberFormatInfo nfi;
        System.Drawing.Font estiloTexto;
        public Form1()
        {
            InitializeComponent();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            

            this.Text += " 1.0.0 "; // + Application.ProductVersion;

            customButton21.Focus(); //Boton Igual

            nfi = new CultureInfo("es-CO", false).NumberFormat;
            nfi.NumberDecimalSeparator = ",";

            //ESTILO TEXTO DE LOS NUMEROS
            estiloTexto = Settings.Default.TipoLetraTam;

            // FONDO DE LA APP
            int OpFondo = Settings.Default.OpcionFondo;
            if (OpFondo == 1)
            {
                this.BackColor = Settings.Default.ColorFondoApp; //COLOR DE FONDO DE LA APP

            }
            else
            {
                string ruta = Settings.Default.ImagenFondo;
                if (File.Exists(ruta) == true)
                {
                    this.BackgroundImage = Image.FromFile(ruta); // CARGA IMAGEN DE FONDO PARA LA APP
                    this.BackgroundImageLayout = ImageLayout.Stretch;
                    
                }
                else
                {
                    //SI EL ARCHIVO DE IMAGEN NO EXISTE CARGA EL COLOR DE FONDO POR DEFECTO
                    this.BackColor = Settings.Default.ColorFondoApp; //COLOR DE FONDO DE LA APP
                }

            }
            /////////////////////////

            //BOTONES DE FUNCIONES
            System.Drawing.Color Cboton = Settings.Default.ColorBotonFunciones;
            System.Drawing.Color CTboton = Settings.Default.ColorTextoBotonFun;

            customButton5.BackColor = Cboton;
            customButton6.BackColor = Cboton;
            customButton7.BackColor = Cboton;
            customButton8.BackColor = Cboton;
            customButton12.BackColor = Cboton;
            customButton16.BackColor = Cboton;
            customButton20.BackColor = Cboton;
            customButton24.BackColor = Cboton;
            customButton21.BackColor = Cboton;

            customButton5.ForeColor = CTboton;
            customButton6.ForeColor = CTboton;
            customButton7.ForeColor = CTboton;
            customButton8.ForeColor = CTboton;
            customButton12.ForeColor = CTboton;
            customButton16.ForeColor = CTboton;
            customButton20.ForeColor = CTboton;
            customButton24.ForeColor = CTboton;
            customButton21.ForeColor = CTboton;

            customButton5.BorderRadius = Settings.Default.borderRadio;
            customButton6.BorderRadius = Settings.Default.borderRadio;
            customButton7.BorderRadius = Settings.Default.borderRadio;
            customButton8.BorderRadius = Settings.Default.borderRadio;
            customButton12.BorderRadius = Settings.Default.borderRadio;
            customButton16.BorderRadius = Settings.Default.borderRadio;
            customButton20.BorderRadius = Settings.Default.borderRadio;
            customButton24.BorderRadius = Settings.Default.borderRadio;
            customButton21.BorderRadius = Settings.Default.borderRadio;

            ///////////////////////////////////

            //BOTONES NUMEROS
            System.Drawing.Color CbotonN = Settings.Default.ColorBotonNumeros;
            System.Drawing.Color CTbotonN = Settings.Default.ColorTextoBotonNum;

            customButton9.BackColor = CbotonN;
            customButton10.BackColor = CbotonN;
            customButton11.BackColor = CbotonN;
            customButton13.BackColor = CbotonN;
            customButton14.BackColor = CbotonN;
            customButton15.BackColor = CbotonN;
            customButton17.BackColor = CbotonN;
            customButton18.BackColor = CbotonN;
            customButton19.BackColor = CbotonN;
            customButton22.BackColor = CbotonN;
            customButton23.BackColor = CbotonN;

            customButton9.ForeColor = CTbotonN;
            customButton10.ForeColor = CTbotonN;
            customButton11.ForeColor = CTbotonN;
            customButton13.ForeColor = CTbotonN;
            customButton14.ForeColor = CTbotonN;
            customButton15.ForeColor = CTbotonN;
            customButton17.ForeColor = CTbotonN;
            customButton18.ForeColor = CTbotonN;
            customButton19.ForeColor = CTbotonN;
            customButton22.ForeColor = CTbotonN;
            customButton23.ForeColor = CTbotonN;

            customButton9.Font = estiloTexto;
            customButton10.Font = estiloTexto;
            customButton11.Font = estiloTexto;
            customButton13.Font = estiloTexto;
            customButton14.Font = estiloTexto;
            customButton15.Font = estiloTexto;
            customButton17.Font = estiloTexto;
            customButton18.Font = estiloTexto;
            customButton19.Font = estiloTexto;
            customButton22.Font = estiloTexto;
            customButton23.Font = estiloTexto;

            customButton9.BorderRadius = Settings.Default.borderRadio;
            customButton10.BorderRadius = Settings.Default.borderRadio;
            customButton11.BorderRadius = Settings.Default.borderRadio;
            customButton13.BorderRadius = Settings.Default.borderRadio;
            customButton14.BorderRadius = Settings.Default.borderRadio;
            customButton15.BorderRadius = Settings.Default.borderRadio;
            customButton17.BorderRadius = Settings.Default.borderRadio;
            customButton18.BorderRadius = Settings.Default.borderRadio;
            customButton19.BorderRadius = Settings.Default.borderRadio;
            customButton22.BorderRadius = Settings.Default.borderRadio;
            customButton23.BorderRadius = Settings.Default.borderRadio;

            //////////////////////////////// 

            //BOTONES ESPECIALES
            System.Drawing.Color CbotonE = Settings.Default.ColorBotonEspecial;
            System.Drawing.Color CTbotonE = Settings.Default.ColorTextoBotonEsp;

            customButton1.BackColor = CbotonE;
            customButton2.BackColor = CbotonE;
            customButton3.BackColor = CbotonE;
            customButton4.BackColor = CbotonE;

            customButton1.ForeColor = CTbotonE;
            customButton2.ForeColor = CTbotonE;
            customButton3.ForeColor = CTbotonE;
            customButton4.ForeColor = CTbotonE;

            customButton1.BorderRadius = Settings.Default.borderRadio;
            customButton2.BorderRadius = Settings.Default.borderRadio;
            customButton3.BorderRadius = Settings.Default.borderRadio;
            customButton4.BorderRadius = Settings.Default.borderRadio;

        }

        public string Digito(string texto, string tecla)
        {

            if (xRes == true)
            {
                label1.Text = "";
                texto = "";
                Numero1 = "";
                Numero2 = "";
                Operador = "";
                numReal = "0";
                xRes = false;
            }

            if (numReal == "0" && tecla == ",")
            {
                numReal = "0";
            }
            else
            {
                if (numReal == "0" && tecla != ",")
                {
                    numReal = "";
                }

            }

            if (Operador != "" && control == true)
            {
                numReal = "";
                control = false;
            }

            switch (tecla)
            {
                case "0":
                    numReal += "0";
                    break;

                case "1":
                    numReal += "1";
                    break;

                case "2":
                    numReal += "2";
                    break;

                case "3":
                    numReal += "3";
                    break;

                case "4":
                    numReal += "4";
                    break;

                case "5":
                    numReal += "5";
                    break;

                case "6":
                    numReal += "6";
                    break;

                case "7":
                    numReal += "7";
                    break;

                case "8":
                    numReal += "8";
                    break;

                case "9":
                    numReal += "9";
                    break;

                case ",":
                    numReal += ",";
                    break;

            }



            string cadena = numReal;
            int canDecimales = 0;

            if (cadena.Contains(","))
            {
                int longCadena = cadena.Length;
                int posicion = cadena.IndexOf(',');
                canDecimales = longCadena - (posicion + 1);
            }

            customButton21.Focus();

            double numero = Convert.ToDouble(numReal);
            string decimales = "N" + canDecimales.ToString();

            if (tecla == ",")
            {
                return (numero.ToString(decimales, nfi) + ",");
            }
            else
            {
                return (numero.ToString(decimales, nfi));
            }

        }


        public string Resultado(double Num1, double Num2, string ope)
        {
            double Res = 0;

            switch (ope)
            {
                case "+":
                    Res = Num1 + Num2;
                    break;

                case "-":
                    Res = Num1 - Num2;
                    break;

                case "/":

                    Res = Num1 / Num2;

                    break;

                case "*":
                    Res = Num1 * Num2;
                    break;

                case "xʸ":

                    Res = Math.Pow(Num1, Num2);

                    break;
            }

            xRes = true;
            string cadena = Res.ToString();
            int canDecimales = 0;

            if (cadena.Contains(","))
            {
                int longCadena = cadena.Length;
                int posicion = cadena.IndexOf(',');
                canDecimales = longCadena - (posicion + 1);

            }
            return Res.ToString("N" + canDecimales, nfi);

        }


        ////////////////////////////////////
        private void Operacion(string Boton)
        {
            if (Operador == "" && control == false || control == true)
            {

                Operador = Boton;
                control = true;
                xRes = false;

                Numero1 = label2.Text;

                if (Numero1.Contains(','))
                {
                    int posocion = Numero1.IndexOf(",");
                    if (posocion == (Numero1.Length - 1))
                    {
                        string cadena = "";
                        for (int i = 0; i < Numero1.Length - 1; i++)
                        {
                            cadena += Numero1[i];
                        }
                        Numero1 = cadena;
                        label1.Text = Numero1 + " " + Operador;
                    }
                    else
                    {
                        label1.Text = Numero1 + " " + Operador;
                    }
                }
                else
                {

                    label1.Text = Numero1 + " " + Operador;

                }


            }
            else if (Operador != Boton && control == true)
            {
                //CAMBIAR LE TIPO DE OPERACION QUE SE VA A REALIZAR
                Operador = Boton;
                string cadena = label1.Text;
                int largoCad = cadena.Length;
                string newCadena = "";


                if (cadena.Contains("x"))
                {
                    largoCad = largoCad - 2;
                }
                else
                {
                    largoCad--;
                }

                for (int i = 0; i < largoCad; i++)
                {
                    newCadena += cadena[i];
                }
                label1.Text = newCadena + Operador;
            }
            else if (Operador == Boton && control == false)
            {
                //REALIZA LA OPERACION SI EL OPERADOR COINCIDE CON EL GUARDADO Y SI YA SE DIGITO EL SEGUNDO VALOR
                if (Operador == "/" && label2.Text == "0")
                {
                    MessageBox.Show("NO SE PPUEDE DIVIDIR POR CERO");
                }
                else
                {
                    Numero2 = label2.Text;

                    if (Numero2.Contains(','))
                    {
                        int posocion = Numero2.IndexOf(",");
                        if (posocion == (Numero2.Length - 1))
                        {
                            string cadena = "";
                            for (int i = 0; i < Numero2.Length - 1; i++)
                            {
                                cadena += Numero2[i];
                            }
                            Numero2 = cadena;
                            label1.Text += " " + Numero2 + " =";
                        }
                        else
                        {
                            label1.Text += " " + Numero2 + " =";
                        }
                    }
                    else
                    {

                        label1.Text += " " + Numero2 + " =";

                    }

                    label2.Text = Resultado(Convert.ToDouble(Numero1), Convert.ToDouble(Numero2), Operador);
                    Operador = "";
                }

            }
            else if (Operador != Boton && control == false)
            {
                if (Operador == "/" && label2.Text == "0")
                {
                    MessageBox.Show("NO SE PPUEDE DIVIDIR POR CERO");
                }
                else
                {
                    Numero2 = label2.Text;
                    label1.Text += " " + Numero2 + " =";

                    label2.Text = Resultado(Convert.ToDouble(Numero1), Convert.ToDouble(Numero2), Operador);
                    Operador = Boton;
                    Numero1 = label2.Text;
                    control = true;
                    xRes = false;
                    label1.Text = label2.Text + " " + Operador;
                }
            }

            customButton21.Focus();
        }

    

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //BOTON SALIR
            Application.Exit();
        }

        private void configuracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 frmConfiguracion = new Form4();
            frmConfiguracion.ShowDialog();
        }


        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {


            int codigo = (int)e.KeyChar;

            switch (codigo)
            {
                case 46:
                    //COMA
                    customButton23_Click(sender, e);
                    break;

                case 48:
                    //NUMERO CERO
                    customButton22_Click(sender, e);
                    break;

                case 49:
                    //NUMERO 1
                    customButton17_Click(sender, e);
                    break;

                case 50:
                    //NUMERO 2
                    customButton18_Click(sender, e);
                    break;

                case 51:
                    //NUMERO 3
                    customButton19_Click(sender, e);
                    break;

                case 52:
                    //NUMERO 4
                    customButton13_Click(sender, e);
                    break;

                case 53:
                    //NUMERO 5
                    customButton14_Click(sender, e);
                    break;

                case 54:
                    //NUMERO 6
                    customButton15_Click(sender, e);
                    break;

                case 55:
                    //NUMERO 7
                    customButton9_Click(sender, e);
                    break;

                case 56:
                    //NUMERO 8
                    customButton10_Click(sender, e);
                    break;

                case 57:
                    //NUMERO 9
                    customButton11_Click(sender, e);
                    break;

                case 47:
                    //BOTON DIVISION
                    customButton20_Click(sender, e);
                    break;

                case 45:
                    //BOTON RESTA
                    customButton16_Click(sender, e);
                    break;

                case 43:
                    //BOTON SUMA
                    customButton12_Click(sender, e);
                    break;

                case 42:
                    //BOTON MULTIPLICACION
                    customButton24_Click(sender, e);
                    break;

                case 8:
                    //BOTON BORRAR DIGITO
                    customButton8_Click(sender, e);
                    break;

                case 13:
                    //BOTON IGUAL
                    customButton21_Click(sender, e);
                    break;

            }
        }


        private void Form1_Activated(object sender, EventArgs e)
        {
            //ESTILO TEXTO DE LOS NUMEROS
            estiloTexto = Settings.Default.TipoLetraTam;

            // FONDO DE LA APP
            int OpFondo = Settings.Default.OpcionFondo;
            if (OpFondo == 1)
            {
                this.BackColor = Settings.Default.ColorFondoApp; //COLOR DE FONDO DE LA APP

            }
            else
            {

                if (File.Exists(Settings.Default.ImagenFondo))
                {
                    this.BackgroundImage = Image.FromFile(Settings.Default.ImagenFondo); // CARGA IMAGEN DE FONDO PARA LA APP
                    this.BackgroundImageLayout = ImageLayout.Stretch;
                    customButton5.BackColor = Color.Transparent;
                }
                else
                {
                    //SI EL ARCHIVO DE IMAGEN NO EXISTE CARGA EL COLOR DE FONDO POR DEFECTO
                    this.BackColor = Settings.Default.ColorFondoApp; //COLOR DE FONDO DE LA APP
                }

            }
            /////////////////////////

            //BOTONES DE FUNCIONES
            System.Drawing.Color Cboton = Settings.Default.ColorBotonFunciones;
            System.Drawing.Color CTboton = Settings.Default.ColorTextoBotonFun;

            customButton5.BackColor = Cboton;
            customButton6.BackColor = Cboton;
            customButton7.BackColor = Cboton;
            customButton8.BackColor = Cboton;
            customButton12.BackColor = Cboton;
            customButton16.BackColor = Cboton;
            customButton20.BackColor = Cboton;
            customButton24.BackColor = Cboton;
            customButton21.BackColor = Cboton;

            customButton5.ForeColor = CTboton;
            customButton6.ForeColor = CTboton;
            customButton7.ForeColor = CTboton;
            customButton8.ForeColor = CTboton;
            customButton12.ForeColor = CTboton;
            customButton16.ForeColor = CTboton;
            customButton20.ForeColor = CTboton;
            customButton24.ForeColor = CTboton;
            customButton21.ForeColor = CTboton;

            customButton5.BorderRadius = Settings.Default.borderRadio;
            customButton6.BorderRadius = Settings.Default.borderRadio;
            customButton7.BorderRadius = Settings.Default.borderRadio;
            customButton8.BorderRadius = Settings.Default.borderRadio;
            customButton12.BorderRadius = Settings.Default.borderRadio;
            customButton16.BorderRadius = Settings.Default.borderRadio;
            customButton20.BorderRadius = Settings.Default.borderRadio;
            customButton24.BorderRadius = Settings.Default.borderRadio;
            customButton21.BorderRadius = Settings.Default.borderRadio;

            ///////////////////////////////////

            //BOTONES NUMEROS
            System.Drawing.Color CbotonN = Settings.Default.ColorBotonNumeros;
            System.Drawing.Color CTbotonN = Settings.Default.ColorTextoBotonNum;

            customButton9.BackColor = CbotonN;
            customButton10.BackColor = CbotonN;
            customButton11.BackColor = CbotonN;
            customButton13.BackColor = CbotonN;
            customButton14.BackColor = CbotonN;
            customButton15.BackColor = CbotonN;
            customButton17.BackColor = CbotonN;
            customButton18.BackColor = CbotonN;
            customButton19.BackColor = CbotonN;
            customButton22.BackColor = CbotonN;
            customButton23.BackColor = CbotonN;

            customButton9.ForeColor = CTbotonN;
            customButton10.ForeColor = CTbotonN;
            customButton11.ForeColor = CTbotonN;
            customButton13.ForeColor = CTbotonN;
            customButton14.ForeColor = CTbotonN;
            customButton15.ForeColor = CTbotonN;
            customButton17.ForeColor = CTbotonN;
            customButton18.ForeColor = CTbotonN;
            customButton19.ForeColor = CTbotonN;
            customButton22.ForeColor = CTbotonN;
            customButton23.ForeColor = CTbotonN;

            customButton9.Font = estiloTexto;
            customButton10.Font = estiloTexto;
            customButton11.Font = estiloTexto;
            customButton13.Font = estiloTexto;
            customButton14.Font = estiloTexto;
            customButton15.Font = estiloTexto;
            customButton17.Font = estiloTexto;
            customButton18.Font = estiloTexto;
            customButton19.Font = estiloTexto;
            customButton22.Font = estiloTexto;
            customButton23.Font = estiloTexto;

            customButton9.BorderRadius = Settings.Default.borderRadio;
            customButton10.BorderRadius = Settings.Default.borderRadio;
            customButton11.BorderRadius = Settings.Default.borderRadio;
            customButton13.BorderRadius = Settings.Default.borderRadio;
            customButton14.BorderRadius = Settings.Default.borderRadio;
            customButton15.BorderRadius = Settings.Default.borderRadio;
            customButton17.BorderRadius = Settings.Default.borderRadio;
            customButton18.BorderRadius = Settings.Default.borderRadio;
            customButton19.BorderRadius = Settings.Default.borderRadio;
            customButton22.BorderRadius = Settings.Default.borderRadio;
            customButton23.BorderRadius = Settings.Default.borderRadio;

            //////////////////////////////// 

            //BOTONES ESPECIALES
            System.Drawing.Color CbotonE = Settings.Default.ColorBotonEspecial;
            System.Drawing.Color CTbotonE = Settings.Default.ColorTextoBotonEsp;

            customButton1.BackColor = CbotonE;
            customButton2.BackColor = CbotonE;
            customButton3.BackColor = CbotonE;
            customButton4.BackColor = CbotonE;

            customButton1.ForeColor = CTbotonE;
            customButton2.ForeColor = CTbotonE;
            customButton3.ForeColor = CTbotonE;
            customButton4.ForeColor = CTbotonE;

            customButton1.BorderRadius = Settings.Default.borderRadio;
            customButton2.BorderRadius = Settings.Default.borderRadio;
            customButton3.BorderRadius = Settings.Default.borderRadio;
            customButton4.BorderRadius = Settings.Default.borderRadio;

            this.Refresh();

        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frmAcerca = new Form3();
            frmAcerca.ShowDialog();
        }

        private void customButton9_Click(object sender, EventArgs e)
        {
            label2.Text = Digito(numReal, customButton9.Text);
        }

        private void customButton10_Click(object sender, EventArgs e)
        {
            label2.Text = Digito(numReal, customButton10.Text);
        }

        private void customButton11_Click(object sender, EventArgs e)
        {
            label2.Text = Digito(numReal, customButton11.Text);
        }

        private void customButton13_Click(object sender, EventArgs e)
        {
            label2.Text = Digito(numReal, customButton13.Text);
        }

        private void customButton14_Click(object sender, EventArgs e)
        {
            label2.Text = Digito(numReal, customButton14.Text);
        }

        private void customButton15_Click(object sender, EventArgs e)
        {
            label2.Text = Digito(numReal, customButton15.Text);
        }

        private void customButton17_Click(object sender, EventArgs e)
        {
            label2.Text = Digito(numReal, customButton17.Text);
        }

        private void customButton18_Click(object sender, EventArgs e)
        {
            label2.Text = Digito(numReal, customButton18.Text);
        }

        private void customButton19_Click(object sender, EventArgs e)
        {
            label2.Text = Digito(numReal, customButton19.Text);
        }

        private void customButton22_Click(object sender, EventArgs e)
        {
            label2.Text = Digito(numReal, customButton22.Text);
        }

        private void customButton23_Click(object sender, EventArgs e)
        {
            if (!label2.Text.Contains(","))
            {
                label2.Text = Digito(numReal, customButton23.Text);
            }


        }

        private void customButton5_Click(object sender, EventArgs e)
        {
            //BOTON BORRAR TODO
            label2.Text = "0";
            label1.Text = "";
            Numero1 = "";
            Operador = "";
            numReal = "0";
            xRes = false;
        }

        private void customButton8_Click(object sender, EventArgs e)
        {
            //BOTONTO BORRAR DIGITOS
            string cadena = numReal;
            int largoCad = cadena.Length;
            string newCadena = "";
            if (largoCad > 0)
            {
                largoCad--;
                for (int i = 0; i < largoCad; i++)
                {
                    newCadena += cadena[i];
                }

                numReal = newCadena;

                if (numReal.Length == 0)
                {
                    numReal = "0";
                    label2.Text = numReal;
                }
                else
                {


                    int canDecimales = 0;

                    if (numReal.Contains(","))
                    {
                        int longCadena = numReal.Length;
                        int posicion = numReal.IndexOf(',');
                        canDecimales = longCadena - (posicion + 1);

                        if (canDecimales > 0)
                        {
                            double numero = Convert.ToDouble(numReal);
                            label2.Text = numero.ToString("N" + canDecimales, nfi);

                        }
                        else
                        {
                            label2.Text = numReal;
                        }

                    }
                    else
                    {
                        double numero = Convert.ToDouble(numReal);
                        label2.Text = numero.ToString("N" + canDecimales, nfi);
                    }


                }

            }
        }

        private void customButton12_Click(object sender, EventArgs e)
        {
            //SUMA
            Operacion(customButton12.Text);
        }

        private void customButton16_Click(object sender, EventArgs e)
        {
            //RESTA
            Operacion(customButton16.Text);
        }

        private void customButton20_Click(object sender, EventArgs e)
        {
            //DIVISION
            Operacion(customButton20.Text);
        }

        private void customButton24_Click(object sender, EventArgs e)
        {
            //MULTIPLICACION
            Operacion(customButton24.Text);
        }

        private void customButton21_Click(object sender, EventArgs e)
        {
            if (xRes == false)
            {
                if (Operador == "/" && label2.Text == "0")
                {
                    MessageBox.Show("NO SE PPUEDE DIVIDIR POR CERO");
                }
                else if (Numero1 != "")
                {

                    Numero2 = label2.Text;


                    if (Numero2.Contains(','))
                    {
                        int posocion = Numero2.IndexOf(",");
                        if (posocion == (Numero2.Length - 1))
                        {
                            string cadena = "";
                            for (int i = 0; i < Numero2.Length - 1; i++)
                            {
                                cadena += Numero2[i];
                            }
                            Numero2 = cadena;
                            label1.Text += " " + Numero2 + " =";
                        }
                        else
                        {
                            label1.Text += " " + Numero2 + " =";
                        }
                    }
                    else
                    {

                        label1.Text += " " + Numero2 + " =";

                    }
                    label2.Text = Resultado(Convert.ToDouble(Numero1), Convert.ToDouble(Numero2), Operador);
                    Operador = "";
                    xRes = true;
                }
            }
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            //BOTON SENO
            double numValor = Convert.ToDouble(label2.Text);
            double resSeno = 0;

            resSeno = Math.Sin(numValor);
            label1.Text = "Seno³ de " + numValor + " =";
            label2.Text = Convert.ToString(resSeno);
            Operador = "";
            xRes = true;
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            //BOTON COSENO
            double numValor = Convert.ToDouble(label2.Text);
            double resSeno = 0;

            resSeno = Math.Cos(numValor);
            label1.Text = "Coseno³ de " + numValor + " =";
            label2.Text = Convert.ToString(resSeno);
            Operador = "";
            xRes = true;
        }

        private void customButton3_Click(object sender, EventArgs e)
        {
            //BOTON TANGENTE
            double numValor = Convert.ToDouble(label2.Text);
            double resSeno = 0;

            resSeno = Math.Tan(numValor);
            label1.Text = "Tangente³ de " + numValor + " =";
            label2.Text = Convert.ToString(resSeno);
            Operador = "";
            xRes = true;
        }

        private void customButton4_Click(object sender, EventArgs e)
        {
            //BOTON RAIZ CUBICA
            double valor = Convert.ToDouble(label2.Text);
            double resulsqr = Math.Cbrt(valor);
            label1.Text = "Raiz³ de " + valor + " =";
            label2.Text = Convert.ToString(resulsqr);
            Operador = "";
            xRes = true;
        }

        private void customButton6_Click(object sender, EventArgs e)
        {
            //RAIZ CUADRADA
            double valor = Convert.ToDouble(label2.Text);
            double resulsqr = Math.Sqrt(valor);
            label1.Text = "Raiz² de " + valor + " =";
            label2.Text = Convert.ToString(resulsqr);
            Operador = "";
            xRes = true;
        }

        private void customButton7_Click(object sender, EventArgs e)
        {
            //BOTON POTENCIA
            Operacion(customButton7.Text);
        }
    }
}
