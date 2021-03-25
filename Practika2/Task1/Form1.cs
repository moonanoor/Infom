using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form1 : Form
    {
        public double  Func(double a)
        {
            a = (2 * Math.Log(a) * Math.Cos(2 * a) - 3 * (Math.Pow(a + 1, 2) / (a - 1))/(2+Math.Sqrt(a)));
            return a;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Введите значение х:";
            label2.Text = "Результат расчёта";
            textBox1.Text = "2";
            // Вывод строки в многострочный редактор
            textBox2.Text = "Практическая работа №1 Ладынй О.К.";
            // textBox2.Text = Environment.NewLine;
           // textBox2.Text += Environment.NewLine + "Рассчитать значение выражения:";
            //textBox2.Text += Environment.NewLine + " y = (2ln(x)*cos(2x)- 3 *((x+1)^2/(x-1";
           // pictureBox1.Image = Image.FromFile("C:/Users/User/source/repos/Infom/Practika2/Task1/bin/Debug/Снимок.png");


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Считывание значения X
            double x = double.Parse(textBox1.Text);
            // Вывод значения X в окно
            textBox2.Text += Environment.NewLine +
            "При x = " + x.ToString();
            // Вычисляем арифметическое выражение
            double y = Func(x);

            // Выводим результат в окно
            textBox2.Text += Environment.NewLine +
            "Результат y = " + y.ToString();
        }
    }
}
