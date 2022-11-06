using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        double sayi1, sayi2, sonuc = 0;
        string islem;

        public Form1()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            sonuc = sayi1 / 100;
            textBox1.Text = sonuc.ToString();
            label1.Visible = true;
            label1.Text = "%" + sayi1 + " = "+ sonuc;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            sonuc = sayi1 * sayi1;
            textBox1.Text = sonuc.ToString();
            label1.Visible = true;
            label1.Text = sayi1 + "² = " + sonuc;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            sonuc = Math.Sqrt(sayi1);
            textBox1.Text = sonuc.ToString();
            label1.Visible = true;
            label1.Text = "√¯" + sayi1 + " = " + sonuc;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = null;
            label1.Text = sayi1 + " +";
            label1.Visible = true;
            islem = "+";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = null;
            label1.Text = sayi1 + " -";
            label1.Visible = true;
            islem = "-";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = null;
            label1.Text = sayi1 + " X";
            label1.Visible = true;
            islem = "*";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = null;
            label1.Text = sayi1 + " ÷";
            label1.Visible = true;
            islem = "/";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sayi2 = Convert.ToDouble(textBox1.Text);
            label1.Text += " " + sayi2;
            textBox1.Text = null;

            switch (islem)
            {
                case "+":
                    {
                        sonuc = sayi1 + sayi2;
                        break;
                    }
                case "-":
                    {
                        sonuc = sayi1 - sayi2;
                        break;
                    }
                case "*":
                    {
                        sonuc = sayi1 * sayi2;
                        break;
                    }
                case "/":
                    {
                        sonuc = (double)sayi1 / sayi2;
                        break;
                    }
            }

            textBox1.Text = sonuc.ToString();
            label1.Text += " = " + sonuc;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
        }
    }
}
