using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task11
{
    public partial class Form1 : Form
    {
        private Point PreviousPoint, point; //Точка до перемещения курсора мыши и текущая точка
 private Bitmap bmp;
        private Pen blackPen;
        private Graphics g;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //открытие файла
            OpenFileDialog dialog = new OpenFileDialog(); //описываем и порождаем объект  dialog класса OpenFileDialog
 //задаем расширения файлов
 dialog.Filter = "Image files (*.BMP, *.JPG, *.GIF, *.TIF, *.PNG, *.ICO, *.EMF, *.WMF)| *.bmp; *.jpg; *.gif; *.tif; *.png; *.ico; *.emf; *.wmf";
 if (dialog.ShowDialog() == DialogResult.OK)//вызываем диалоговое окно и проверяем выбран ли файл
 {
                Image image = Image.FromFile(dialog.FileName); //Загружаем в image изображение из выбранного файла
                int width = image.Width;
                Image image_cpoy = image;
                int height = image.Height;
                pictureBox1.Width = width;
                pictureBox1.Height = height;
                bmp = new Bitmap(image, width, height); //создаем и загружаем из image изображение в формате bmp
                pictureBox1.Image = bmp; //записываем изображение в формате bmp в  pictureBox1
                 g = Graphics.FromImage(pictureBox1.Image); //подготавливаем объект  Graphics для рисования в pictureBox1
 }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
            Random rand_p = new Random();
            Random rand_color = new Random();
            for (int i = 0; i<1000;i++)
            {
                bmp.SetPixel
                    (rand_p.Next(bmp.Width), rand_p.Next(bmp.Height),

                            Color.FromArgb
                            (
                                rand_color.Next(0, 255),
                                rand_color.Next(0, 255),
                                rand_color.Next(0, 255)
                            )
                    );
        }
            Refresh(); //вызываем функцию перерисовки окна
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
