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
        double n2;
        double n1;
        string sinal;
        string historico;
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
            if (label1.Text.Contains(" % ") && label1.Text.Contains(" + "))
            {
                int mais = label1.Text.IndexOf(" + ");
                double n2 = double.Parse(label1.Text.Substring(mais + 2).Replace("%","").Replace(" ",""));
                label1.Text = Convert.ToString(((n1 * n2) / 100)+n1);
                historico = historico + n1.ToString() + " + " + n2.ToString() + " % = " + label1.Text + System.Environment.NewLine;
            }

            if (label1.Text.Contains(" % ") && label1.Text.Contains(" - "))
            {
                int mais = label1.Text.IndexOf(" - ");
                double n2 = double.Parse(label1.Text.Substring(mais + 2).Replace("%", "").Replace(" ", ""));
                label1.Text = Convert.ToString((n1-(n1 * n2) / 100));
                historico = historico + n1.ToString() + " - " + n2.ToString() + " % = " + label1.Text + System.Environment.NewLine;
            }


            else if (label1.Text.Contains(" + "))
            {
                int mais = label1.Text.IndexOf(" + ");
                double n2 = double.Parse(label1.Text.Substring(mais + 2));
                label1.Text = Convert.ToString(n1 + n2);
                historico = historico + n1.ToString() + " + " + n2.ToString() + " = " + label1.Text + System.Environment.NewLine;
            }

            else if (label1.Text.Contains(" - "))
            {
                int mais = label1.Text.IndexOf(" - ");
                double n2 = double.Parse(label1.Text.Substring(mais + 2));
                label1.Text = Convert.ToString(n1 - n2);
                historico = historico + n1.ToString() + " - " + n2.ToString() + " = "  + label1.Text + System.Environment.NewLine;
            }

            else if (label1.Text.Contains(" x "))
            {
                int mais = label1.Text.IndexOf(" x ");
                double n2 = double.Parse(label1.Text.Substring(mais + 2));
                label1.Text = Convert.ToString(n1 * n2);
                historico = historico + n1.ToString() + " x " + n2.ToString() + " = "  + label1.Text + System.Environment.NewLine;
            }

            else if (label1.Text.Contains(" / "))
            {
                int mais = label1.Text.IndexOf(" / ");
                double n2 = double.Parse(label1.Text.Substring(mais + 2));
                label1.Text = Convert.ToString(n1 / n2);
                historico = historico + n1.ToString() + " / " + n2.ToString() + " = " + label1.Text + System.Environment.NewLine;
            }

            
            // estou no caminho certo!

            

        }

        public void button14_Click(object sender, EventArgs e)
        {//adição
            sinal = " + ";
            if (label1.Text == "")
            {
                MensagemSinal(sinal);
                n1 = 0;
            }
            else
            {
                n1 = double.Parse(label1.Text);
                MensagemSinal(sinal);
            }
        }
        public void button16_Click(object sender, EventArgs e)
        {//multiplicação
            sinal = " x ";
            if (label1.Text == "")
            {
                MensagemSinal(0+sinal);
                n1 = 0;
            }
            else
            {
                n1 = double.Parse(label1.Text);
                MensagemSinal(sinal);
            }

        }
        private void button15_Click(object sender, EventArgs e)
        {
            //subtração
            sinal = " - ";
            if (label1.Text == "")
            {
                MensagemSinal(0 + sinal);
                n1 = 0;
            }
            else
            {
                n1 = double.Parse(label1.Text);
                MensagemSinal(sinal);
            }
        }

        public void button17_Click(object sender, EventArgs e)
        {
            //divisão
            sinal = " / ";
            if (label1.Text == "")
            {
                MensagemSinal(0 + sinal);
                n1 = 0;
            }
            else
            {
                n1 = double.Parse(label1.Text);
                MensagemSinal(sinal);
            }
        }

        public void button18_Click(object sender, EventArgs e)
        {
            //porcentagem
            sinal = " % ";
            if (label1.Text == "")
            {
                MensagemSinal(0 + sinal);
                n1 = 0;
            }
            else if  (n1 > 0){
                MensagemSinal(sinal);
            }
            else
            {
                n1 = double.Parse(label1.Text.Replace("+","").Replace("-","").Replace("x","").Replace("/","").Replace("%","").Replace(" ",""));
                MensagemSinal(sinal);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        { //CE
            label1.Text = "";
        }

        public void button13_Click(object sender, EventArgs e )
        { //Historico
            Form2 fm = new Form2();
           
            fm.label1.Text = historico;

            fm.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        { //Virgula
            sinal = ",";
            MensagemSinal(sinal);
        }
    }
}
