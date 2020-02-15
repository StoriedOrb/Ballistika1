using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ballistika
{
    public partial class Ballistika : Form
    {
        public Ballistika()
        {
            InitializeComponent();
        }

        private void Itog_Click(object sender, EventArgs e)
        {
            const double g = 9.81;                      //Ускорение свободного падения
            double D, H, ug, v, ur, x0, y0, t, x, y;
            D = Convert.ToDouble(Lenght.Text);
            D = Convert.ToDouble(Lenght.Text);
            D = Convert.ToDouble(Lenght.Text);
            D = Convert.ToDouble(Lenght.Text);          //Блок ввода данных  D, H, v, ug
            //Перевод из градусов в радианы
            ur = ug * Math.PI / 180;
            //Параметры начала вылета
            x0 = 0;                 //Начало оси
            y0 = H + D * Math.Sin(ur);      //Начальная высота 
            t = 0;
            y = y0;
            while (y >= 0)          //Пока снаряд над землей
            {
                x = x0 + v * Math.Cos(ur) * t;
                y = y0 + v * Math.Sin(ur) * t - g * t * t / 2;
                //Вывод  расчетной  точки  в  таблицу  стрельбы
                //Вывод  расчетной  точки  на  график
                t = t + 0.1;            //Следующий момент времени
            }


        }
























        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

       
    }
}
