using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        int[] Mas = new int[15];



        private void button1_Click_1(object sender, EventArgs e)
        {
            Random rand = new Random();
            textBox1.Text = "";
            for (int i = 0; i < 15; i++)
            {
                Mas[i] = rand.Next(-50, 50);
                textBox1.Text += "Mas[" + Convert.ToString(i) + "] = " + Convert.ToString(Mas[i]) + Environment.NewLine;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Иссходный массив";
            label2.Text = "Преобразованный масиив";
            button1.Text = "Заполнить";
            button2.Text = "Рассчитать";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            int sum = 0;
            for (int i = 0; i < 15; i++)
            {
                if (i % 2 == 0)
                {
                    sum += Mas[i];
                }
            }
            textBox2.Text = Convert.ToString(sum);
        }
    }
}
