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
    public partial class PopovnitUkr : Form
    {
        public PopovnitUkr()
        {

            InitializeComponent();

            this.BackgroundImage = Properties.Resources.Ввод_пинкода;

            this.BackgroundImageLayout = ImageLayout.Stretch;

            balance.ReadOnly = true;

            this.CenterToScreen();      //Установка формы по центру экрана програмно

            label1.Text = "Ваш баланс :";

            MaximizeBox = false;

            MinimizeBox = false;

            this.ControlBox = false;

            deneg100.Select();

            balance.TabStop = false;

            this.label1.BackColor = System.Drawing.Color.Transparent;

        }

        private void PopovnitUkr_Move(object sender, EventArgs e)
        {

            this.Move += delegate { this.Capture = false; };

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            //останавливаем таймер, иначе появление второй формы будет происходить каждую секундй (или каждые 10 сек, тоесть в зависимости от указаного интервала)
            timer1.Enabled = false;

            //вызываем другую форму

            ReplenishmentUkr Form12 = new ReplenishmentUkr();

            Form12.Show();

        }

        private void deneg100_Click(object sender, EventArgs e)
        {

            int num = int.Parse(balance.Text);

            int rez = num + 100;

            balance.Text = (num + 100).ToString();

            timer1.Interval = 1;    //интервал(1000 = 1 сек). Спустя 1 секунду запустется таймер. Если поставить 10000, то форма 2 повиться через 10 сек;

            timer1.Enabled = true;      //запускаем таймер

        }

        private void deneg200_Click(object sender, EventArgs e)
        {

            int num = int.Parse(balance.Text);

            int rez = num + 200;

            balance.Text = (num + 200).ToString();

            timer1.Interval = 1;    //интервал(1000 = 1 сек). Спустя 1 секунду запустется таймер. Если поставить 10000, то форма 2 повиться через 10 сек;

            timer1.Enabled = true;      //запускаем таймер

        }

        private void deneg1000_Click(object sender, EventArgs e)
        {

            int num = int.Parse(balance.Text);

            int rez = num + 1000;

            balance.Text = (num + 1000).ToString();

            timer1.Interval = 1;    //интервал(1000 = 1 сек). Спустя 1 секунду запустется таймер. Если поставить 10000, то форма 2 повиться через 10 сек;

            timer1.Enabled = true;      //запускаем таймер

        }

        private void Back_Click(object sender, EventArgs e)
        {

            this.Hide();

            OperationsUkr op1 = new OperationsUkr();

            op1.balance.Text = this.balance.Text;

            op1.Show();

            op1.CheckBalance.Dispose();

        }

        private void Exit_Click(object sender, EventArgs e)
        {

            this.Hide();

            VihodUkr z = new VihodUkr();

            z.Show();

        }

        private void deneg100_MouseEnter(object sender, EventArgs e)
        {

            deneg100.BackColor = Color.Magenta;

        }

        private void deneg200_MouseEnter(object sender, EventArgs e)
        {

            deneg200.BackColor = Color.Magenta;

        }

        private void deneg300_MouseEnter(object sender, EventArgs e)
        {

            deneg300.BackColor = Color.Magenta;

        }

        private void deneg1000_MouseEnter(object sender, EventArgs e)
        {

            deneg1000.BackColor = Color.Magenta;

        }

        private void Back_MouseEnter(object sender, EventArgs e)
        {

            Back.BackColor = Color.Gold;

        }

        private void Exit_MouseEnter(object sender, EventArgs e)
        {

            Exit.BackColor = Color.Blue;

        }

        private void Exit_MouseLeave(object sender, EventArgs e)
        {

            Exit.BackColor = Color.Crimson;

        }

        private void Back_MouseLeave(object sender, EventArgs e)
        {

            Back.BackColor = Color.Crimson;

        }

        private void deneg100_MouseLeave(object sender, EventArgs e)
        {

            deneg100.BackColor = Color.White;

        }

        private void deneg200_MouseLeave(object sender, EventArgs e)
        {

            deneg200.BackColor = Color.White;

        }

        private void deneg300_MouseLeave(object sender, EventArgs e)
        {

            deneg300.BackColor = Color.White;

        }

        private void deneg1000_MouseLeave(object sender, EventArgs e)
        {

            deneg1000.BackColor = Color.White;

        }

        private void deneg300_Click_1(object sender, EventArgs e)
        {
            int num = int.Parse(balance.Text);

            int rez = num + 500;

            balance.Text = (num + 500).ToString();

            timer1.Interval = 1;    //интервал(1000 = 1 сек). Спустя 1 секунду запустется таймер. Если поставить 10000, то форма 2 повиться через 10 сек;

            timer1.Enabled = true;      //запускаем таймер
        }

    }
}
