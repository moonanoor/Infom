using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Task
{
    public partial class Form1 : Form
    {
        
        private double Func(double a)
        {
            a = (2 * Math.Log(a) * Math.Cos(2 * a) - 3 * (Math.Pow(a + 1, 2) / (a - 1)) / (2 + Math.Sqrt(a)));
            return a;
        }
        
        Chart chart;
        
        /// <summary>
        /// Создаѐм элемент управления Chart и настраиваем его
        /// </summary>
        private void CreateChart()
        {
            // Создаѐм новый элемент управления Chart
            chart = new Chart();
            // Помещаем его на форму
            chart.Parent = this;
            // Задаѐм размеры элемента
            chart.SetBounds(10, 10, ClientSize.Width - 20, ClientSize.Height - 20);
            // Создаѐм новую область для построения графика
            ChartArea area = new ChartArea();
            // Даѐм ей имя (чтобы потом добавлять графики)
            area.Name = "myGraph";
            // Задаѐм левую и правую границы оси X
             area.AxisX.Minimum = -1;
           // area.AxisX.Minimum = -20;
           //// area.AxisX.Maximum = 50;
            area.AxisY.Minimum = -100;
            area.AxisY.Maximum = 40;
            // Определяем шаг сетки
            area.AxisX.MajorGrid.Interval = 10;
            // Добавляем область в диаграмму
            chart.ChartAreas.Add(area);
            // Создаѐм объект для первого графика
            Series series1 = new  Series();
            // Ссылаемся на область для построения графика
            series1.ChartArea = "myGraph";
            // Задаѐм тип графика - сплайны
            series1.ChartType = SeriesChartType.Spline;
            // Указываем ширину линии графика
            series1.BorderWidth = 3;
            // Название графика для отображения в легенде
            series1.LegendText = "F(x)";
            // Добавляем в список графиков диаграммы
            chart.Series.Add(series1);
            // Создаѐм легенду, которая будет показывать названия
          //  Legend legend = new Legend();
          //  chart.Legends.Add(legend);
            
            Series series2 = new Series();
            series2.ChartArea = "myGraph";
            series2.ChartType = SeriesChartType.Spline;
            series2.BorderWidth = 3;
            series1.Color = Color.Blue;
            series2.Color = Color.Blue;
          //  series2.LegendText = "";
            // series2.LegendText = "cos(x)";
            chart.Series.Add(series2);

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            CreateChart();
           
        }
        
        private double My_step = 0.01;
        private double x = 0;
        private double y = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if ((x > 0.9) && (x < 1))
            {
              
                x = 1;
             
            }
            if ((x != 0) && (x != 1) && (x < 1))
            {
                y = Func(x);
                chart.Series[0].Points.AddXY(x, y);
            }
            if  (x > 1)
            {
                y = Func(x);
                chart.Series[1].Points.AddXY(x, y);
            }
            x += My_step;
            

        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            chart.SetBounds(10, 10, ClientSize.Width - 20, ClientSize.Height - 20);
        }
    }
}
