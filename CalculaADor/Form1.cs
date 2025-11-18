using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculaADor
{
    public partial class Form1 : Form
    {
        private double valor1 = 0;
        private double valor2 = 0;
        private string operacao = "";
        private bool operacaoRealizada = false;
        private bool digitandoNumero2 = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Numero1.Text = "";
            Numero2.Text = "";
            Mostraoperacao.Text = "";
            Resultado.Text = "0";
        }

        private void Numero1_TextChanged(object sender, EventArgs e)
        {
        }

        private void Numero2_TextChanged(object sender, EventArgs e)
        {
        }

        private void Resultado_TextChanged(object sender, EventArgs e)
        {
        }

        private void Mostraoperacao_TextChanged(object sender, EventArgs e)
        {
        }

        private void AdicionarNumero(string numero)
        {
            if (!digitandoNumero2)
            {
                // Digitando o primeiro número
                if (Numero1.Text == "" || operacaoRealizada)
                {
                    Numero1.Text = numero;
                    operacaoRealizada = false;
                }
                else
                {
                    Numero1.Text += numero;
                }
            }
            else
            {
                // Digitando o segundo número
                if (Numero2.Text == "")
                {
                    Numero2.Text = numero;
                }
                else
                {
                    Numero2.Text += numero;
                }
            }
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            AdicionarNumero("0");
        }

        private void Um_Click(object sender, EventArgs e)
        {
            AdicionarNumero("1");
        }

        private void Dois_Click(object sender, EventArgs e)
        {
            AdicionarNumero("2");
        }

        private void Tres_Click(object sender, EventArgs e)
        {
            AdicionarNumero("3");
        }

        private void Quatro_Click(object sender, EventArgs e)
        {
            AdicionarNumero("4");
        }

        private void Cinco_Click(object sender, EventArgs e)
        {
            AdicionarNumero("5");
        }

        private void Seis_Click(object sender, EventArgs e)
        {
            AdicionarNumero("6");
        }

        private void Sete_Click(object sender, EventArgs e)
        {
            AdicionarNumero("7");
        }

        private void Oito_Click(object sender, EventArgs e)
        {
            AdicionarNumero("8");
        }

        private void Nove_Click(object sender, EventArgs e)
        {
            AdicionarNumero("9");
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            Numero1.Text = "";
            Numero2.Text = "";
            Mostraoperacao.Text = "";
            Resultado.Text = "0";
            valor1 = 0;
            valor2 = 0;
            operacao = "";
            operacaoRealizada = false;
            digitandoNumero2 = false;
        }

        private void Soma_Click(object sender, EventArgs e)
        {
            if (Numero1.Text != "")
            {
                valor1 = Convert.ToDouble(Numero1.Text);
                operacao = "+";
                Mostraoperacao.Text = "+";
                digitandoNumero2 = true;
            }
        }

        private void Menos_Click(object sender, EventArgs e)
        {
            if (Numero1.Text != "")
            {
                valor1 = Convert.ToDouble(Numero1.Text);
                operacao = "-";
                Mostraoperacao.Text = "-";
                digitandoNumero2 = true;
            }
        }

        private void Mult_Click(object sender, EventArgs e)
        {
            if (Numero1.Text != "")
            {
                valor1 = Convert.ToDouble(Numero1.Text);
                operacao = "*";
                Mostraoperacao.Text = "×";
                digitandoNumero2 = true;
            }
        }

        private void Div_Click(object sender, EventArgs e)
        {
            if (Numero1.Text != "")
            {
                valor1 = Convert.ToDouble(Numero1.Text);
                operacao = "/";
                Mostraoperacao.Text = "÷";
                digitandoNumero2 = true;
            }
        }

        private void Igual_Click(object sender, EventArgs e)
        {
            if (Numero1.Text != "" && Numero2.Text != "" && operacao != "")
            {
                valor1 = Convert.ToDouble(Numero1.Text);
                valor2 = Convert.ToDouble(Numero2.Text);
                double resultado = 0;

                switch (operacao)
                {
                    case "+":
                        resultado = valor1 + valor2;
                        break;
                    case "-":
                        resultado = valor1 - valor2;
                        break;
                    case "*":
                        resultado = valor1 * valor2;
                        break;
                    case "/":
                        if (valor2 != 0)
                            resultado = valor1 / valor2;
                        else
                        {
                            MessageBox.Show("Não é possível dividir por zero!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Limpar_Click(sender, e);
                            return;
                        }
                        break;
                }

                Resultado.Text = resultado.ToString();
                operacaoRealizada = true;
                digitandoNumero2 = false;
            }
        }

        private void MaisOuMenos_Click(object sender, EventArgs e)
        {
            if (!digitandoNumero2 && Numero1.Text != "")
            {
                double valor = Convert.ToDouble(Numero1.Text);
                valor = valor * -1;
                Numero1.Text = valor.ToString();
            }
            else if (digitandoNumero2 && Numero2.Text != "")
            {
                double valor = Convert.ToDouble(Numero2.Text);
                valor = valor * -1;
                Numero2.Text = valor.ToString();
            }
        }

        private void Porcentagem_Click(object sender, EventArgs e)
        {
            if (!digitandoNumero2 && Numero1.Text != "")
            {
                double valor = Convert.ToDouble(Numero1.Text);
                valor = valor / 100;
                Numero1.Text = valor.ToString();
            }
            else if (digitandoNumero2 && Numero2.Text != "" && operacao != "")
            {
                valor1 = Convert.ToDouble(Numero1.Text);
                valor2 = Convert.ToDouble(Numero2.Text);
                double resultado = valor1 * (valor2 / 100);
                Numero2.Text = resultado.ToString();
            }
        }
    }
}