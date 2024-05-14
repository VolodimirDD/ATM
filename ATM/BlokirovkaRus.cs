using System;
using System.Windows.Forms;

namespace Курсовая_Имитация_банкомата_
{
    public partial class BlokirovkaRus : Form
    {
        public BlokirovkaRus()
        {
            InitializeComponent();

            InitializeFormAppearance();
            InitializeTimer();
            DisplayLockMessage();
        }

        private void InitializeFormAppearance()
        {
            this.BackgroundImage = Properties.Resources.Блок_карты;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.CenterToScreen();
            MaximizeBox = false;
            MinimizeBox = false;
            this.ControlBox = false;
            this.label1.BackColor = System.Drawing.Color.Transparent;
        }

        private void InitializeTimer()
        {
            timer1.Enabled = true;
            timer1.Interval = 3000;
            timer1.Tick += timer1_Tick_1;
        }

        private void DisplayLockMessage()
        {
            label1.Text = "Ваша карта заблокирована для меры предосторожности!";
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Application.Exit();
        }

        private void BlokirovkaRus_Move(object sender, EventArgs e)
        {
            this.Move += delegate { this.Capture = false; };
        }
    }
}