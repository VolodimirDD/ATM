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
    public partial class BlokirovkaRus : Form
    {
        public BlokirovkaRus()
        {
            InitializeComponent();

            this.BackgroundImage = Properties.Resources.Блок_карты;

            this.BackgroundImageLayout = ImageLayout.Stretch;

            this.CenterToScreen();      //Установка формы по центру экрана програмно         

            MaximizeBox = false;

            MinimizeBox = false;

            this.ControlBox = false;

            timer1.Enabled = true;

            timer1.Interval = 3000;

            label1.Text = "Ваша карта заблокирована для меры предосторожности!";

            this.label1.BackColor = System.Drawing.Color.Transparent;


        }

        private void BlokirovkaRus_Move(object sender, EventArgs e)
        {
            this.Move += delegate { this.Capture = false; };
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            Application.Exit();     //Заканчиваем программу
        }
    }
}
