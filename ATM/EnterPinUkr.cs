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
    public partial class EnterPinUkr : Form
    {
        public EnterPinUkr()
        {
            InitializeComponent();

            pinkod.ReadOnly = true;

            this.CenterToScreen();      //Установка формы по центру экрана програмно

            pinkod.MaxLength = 4;

            pinkod.PasswordChar = '*';

            this.BackgroundImage = Properties.Resources.Ввод_пинкода;     //Добавления BackgroundImage программно

            this.BackgroundImageLayout = ImageLayout.Stretch;       //Что бы картинка не выходила за пределы формы и не обрезалась

            Fon.BackgroundImage = Properties.Resources.Ввод_пин;     //Добавления BackgroundImage программно

            Fon.BackgroundImageLayout = ImageLayout.Stretch;       //Что бы картинка не выходила за пределы формы и не обрезалась

            one.BackgroundImage = Properties.Resources.Один;

            one.BackgroundImageLayout = ImageLayout.Stretch;       //Что бы картинка не выходила за пределы формы и не обрезалась

            two.BackgroundImage = Properties.Resources.Два;

            two.BackgroundImageLayout = ImageLayout.Stretch;       //Что бы картинка не выходила за пределы формы и не обрезалась

            three.BackgroundImage = Properties.Resources.Три;

            three.BackgroundImageLayout = ImageLayout.Stretch;       //Что бы картинка не выходила за пределы формы и не обрезалась

            four.BackgroundImage = Properties.Resources.Четыре;

            four.BackgroundImageLayout = ImageLayout.Stretch;       //Что бы картинка не выходила за пределы формы и не обрезалась

            five.BackgroundImage = Properties.Resources.Пять;

            five.BackgroundImageLayout = ImageLayout.Stretch;       //Что бы картинка не выходила за пределы формы и не обрезалась

            six.BackgroundImage = Properties.Resources.Шесть;

            six.BackgroundImageLayout = ImageLayout.Stretch;       //Что бы картинка не выходила за пределы формы и не обрезалась

            seven.BackgroundImage = Properties.Resources.Семь;

            seven.BackgroundImageLayout = ImageLayout.Stretch;       //Что бы картинка не выходила за пределы формы и не обрезалась

            eight.BackgroundImage = Properties.Resources.Восемь;

            eight.BackgroundImageLayout = ImageLayout.Stretch;       //Что бы картинка не выходила за пределы формы и не обрезалась

            nine.BackgroundImage = Properties.Resources.Девять;

            nine.BackgroundImageLayout = ImageLayout.Stretch;       //Что бы картинка не выходила за пределы формы и не обрезалась

            nul.BackgroundImage = Properties.Resources.Ноль;

            nul.BackgroundImageLayout = ImageLayout.Stretch;       //Что бы картинка не выходила за пределы формы и не обрезалась

            enter.BackgroundImage = Properties.Resources.Записать;

            enter.BackgroundImageLayout = ImageLayout.Stretch;       //Что бы картинка не выходила за пределы формы и не обрезалась

            clear.BackgroundImage = Properties.Resources.Очистить;

            clear.BackgroundImageLayout = ImageLayout.Stretch;       //Что бы картинка не выходила за пределы формы и не обрезалась

            MaximizeBox = false;

            MinimizeBox = false;

            this.ControlBox = false;

            enter.Select();

            this.label1.BackColor = System.Drawing.Color.Transparent;

            this.label2.BackColor = System.Drawing.Color.Transparent;

            label2.Text = "Введіть ваш pin-code!";

            enter.Select();
        }

        int a = 0;

        private void one_Click(object sender, EventArgs e)
        {
            if (pinkod.TextLength < 4)
            {

                pinkod.Text = pinkod.Text + "1";

            }
        }

        private void two_Click(object sender, EventArgs e)
        {
            if (pinkod.TextLength < 4)
            {

                pinkod.Text = pinkod.Text + "2";

            }
        }

        private void three_Click(object sender, EventArgs e)
        {
            if (pinkod.TextLength < 4)
            {

                pinkod.Text = pinkod.Text + "3";

            }
        }

        private void four_Click(object sender, EventArgs e)
        {
            if (pinkod.TextLength < 4)
            {

                pinkod.Text = pinkod.Text + "4";

            }
        }

        private void five_Click(object sender, EventArgs e)
        {
            if (pinkod.TextLength < 4)
            {

                pinkod.Text = pinkod.Text + "5";

            }
        }

        private void six_Click(object sender, EventArgs e)
        {
            if (pinkod.TextLength < 4)
            {

                pinkod.Text = pinkod.Text + "6";

            }
        }

        private void clear_Click(object sender, EventArgs e)
        {

            pinkod.Clear();

        }

        private void seven_Click(object sender, EventArgs e)
        {
            if (pinkod.TextLength < 4)
            {

                pinkod.Text = pinkod.Text + "7";

            }
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (pinkod.TextLength < 4)
            {

                pinkod.Text = pinkod.Text + "8";

            }
        }

        private void nine_Click(object sender, EventArgs e)
        {
            if (pinkod.TextLength < 4)
            {

                pinkod.Text = pinkod.Text + "9";

            }
        }

        private void enter_Click(object sender, EventArgs e)
        {
            if ((pinkod.Text.Length > 4) || (pinkod.Text.Length < 4))
            {

                label1.Text = ("Введіть коректний pin!");

            }

            else
            {

                if (a < 2)
                {

                    if (pinkod.Text == "1111")
                    {

                        this.Hide();

                        OperationsUkr opr = new OperationsUkr();

                        opr.Show();

                    }

                    else
                    {

                        a = a + 1; label1.Text = "Неправильний PIN-code";

                        pinkod.Text = "";

                    }

                }

                else
                {

                    Close();        //Закрываем форму       

                    BlokirovkaUkr gm123 = new BlokirovkaUkr();      //Создаем экземпляр формы

                    gm123.Show();       //Открываем форму

                }

            }
        }

        private void nul_Click(object sender, EventArgs e)
        {

            if (pinkod.TextLength < 4)
            {

                pinkod.Text = pinkod.Text + "0";

            }

        }

        private void EnterPinUkr_Move(object sender, EventArgs e)
        {

            this.Move += delegate { this.Capture = false; };

        }

        private void pinkod_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)

                e.Handled = true;

            pinkod.MaxLength = 4;

        }
    }
}
