using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void score_up()
        {
            score += 1;
            label2.Text = "Счёт: " + Convert.ToString(score);
        }
        public void IsMine(int ind) 
        {
            if (My_mine.Mines_id == ind)
            {
                BackColor = Color.Red;
                MessageBox.Show("Вы проиграли");
            }
            else
            {
                score_up();
                if (ind == 1)
                {
                    if (My_mine.Mines_id == 2) button1.Text = "1";
                }
                if (ind == 1)
                {
                    if (My_mine.Mines_id == 4) button1.Text = "1";

                }
                if (ind == 1)
                {
                    if (My_mine.Mines_id == 5) button1.Text = "1";
                }
                if (ind == 2)
                {
                    if (My_mine.Mines_id == 1) button2.Text = "1";
                }
                if (ind == 2)
                {
                    if (My_mine.Mines_id == 3) button2.Text = "1";

                }
                if (ind == 2)
                {
                    if (My_mine.Mines_id == 5) button2.Text = "1";
                }
                if (ind == 2)
                {
                    if (My_mine.Mines_id == 4) button2.Text = "1";
                }
                if (ind == 2)
                {
                    if (My_mine.Mines_id == 6) button2.Text = "1";

                }
                if (ind == 3)
                {
                    if (My_mine.Mines_id == 2) button3.Text = "1";
                }
                if (ind == 3)
                {
                    if (My_mine.Mines_id == 6) button3.Text = "1";

                }
                if (ind == 3)
                {
                    if (My_mine.Mines_id == 5) button3.Text = "1";
                }
                if (ind == 4)
                {
                    if (My_mine.Mines_id == 2) button4.Text = "1";
                }
                if (ind == 4)
                {
                    if (My_mine.Mines_id == 1) button4.Text = "1";

                }
                if (ind == 4)
                {
                    if (My_mine.Mines_id == 5) button4.Text = "1";
                }
                if (ind == 4)
                {
                    if (My_mine.Mines_id == 7) button4.Text = "1";
                }
                if (ind == 4)
                {
                    if (My_mine.Mines_id == 8) button4.Text = "1";

                }
                if (ind == 5)
                {
                    button5.Text = "1";
                }
                if (ind == 6)
                {
                    if (My_mine.Mines_id == 2) button6.Text = "1";
                }
                if (ind == 6)
                {
                    if (My_mine.Mines_id == 3) button6.Text = "1";

                }
                if (ind == 6)
                {
                    if (My_mine.Mines_id == 5) button6.Text = "1";
                }
                if (ind == 6)
                {
                    if (My_mine.Mines_id == 9) button6.Text = "1";
                }
                if (ind == 6)
                {
                    if (My_mine.Mines_id == 8) button6.Text = "1";

                }
                if (ind == 7)
                {
                    if (My_mine.Mines_id == 8) button7.Text = "1";
                }
                if (ind == 7)
                {
                    if (My_mine.Mines_id == 4) button7.Text = "1";

                }
                if (ind == 7)
                {
                    if (My_mine.Mines_id == 5) button7.Text = "1";
                }
                if (ind == 9)
                {
                    if (My_mine.Mines_id == 5) button9.Text = "1";
                }
                if (ind == 9)
                {
                    if (My_mine.Mines_id == 6) button9.Text = "1";

                }
                if (ind == 9)
                {
                    if (My_mine.Mines_id == 8) button9.Text = "1";
                }
                if (ind == 8)
                {
                    if (My_mine.Mines_id == 7) button8.Text = "1";
                }
                if (ind == 8)
                {
                    if (My_mine.Mines_id == 4) button8.Text = "1";

                }
                if (ind == 8)
                {
                    if (My_mine.Mines_id == 5) button8.Text = "1";
                }
                if (ind == 8)
                {
                    if (My_mine.Mines_id == 9) button8.Text = "1";
                }
                if (ind == 8)
                {
                    if (My_mine.Mines_id == 6) button8.Text = "1";

                }
            }
        }
        public class Mine
        {
            public int Mines_id { get; set; }
        }
        Mine My_mine = new Mine();
        private void Form1_Load(object sender, EventArgs e)
        {

            Random rand = new Random();
            My_mine.Mines_id = rand.Next(1, 9);
            label1.Text = "Количество мин: 1";
            label2.Text = "Счёт: " + Convert.ToString(score);

        }
        public void button1_Click(object sender, EventArgs e)
        {
            IsMine(1);
            button1.Enabled = false;
        }
        int score = 0;
     

        private void button2_Click(object sender, EventArgs e)
        {
            IsMine(2);
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IsMine(3);
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            IsMine(4);
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            IsMine(5);
            button5.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            IsMine(6);
            button6.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            IsMine(7);
            button7.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            IsMine(8);
            button8.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            IsMine(9);
            button9.Enabled = false;
                
        }
    }
}
