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
        //Brush yellow_brush = Brushes.Yellow;
        private PictureBox pictureBox = new PictureBox();
        private PictureBox pictureBox1 = new PictureBox();
        public Form1()
        {
            InitializeComponent();;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.BackColor = Color.White;
            pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox2_Paint);
            this.Controls.Add(pictureBox);
            this.Controls.Add(pictureBox1);
        }
        
        
        private void pictureBox1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            g.FillRectangle(System.Drawing.Brushes.Black, pictureBox.Right * 2 / 9, pictureBox.Bottom * 2 / 9,
            pictureBox.Right/2, pictureBox.Bottom/2);
            g.DrawLine(System.Drawing.Pens.Red, pictureBox.Left, pictureBox.Top,
            pictureBox.Right, pictureBox.Bottom);
            g.DrawEllipse(Pens.AntiqueWhite, pictureBox.Width / 3, pictureBox.Height / 3, pictureBox.Width / 4, pictureBox.Height / 4);
        }
        private void pictureBox2_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = e.Graphics;
           // g.DrawEllipse(Pens.AntiqueWhite, 0, 0, 30, 30);

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //this.Controls.Add(pictureBox);
            pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //this.Controls.Clear();
            pictureBox1.Location = new Point(Cursor.Position.X, Cursor.Position.Y);
        }

        private void Form1_CursorChanged(object sender, EventArgs e)
        {

        }
    }
}
