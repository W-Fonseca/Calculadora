using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double btn;
        string sinal;
        string[] resultado;

        public Form1()
        {
            

            InitializeComponent();
        }

        public void MensagemNumero(double btn)
        {
            label1.Text = label1.Text + btn.ToString();
           
        }

        public void MensagemSinal(string sinal)
        {
            label1.Text = label1.Text + sinal;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //soma 
          
            sinal = "+";
            MensagemSinal(sinal);
                
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //multiplicação
            sinal = "*";
            MensagemSinal(sinal);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            btn = 0;

            MensagemNumero(btn);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            btn = 1;
            MensagemNumero(btn);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btn = 2;
            MensagemNumero(btn);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btn = 3;
            MensagemNumero(btn);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            btn = 4;
            MensagemNumero(btn);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            btn = 5;
            MensagemNumero(btn);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            btn = 6;
            MensagemNumero(btn);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            btn = 7;
            MensagemNumero(btn);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            btn = 8;
            MensagemNumero(btn);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            btn = 9;
            MensagemNumero(btn);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //resultado

            if (label1.Text.Contains("+"))
            {
                int mais = label1.Text.IndexOf("+");
                double n1 = double.Parse(label1.Text.Remove(mais));
                Console.WriteLine(n1 + 2);
            }

            else if (label1.Text.Contains("-"))
                {
                    int mais = label1.Text.IndexOf("-");
                    double n1 = int.Parse(label1.Text.Remove(mais));
                    Console.WriteLine(n1 - 2);
                }

            else if (label1.Text.Contains("*"))
            {
                int mais = label1.Text.IndexOf("*");
                double n1 = int.Parse(label1.Text.Remove(mais));
                Console.WriteLine(n1 * 2);
            }

            else if (label1.Text.Contains("/"))
            {
                int mais = label1.Text.IndexOf("/");
                double n1 = int.Parse(label1.Text.Remove(mais));
                Console.WriteLine(n1 / 2);
            }

            else if (label1.Text.Contains("%"))
            {
                int mais = label1.Text.IndexOf("%");
                double n1 = int.Parse(label1.Text.Remove(mais));
                Console.WriteLine(n1 % 2); // calculo errado
            }
            // estou no caminho certo!

        }

        private void button15_Click(object sender, EventArgs e)
        {
            //subtração
            sinal = "-";
            MensagemSinal(sinal);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //divisão
            sinal = "/";
            MensagemSinal(sinal);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //porcentagem
            sinal = "%";
            MensagemSinal(sinal);
        }
    }
}
