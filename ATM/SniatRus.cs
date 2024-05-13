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
    public partial class SniatRus : Form
    {
        public SniatRus()
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

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();

            OperationsRus op = new OperationsRus();

            op.balance.Text = this.balance.Text;

            op.Show();

            op.CheckBalance.Dispose();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num = int.Parse(balance.Text);

            int rez = num - 100;

            balance.Text = (num - 100).ToString();

            timer1.Interval = 1;

            timer1.Enabled = true;      

        }

        private void button3_Click(object sender, EventArgs e)
        {

            int num = int.Parse(balance.Text);

            int rez = num - 200;

            balance.Text = (num - 200).ToString();

            timer1.Interval = 1;  

            timer1.Enabled = true;      

        }

        private void button4_Click(object sender, EventArgs e)
        {

            int num = int.Parse(balance.Text);

            int rez = num - 500;

            balance.Text = (num - 500).ToString();

            timer1.Interval = 1;  //Интервал(1000 = 1 сек)

            timer1.Enabled = true;      

        }

        private void button5_Click(object sender, EventArgs e)
        {

            int num = int.Parse(balance.Text);

            int rez = num - 1000;

            balance.Text = (num - 1000).ToString();

            timer1.Interval = 1;  //Интервал(1000 = 1 сек)

            timer1.Enabled = true;      

        }

        private void Exit_Click(object sender, EventArgs e)
        {

            this.Hide();

            VihodRus z = new VihodRus();

            z.Show();

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

            WithdrawalProcessRus Form1234 = new WithdrawalProcessRus();

            Form1234.Show();
           
            timer1.Enabled = false;
                      
        }

        private void SniatRus_Move(object sender, EventArgs e)
        {

            this.Move += delegate { this.Capture = false; };

        }

        private void Exit_MouseEnter(object sender, EventArgs e)
        {

            Exit.BackColor = Color.Blue;

        }

        private void Exit_MouseLeave(object sender, EventArgs e)
        {

            Exit.BackColor = Color.Crimson;

        }

        private void Back_MouseEnter(object sender, EventArgs e)
        {

            Back.BackColor = Color.Gold;

        }

        private void Back_MouseLeave(object sender, EventArgs e)
        {

            Back.BackColor = Color.Crimson;

        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {

            deneg100.BackColor = Color.Magenta;

        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {

            deneg100.BackColor = Color.White;

        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {

            deneg200.BackColor = Color.Magenta;

        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {

            deneg200.BackColor = Color.White;

        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {

            deneg300.BackColor = Color.Magenta;

        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {

            deneg300.BackColor = Color.White;

        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {

            deneg1000.BackColor = Color.Magenta;

        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {

            deneg1000.BackColor = Color.White;

        }
    }

}
