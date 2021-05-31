using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form1 : Form
    {
        //Brush yellow_brush = Brushes.Yellow;
        private PictureBox pictureBox = new PictureBox();
        public Form1()
        {
            InitializeComponent();;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            


        }
        
        
        
       
      
       
        private void timer2_Tick(object sender, EventArgs e)
        {
           // this.Controls.Clear();
           
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            g.FillRectangle(System.Drawing.Brushes.Black, Form1.ActiveForm.Size.Width * 2 / 9, Form1.ActiveForm.Size.Height * 2 / 9,
            Form1.ActiveForm.Size.Width / 2, Form1.ActiveForm.Size.Height / 2);
            g.DrawLine(System.Drawing.Pens.Red, 0, 0,
            Form1.ActiveForm.Size.Width, Form1.ActiveForm.Size.Height);
            g.DrawEllipse(Pens.AntiqueWhite, this.Width / 3, this.Height / 3, this.Width / 4, this.Height / 4);
        }
    }
}
