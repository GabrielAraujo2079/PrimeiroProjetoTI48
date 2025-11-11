using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PrimeiroProjetoTI48
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click_2(object sender, EventArgs e)
        {
            double soma1 = double.Parse(n1.Text);
            double soma2 = double.Parse(n2.Text);
            double resultado = soma1 + soma2;
            n3.Text = resultado.ToString();

        }

        private void Subtracao_Click(object sender, EventArgs e)
        {

            double soma1 = double.Parse(n1.Text);
            double soma2 = double.Parse(n2.Text);
            double resultado = soma1 - soma2;
            n3.Text = resultado.ToString();
        }

        private void Mult_Click(object sender, EventArgs e)
        {
            double soma1 = double.Parse(n1.Text);
            double soma2 = double.Parse(n2.Text);
            double resultado = soma1 * soma2;
            n3.Text = resultado.ToString();
        }

        private void Divisao_Click(object sender, EventArgs e)
        {
            double soma1 = double.Parse(n1.Text);
            double soma2 = double.Parse(n2.Text);
            double resultado = soma1 / soma2;
            n3.Text = resultado.ToString();
        }
    }
}
