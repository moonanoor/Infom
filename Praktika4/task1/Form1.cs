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

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double x = Convert.ToDouble(textBox2.Text);
            textBox1.Text = "Результаты работы программы ст. Ладный О.К. " + Environment.NewLine;
            double current = 1;
            int i = 0;
            long F = 1;
            double s = 0;
            while (Math.Abs(current) >= 0.0001)
            {
                F *= ++i;
                current = (x + 1) / (F * 2.0);
                s += current;
            }
            textBox1.Text += "При eps = " + textBox2.Text + Environment.NewLine;
            textBox1.Text += "Расчет суммы ряда S = " + Convert.ToString(s) + Environment.NewLine;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1_Click(sender, e);
        }
    }
}
