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

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "Посчитать";
            button2.Text = "Добавить строку";
            button3.Text = "Удалить строку";
            label1.Text = "Количество букв 'а': 0";
            listBox1.Items.Add("Привет");
            listBox1.Items.Add("аааа");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Получаем номер выделенной строки
            int index = listBox1.SelectedIndex;
            // Считываем строку в перменную str
            string str = (string)listBox1.Items[index];
            // Узнаем количество символов в строке
            int len = str.Length;
            // Считаем, что количество пробелов равно 0
            int count = 0;
            // Устанавливаем счетчик символов в 0
            int i = 0;
            str.ToLower();
            //Организуем цикл перебора всех символов в строке
            while (i < len)
            {
                // Если нашли пробел, то увеличиваем
                // счетчик пробелов на 1
                if (str[i] == 'а')
                    count++;
                i++;
            }
            label1.Text = "Количество букв 'а': " + count.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                listBox1.Items.Add(Convert.ToString(textBox1.Text));
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if ((textBox2.Text != "") & (Convert.ToInt32(textBox2.Text) > 0))
                listBox1.Items.RemoveAt(Convert.ToInt32(textBox2.Text) - 1);
        }
    }
}
