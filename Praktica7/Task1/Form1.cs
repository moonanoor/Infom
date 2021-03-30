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
        public Form1()
        {
            InitializeComponent();
        }
        int[,] mas;
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 15; //Указываем количество строк
            dataGridView1.ColumnCount = 15; //Указываем количество столбцов
            button1.Text = "Заполнить массив";
            button1.AutoSize = true;
            button2.AutoSize = true;
            label1.Text = "Парктическая работа №7 Ладный О.К.";
            button2.Text = "Выполнить";
            dataGridView1.ReadOnly = true;
            mas = new int[15, 15];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Random rand = new Random();
            for (int i = 0; i < 15; i++)
                for (int j = 0; j < 15; j++)
                    mas[i, j] = rand.Next(-100, 100);
            //Выводим матрицу в dataGridView1
            for (int i = 0; i < 15; i++)
                for (int j = 0; j < 15; j++)
                    dataGridView1.Rows[i].Cells[j].Value = Convert.ToString(mas[i, j]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int max = int.MinValue;
            for(int i = 0; i < 15; i++)
            {
                for(int j = 0; j <15;j++)
                {
                    if (i < j)
                    {
                        if (max < mas[i, j]) max = mas[i, j];
                    }
                }
            }
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    if (max == mas[i, j]) MessageBox.Show("Индекс максимального " + Convert.ToString(i + 1) + " " + Convert.ToString(j + 1));
                }
            }
        }
    }
}
