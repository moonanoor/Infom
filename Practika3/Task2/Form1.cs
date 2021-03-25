using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public double x_max(double x)
        {
            x = 1;
            return x;
        }
        public double x_mid(double x)
        {
            x = x * 2 - 1;
            return x;
        }
        public double x_min(double x)
        {
            x = Math.Abs(1 - 3 * x);
            return x;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Получение исходных данных из TextBox
            double x = Convert.ToDouble(textBox1.Text);
            double y;
            // Ввод исходных данных в окно результатов
            textBox4.Text = "Результаты работы программы ст. Ладный О.К. " + Environment.NewLine;
            textBox4.Text += "При x = " + textBox1.Text + Environment.NewLine;
            //  textBox4.Text += "При Y = " + textBox2.Text + Environment.NewLine;
            //Проверка ООФ
            int n = 0;
            if ((0 <= x) & (x <= 10))
            {
                n = 1;
            }
            else if (x < 0)
            {
                n = 2;
            }
            switch (n)
            {
                case 0:
                    y = x_max(x);
                    textBox4.Text += "y = " + Convert.ToString(y) + Environment.NewLine;
                    break;
                case 1:
                    y = x_mid(x);
                    textBox4.Text += "y = " + Convert.ToString(y) + Environment.NewLine;
                    break;
                case 2:
                    y = x_min(x);
                    textBox4.Text += "y = " + Convert.ToString(y) + Environment.NewLine;
                    break;
                default:
                    textBox4.Text += "Решение не найдено" + Environment.NewLine;
                    break;
            }
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void button1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) button1_Click(sender, e);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) button1_Click(sender, e);

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) button1_Click(sender, e);
        }
    }
}
