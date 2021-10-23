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

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";
        public Calculadora()
        {
            InitializeComponent();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textResult.Text += "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textResult.Text += "1";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textResult.Text += "2";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textResult.Text += "3";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textResult.Text += "4";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textResult.Text += "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textResult.Text += "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textResult.Text += "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textResult.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textResult.Text += "9";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textResult.Text += ".";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(textResult.Text, CultureInfo.InvariantCulture);

            if (operacao == "SOMA")
            {
                textResult.Text = Convert.ToString(valor1 + valor2);
            }
            else if (operacao == "SUB")
            {
                textResult.Text = Convert.ToString(valor1 - valor2);
            }
            else if (operacao == "MULT")
            {
                textResult.Text = Convert.ToString(valor1 * valor2);
            }
            else if (operacao == "DIV")
            {
                textResult.Text = Convert.ToString(valor1 / valor2);
            }
            else
            {
                textResult.Text = "Número inválido";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textResult.Text != "")
            {
                valor1 = decimal.Parse(textResult.Text, CultureInfo.InvariantCulture);
                textResult.Text = "";
                operacao = "SUB";
                label1.Text = "-";
            }
            else
            {
                textResult.Text = "Informe um valor";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textResult.Text != "")
            {
                valor1 = decimal.Parse(textResult.Text, CultureInfo.InvariantCulture);
                textResult.Text = "";
                operacao = "MULT";
                label1.Text = "x";
            }
            else
            {
                textResult.Text = "Informe um valor";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textResult.Text != "")
            {
                valor1 = decimal.Parse(textResult.Text, CultureInfo.InvariantCulture);
                textResult.Text = "";
                operacao = "DIV";
                label1.Text = "/";
            }
            else
            {
                textResult.Text = "Informe um valor";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textResult.Text != "")
            {
                textResult.Text = "";
                label1.Text = "";
            }
            else
            {
                textResult.Text = "Informe um valor";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textResult.Text != "")
            {
                textResult.Text = "";
                label1.Text = "";
                valor1 = 0;
                valor2 = 0;
            }
            else 
            {
                textResult.Text = "Informe um valor";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textResult.Text != "")
            {
                valor1 = decimal.Parse(textResult.Text, CultureInfo.InvariantCulture);
                textResult.Text = "";
                operacao = "SOMA";
                label1.Text = "+";
            }
            else
            {
                textResult.Text = "Informe um valor";
            }

        }

    }
}
