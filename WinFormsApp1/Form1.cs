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

            this.Text += " " + Application.ProductVersion;

            button18.Focus();
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

                if (File.Exists(Settings.Default.ImagenFondo))
                {
                    this.BackgroundImage = Image.FromFile(Settings.Default.ImagenFondo); // CARGA IMAGEN DE FONDO PARA LA APP
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

            button11.BackColor = Cboton;
            button12.BackColor = Cboton;
            button13.BackColor = Cboton;
            button23.BackColor = Cboton;
            button14.BackColor = Cboton;
            button15.BackColor = Cboton;
            button16.BackColor = Cboton;
            button17.BackColor = Cboton;
            button18.BackColor = Cboton;

            button11.ForeColor = CTboton;
            button12.ForeColor = CTboton;
            button13.ForeColor = CTboton;
            button14.ForeColor = CTboton;
            button15.ForeColor = CTboton;
            button16.ForeColor = CTboton;
            button17.ForeColor = CTboton;
            button18.ForeColor = CTboton;
            button23.ForeColor = CTboton;
            ///////////////////////////////////
            ///


            //BOTONES NUMEROS
            System.Drawing.Color CbotonN = Settings.Default.ColorBotonNumeros;
            System.Drawing.Color CTbotonN = Settings.Default.ColorTextoBotonNum;

            button1.BackColor = CbotonN;
            button2.BackColor = CbotonN;
            button3.BackColor = CbotonN;
            button4.BackColor = CbotonN;
            button5.BackColor = CbotonN;
            button6.BackColor = CbotonN;
            button7.BackColor = CbotonN;
            button8.BackColor = CbotonN;
            button9.BackColor = CbotonN;
            button10.BackColor = CbotonN;
            button19.BackColor = CbotonN;

            button1.ForeColor = CTbotonN;
            button2.ForeColor = CTbotonN;
            button3.ForeColor = CTbotonN;
            button4.ForeColor = CTbotonN;
            button5.ForeColor = CTbotonN;
            button6.ForeColor = CTbotonN;
            button7.ForeColor = CTbotonN;
            button8.ForeColor = CTbotonN;
            button9.ForeColor = CTbotonN;
            button10.ForeColor = CTbotonN;
            button19.ForeColor = CTbotonN;

            button1.Font = estiloTexto;
            button2.Font = estiloTexto;
            button3.Font = estiloTexto;
            button4.Font = estiloTexto;
            button5.Font = estiloTexto;
            button6.Font = estiloTexto;
            button7.Font = estiloTexto;
            button8.Font = estiloTexto;
            button9.Font = estiloTexto;
            button10.Font = estiloTexto;
            button19.Font = estiloTexto;

            //////////////////////////////// 
            ///

            //BOTONES ESPECIALES
            System.Drawing.Color CbotonE = Settings.Default.ColorBotonEspecial;
            System.Drawing.Color CTbotonE = Settings.Default.ColorTextoBotonEsp;

            button22.BackColor = CbotonE;
            button25.BackColor = CbotonE;
            button26.BackColor = CbotonE;
            button27.BackColor = CbotonE;

            button22.ForeColor = CTbotonE;
            button25.ForeColor = CTbotonE;
            button26.ForeColor = CTbotonE;
            button27.ForeColor = CTbotonE;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            label2.Text = Digito(label2.Text, button1.Text);

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

            button18.Focus();

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

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = Digito(numReal, button2.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label2.Text = Digito(numReal, button6.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label2.Text = Digito(numReal, button7.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label2.Text = Digito(numReal, button5.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = Digito(numReal, button4.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label2.Text = Digito(numReal, button9.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label2.Text = Digito(numReal, button8.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label2.Text = Digito(numReal, button10.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = Digito(numReal, button3.Text);
        }

        private void button19_Click(object sender, EventArgs e)
        {

            if (!label2.Text.Contains(","))
            {
                label2.Text = Digito(numReal, button19.Text);
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {
            //BOTON BORRAR TODO
            label2.Text = "0";
            label1.Text = "";
            Numero1 = "";
            Operador = "";
            numReal = "0";
            xRes = false;
        }

        private void button12_Click(object sender, EventArgs e)
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

        private void button14_Click(object sender, EventArgs e)
        {
            //BOTON SUMAR
            Operacion(button14.Text);

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

        private void button15_Click(object sender, EventArgs e)
        {
            //BOTON RESTAR
            Operacion(button15.Text);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //BOTON DIVIDIR
            Operacion(button16.Text);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //BOTON MULTIPLICAR
            Operacion(button17.Text);
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

            button18.Focus();
        }

        private void button18_Click(object sender, EventArgs e)
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

        private void button11_Click(object sender, EventArgs e)
        {
            //BOTON POTENCIA
            Operacion(button11.Text);
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

        private void button23_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(label2.Text);
            double resulsqr = Math.Sqrt(valor);
            label1.Text = "Raiz² de " + valor + " =";
            label2.Text = Convert.ToString(resulsqr);
            Operador = "";
            xRes = true;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {


            int codigo = (int)e.KeyChar;

            switch (codigo)
            {
                case 46:
                    button19_Click(sender, e);
                    break;

                case 48:
                    button3_Click(sender, e);
                    break;

                case 49:
                    button1_Click(sender, e);
                    break;

                case 50:
                    button2_Click(sender, e);
                    break;

                case 51:
                    button6_Click(sender, e);
                    break;

                case 52:
                    button7_Click(sender, e);
                    break;

                case 53:
                    button5_Click(sender, e);
                    break;

                case 54:
                    button4_Click(sender, e);
                    break;

                case 55:
                    button9_Click(sender, e);
                    break;

                case 56:
                    button8_Click(sender, e);
                    break;

                case 57:
                    button10_Click(sender, e);
                    break;

                case 47:
                    button16_Click(sender, e);
                    break;

                case 45:
                    button15_Click(sender, e);
                    break;

                case 43:
                    button14_Click(sender, e);
                    break;

                case 42:
                    button17_Click(sender, e);
                    break;

                case 8:
                    button12_Click(sender, e);
                    break;

                case 13:
                    button18_Click(sender, e);
                    break;

            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {



        }

        private void button9_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void button9_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(label2.Text);
            double resulsqr = Math.Cbrt(valor);
            label1.Text = "Raiz³ de " + valor + " =";
            label2.Text = Convert.ToString(resulsqr);
            Operador = "";
            xRes = true;
        }

        private void button27_Click(object sender, EventArgs e)
        {

            double numValor = Convert.ToDouble(label2.Text);
            double resSeno = 0;

            resSeno = Math.Sin(numValor);
            label1.Text = "Seno³ de " + numValor + " =";
            label2.Text = Convert.ToString(resSeno);
            Operador = "";
            xRes = true;


        }

        private void button26_Click(object sender, EventArgs e)
        {
            double numValor = Convert.ToDouble(label2.Text);
            double resSeno = 0;

            resSeno = Math.Cos(numValor);
            label1.Text = "Coseno³ de " + numValor + " =";
            label2.Text = Convert.ToString(resSeno);
            Operador = "";
            xRes = true;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            double numValor = Convert.ToDouble(label2.Text);
            double resSeno = 0;

            resSeno = Math.Tan(numValor);
            label1.Text = "Tangente³ de " + numValor + " =";
            label2.Text = Convert.ToString(resSeno);
            Operador = "";
            xRes = true;
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

            button11.BackColor = Cboton;
            button12.BackColor = Cboton;
            button13.BackColor = Cboton;
            button23.BackColor = Cboton;
            button14.BackColor = Cboton;
            button15.BackColor = Cboton;
            button16.BackColor = Cboton;
            button17.BackColor = Cboton;
            button18.BackColor = Cboton;

            button11.ForeColor = CTboton;
            button12.ForeColor = CTboton;
            button13.ForeColor = CTboton;
            button14.ForeColor = CTboton;
            button15.ForeColor = CTboton;
            button16.ForeColor = CTboton;
            button17.ForeColor = CTboton;
            button18.ForeColor = CTboton;
            button23.ForeColor = CTboton;
            ///////////////////////////////////
            ///


            //BOTONES NUMEROS
            System.Drawing.Color CbotonN = Settings.Default.ColorBotonNumeros;
            System.Drawing.Color CTbotonN = Settings.Default.ColorTextoBotonNum;

            button1.BackColor = CbotonN;
            button2.BackColor = CbotonN;
            button3.BackColor = CbotonN;
            button4.BackColor = CbotonN;
            button5.BackColor = CbotonN;
            button6.BackColor = CbotonN;
            button7.BackColor = CbotonN;
            button8.BackColor = CbotonN;
            button9.BackColor = CbotonN;
            button10.BackColor = CbotonN;
            button19.BackColor = CbotonN;

            button1.ForeColor = CTbotonN;
            button2.ForeColor = CTbotonN;
            button3.ForeColor = CTbotonN;
            button4.ForeColor = CTbotonN;
            button5.ForeColor = CTbotonN;
            button6.ForeColor = CTbotonN;
            button7.ForeColor = CTbotonN;
            button8.ForeColor = CTbotonN;
            button9.ForeColor = CTbotonN;
            button10.ForeColor = CTbotonN;
            button19.ForeColor = CTbotonN;

            button1.Font = estiloTexto;
            button2.Font = estiloTexto;
            button3.Font = estiloTexto;
            button4.Font = estiloTexto;
            button5.Font = estiloTexto;
            button6.Font = estiloTexto;
            button7.Font = estiloTexto;
            button8.Font = estiloTexto;
            button9.Font = estiloTexto;
            button10.Font = estiloTexto;
            button19.Font = estiloTexto;

            //////////////////////////////// 
            ///

            //BOTONES ESPECIALES
            System.Drawing.Color CbotonE = Settings.Default.ColorBotonEspecial;
            System.Drawing.Color CTbotonE = Settings.Default.ColorTextoBotonEsp;

            button22.BackColor = CbotonE;
            button25.BackColor = CbotonE;
            button26.BackColor = CbotonE;
            button27.BackColor = CbotonE;

            button22.ForeColor = CTbotonE;
            button25.ForeColor = CTbotonE;
            button26.ForeColor = CTbotonE;
            button27.ForeColor = CTbotonE;


        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frmAcerca = new Form3();
            frmAcerca.ShowDialog();
        }
    }
}
