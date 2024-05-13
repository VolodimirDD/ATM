using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая_Имитация_банкомата_
{
    public partial class RecognitionEng : Form
    {
        public RecognitionEng()
        {

            InitializeComponent();

            this.CenterToScreen();      //Установка формы по центру экрана програмно

            this.BackgroundImage = Properties.Resources.Процессы;      //Установка BackgroundImage

            this.BackgroundImageLayout = ImageLayout.Stretch;

            timer1.Enabled = true;      //Включаем таймер

            timer1.Interval = 100;      //Задаем интервал таймера

            progressBar1.Maximum = 50;     //Задаем максимальное значение progressBar1

            progressBar1.Value = 0;     ////Задаем изачальное значение progressBar1

            timer2.Enabled = true;      //Включаем таймер

            timer2.Interval = 7500;        //Задаем интервал таймера

            label1.Text = "Please wait ... Card recognition process in progress!";        //Присваем label1 текст

            timer3.Enabled = true;      //Включаем таймер

            MaximizeBox = false;

            MinimizeBox = false;

            this.ControlBox = false;

            this.label1.BackColor = System.Drawing.Color.Transparent;

            this.label2.BackColor = System.Drawing.Color.Transparent;

            timer3.Interval = 6000;        //Задаем интервал таймера

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (progressBar1.Maximum != progressBar1.Value)
            {

                progressBar1.Value++;

            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            timer2.Enabled = false;

            Hide();

            EnterPinEng Form5 = new EnterPinEng();

            Form5.Show();

        }

        private void timer3_Tick(object sender, EventArgs e)
        {

            label2.Text = ("Card recognized!");

            label1.Text = ("");

            timer3.Enabled = false;

        }

        private void RecognitionEng_Move(object sender, EventArgs e)
        {

            this.Move += delegate { this.Capture = false; };

        }

    }
}
