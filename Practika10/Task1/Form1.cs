using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace Task1
{
    public partial class Form1 : Form
    {

        private int Move_Heart_X = 0;
        private int Move_Heart_Y = 0;
        private PointF[] point_hearth = new PointF[1000];//7 better 100 for g.FillClosedCurve(Brushes.Red, point_hearth)
        public Form1()
        {
            InitializeComponent();
        }
        
        private float For_hearth_X(float A)
        {
            A = (float)(Move_Heart_X * Math.Sin(A) * Math.Sin(A) * Math.Sin(A));
            return A;
        }

        private float For_hearth_Y(float A)
        { 
            A = (float)(Move_Heart_Y * Math.Cos(A) - 5 * Math.Cos(2 * A) - 2 * Math.Cos(3 * A) - Math.Cos(4 * A));
            return A;
        }
        private void Recount_XY()
        {
            float A = -100;
            for (int i = 0; i < 1000; i++)
            {
                point_hearth[i] = new PointF(22 * (this.Width/50  + For_hearth_X(A)), 22 * (this.Height/50 + For_hearth_Y(A)));
                A++;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Сердце";
            Recount_XY();
            this.Width = this.Width *3;
            this.Height = this.Height * 3;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Recount_XY();
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            //g.FillPolygon(Brushes.Red, point_hearth);
            g.FillClosedCurve(Brushes.Red, point_hearth);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Move_Heart_X = 16;
            Move_Heart_Y = 13;
            Invalidate();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Move_Heart_X = 10;
            Move_Heart_Y = 10;
            Invalidate();
            timer1.Enabled = true;
        }
    }
}
