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
    public partial class SniatUkr : Form
    {
        public SniatUkr()
        {

            InitializeComponent();

            this.BackgroundImage = Properties.Resources.Ввод_пинкода;

            this.BackgroundImageLayout = ImageLayout.Stretch;

            balance.ReadOnly = true;

            this.CenterToScreen();

            label1.Text = "Ваш баланс :";

            MaximizeBox = false;

            MinimizeBox = false;

            this.ControlBox = false;

            deneg100.Select();

            balance.TabStop = false;

            this.label1.BackColor = System.Drawing.Color.Transparent;

            Back.Select();

        }

        private void SniatUkr_Move(object sender, EventArgs e)
        {

            this.Move += delegate { this.Capture = false; };

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            WithdrawalProcessUkr Form1234 = new WithdrawalProcessUkr();

            Form1234.Show();

            timer1.Enabled = false;

        }

        private void deneg100_Click(object sender, EventArgs e)
        {

            int num = int.Parse(balance.Text);

            int rez = num - 100;

            balance.Text = (num - 100).ToString();

            timer1.Interval = 1;

            timer1.Enabled = true;

        }

        private void deneg200_Click(object sender, EventArgs e)
        {

            int num = int.Parse(balance.Text);

            int rez = num - 200;

            balance.Text = (num - 200).ToString();

            timer1.Interval = 1;

            timer1.Enabled = true;

        }

        private void deneg300_Click(object sender, EventArgs e)
        {
            
            int num = int.Parse(balance.Text);

            int rez = num - 500;

            balance.Text = (num - 500).ToString();

            timer1.Interval = 1;  //Интервал(1000 = 1 сек)

            timer1.Enabled = true;

        }

        private void deneg1000_Click(object sender, EventArgs e)
        {

            int num = int.Parse(balance.Text);

            int rez = num - 1000;

            balance.Text = (num - 1000).ToString();

            timer1.Interval = 1;  //Интервал(1000 = 1 сек)

            timer1.Enabled = true;

        }

        private void Back_Click(object sender, EventArgs e)
        {

            this.Hide();

            OperationsUkr op = new OperationsUkr();

            op.balance.Text = this.balance.Text;

            op.Show();

            op.CheckBalance.Dispose();

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

        private void Exit_MouseEnter(object sender, EventArgs e)
        {

            Exit.BackColor = Color.Blue;

        }

        private void Exit_MouseLeave(object sender, EventArgs e)
        {

            Exit.BackColor = Color.Crimson;

        }

    }
}
