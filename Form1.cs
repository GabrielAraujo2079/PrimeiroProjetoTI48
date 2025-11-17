using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double n1 = 0;
        double n2 = 0;
        string operador = "";
        bool operadorPressionado = false;

        private void AdicionarDigito(string digito)
        {
            if (!operadorPressionado)
            {
               
                if (coluna1.Text == "0" || coluna1.Text == "")
                    coluna1.Text = digito;
                else
                    coluna1.Text += digito;
            }
            else
            {
               
                if (coluna2.Text == "0" || coluna2.Text == "")
                    coluna2.Text = digito;
                else
                    coluna2.Text += digito;
            }
        }

        private void Um_Click(object sender, EventArgs e)
        {
            AdicionarDigito("1");
        }

        private void Dois_Click(object sender, EventArgs e)
        {
            AdicionarDigito("2");
        }

        private void tres_Click(object sender, EventArgs e)
        {
            AdicionarDigito("3");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdicionarDigito("4");
        }

        private void Cinco_Click(object sender, EventArgs e)
        {
            AdicionarDigito("5");
        }

        private void Seis_Click(object sender, EventArgs e)
        {
            AdicionarDigito("6");
        }

        private void Sete_Click(object sender, EventArgs e)
        {
            AdicionarDigito("7");
        }

        private void oito_Click(object sender, EventArgs e)
        {
            AdicionarDigito("8");
        }

        private void Nove_Click(object sender, EventArgs e)
        {
            AdicionarDigito("9");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AdicionarDigito("0");
        }

        private void Soma_Click(object sender, EventArgs e)
        {
            if (coluna1.Text != "")
            {
                n1 = double.Parse(coluna1.Text);
                operador = "+";
                operadorPressionado = true;
            }
        }

        private void Menos_Click(object sender, EventArgs e)
        {
            if (coluna1.Text != "")
            {
                n1 = double.Parse(coluna1.Text);
                operador = "-";
                operadorPressionado = true;
            }
        }

        private void Mult_Click(object sender, EventArgs e)
        {
            if (coluna1.Text != "")
            {
                n1 = double.Parse(coluna1.Text);
                operador = "×";
                operadorPressionado = true;
            }
        }

        private void Div_Click(object sender, EventArgs e)
        {
            if (coluna1.Text != "")
            {
                n1 = double.Parse(coluna1.Text);
                operador = "÷";
                operadorPressionado = true;
            }
        }

        private void Igual_Click(object sender, EventArgs e)
        {
            if (coluna2.Text != "" && operador != "")
            {
                n2 = double.Parse(coluna2.Text);
                double resultadoCalc = 0;

                switch (operador)
                {
                    case "+":
                        resultadoCalc = n1 + n2;
                        break;
                    case "-":
                        resultadoCalc = n1 - n2;
                        break;
                    case "×":
                        resultadoCalc = n1 * n2;
                        break;
                    case "÷":
                        if (n2 != 0)
                            resultadoCalc = n1 / n2;
                        else
                        {
                            resultado.Text = "Erro";
                            return;
                        }
                        break;
                }

                resultado.Text = resultadoCalc.ToString();
            }
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            n1 = 0;
            n2 = 0;
            operador = "";
            operadorPressionado = false;
            coluna1.Text = "0";
            coluna2.Text = "0";
            resultado.Text = "0";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}