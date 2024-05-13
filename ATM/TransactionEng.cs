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
    public partial class TransactionEng : Form
    {
        public TransactionEng()
        {
            InitializeComponent();

            this.BackgroundImage = Properties.Resources.Ввод_пинкода;

            this.BackgroundImageLayout = ImageLayout.Stretch;

            karta.MaxLength = 16;

            pop.Enabled = false;

            vvodkolichestva.Enabled = false;

            perevod.Enabled = false;

            summa.Enabled = false;

            label1.Text = "Your balance :";

            MaximizeBox = false;

            MinimizeBox = false;

            this.ControlBox = false;

            this.CenterToScreen();

            PodtverditTelefon.Select();

            balance.TabStop = false;

            this.label1.BackColor = System.Drawing.Color.Transparent;

            this.label2.BackColor = System.Drawing.Color.Transparent;

            this.label3.BackColor = System.Drawing.Color.Transparent;

            this.label4.BackColor = System.Drawing.Color.Transparent;

            this.label5.BackColor = System.Drawing.Color.Transparent;

        }

        private void PodtverditTelefon_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.MaskFull == true)
            {

                (sender as Button).Enabled = false;

                maskedTextBox1.Enabled = false;

                PodtverditTelefon.Enabled = false;

                pop.Enabled = true;

                vvodkolichestva.Enabled = true;

                label3.Text = "";

            }


            else
            {

                maskedTextBox1.Enabled = true;

                PodtverditTelefon.Enabled = true;

                pop.Enabled = false;

                vvodkolichestva.Enabled = false;

                label3.Text = "Enter the correct phone number!";

            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {

            this.Hide();

            VihodEng z = new VihodEng();

            z.Show();

        }


        private void perevod_Click(object sender, EventArgs e)
        {
            if (summa.Text != "0")
            {
                if (summa.Text != String.Empty)
                {

                    if (int.Parse(summa.Text) > int.Parse(balance.Text))
                    {

                        label5.Text = "Not enough money in the account!";

                    }
                    else
                    {

                        long num = long.Parse(balance.Text);

                        long rez = num - long.Parse(summa.Text);

                        balance.Text = rez.ToString();

                        label5.Text = "";

                        timer2.Interval = 1;   //Интервал(1000 = 1 сек)

                        timer2.Enabled = true;

                    }

                }

                else
                {

                    label5.Text = "Enter the transfer amount!";

                }
            }
            else
            {

                label5.Text = "Invalid value!";

            }

        }

        private void perevodnakartu_Click(object sender, EventArgs e)
        {
            if (karta.TextLength == 16)
            {

                (sender as Button).Enabled = false;

                karta.Enabled = false;

                perevod.Enabled = true;

                summa.Enabled = true;

                label2.Text = "";

            }

            else
            {

                karta.Enabled = true;

                perevodnakartu.Enabled = true;

                perevod.Enabled = false;

                summa.Enabled = false;

                label2.Text = "There are 16 digits in the card. Check the input!";

            }

        }

        private void pop_Click(object sender, EventArgs e)
        {
            if (vvodkolichestva.Text != "0")
            {
                if (vvodkolichestva.Text != String.Empty)
                {

                    if (long.Parse(vvodkolichestva.Text) > long.Parse(balance.Text))
                    {

                        label4.Text = "Not enough money in the account!";

                    }
                    else
                    {

                        long num = long.Parse(balance.Text);

                        long rez = num - long.Parse(vvodkolichestva.Text);

                        balance.Text = rez.ToString();

                        label4.Text = "";

                        timer1.Interval = 1;   //Интервал(1000 = 1 сек)

                        timer1.Enabled = true;

                    }
                }
                else
                {

                    label4.Text = "Enter the transfer amount!";

                }
            }
            else
            {

                label4.Text = "Invalid value!";

            }
        }

        private void Back_Click(object sender, EventArgs e)
        {

            this.Hide();

            OperationsEng op1 = new OperationsEng();

            op1.balance.Text = this.balance.Text;

            op1.Show();

            op1.CheckBalance.Dispose();

        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {

                e.Handled = true;

            }
        }

        private void karta_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {

                e.Handled = true;

            }
        }

        private void vvodkolichestva_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {

                e.Handled = true;

            }
        }

        private void summa_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {

                e.Handled = true;

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            timer1.Enabled = false;

            ToUpPhoneNumberEng Form63 = new ToUpPhoneNumberEng();

            Form63.Show();


        }

        private void TransactionEng_Move(object sender, EventArgs e)
        {

            this.Move += delegate { this.Capture = false; };

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            timer2.Enabled = false;

            ToUpCardEng g1 = new ToUpCardEng();

            g1.Show();

        }

        private void PodtverditTelefon_MouseEnter(object sender, EventArgs e)
        {

            PodtverditTelefon.BackColor = Color.Red;

        }

        private void perevodnakartu_MouseEnter(object sender, EventArgs e)
        {

            perevodnakartu.BackColor = Color.Red;

        }

        private void pop_MouseEnter(object sender, EventArgs e)
        {

            pop.BackColor = Color.Lime;

        }

        private void perevod_MouseEnter(object sender, EventArgs e)
        {

            perevod.BackColor = Color.Lime;

        }

        private void Back_MouseEnter(object sender, EventArgs e)
        {

            Back.BackColor = Color.Gold;

        }

        private void Exit_MouseEnter(object sender, EventArgs e)
        {

            Exit.BackColor = Color.Blue;

        }

        private void PodtverditTelefon_MouseLeave(object sender, EventArgs e)
        {

            PodtverditTelefon.BackColor = Color.White;

        }

        private void perevodnakartu_MouseLeave(object sender, EventArgs e)
        {

            perevodnakartu.BackColor = Color.White;

        }

        private void pop_MouseLeave(object sender, EventArgs e)
        {

            pop.BackColor = Color.White;

        }

        private void perevod_MouseLeave(object sender, EventArgs e)
        {

            perevod.BackColor = Color.White;

        }

        private void Back_MouseLeave(object sender, EventArgs e)
        {

            Back.BackColor = Color.Crimson;

        }

        private void Exit_MouseLeave(object sender, EventArgs e)
        {

            Exit.BackColor = Color.Crimson;

        }
    }
}
