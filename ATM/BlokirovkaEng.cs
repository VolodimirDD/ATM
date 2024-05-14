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
    public partial class BlokirovkaEng : Form
    {
        public BlokirovkaEng()
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
            timer1.Tick += timer1_Tick;
        }

        private void DisplayLockMessage()
        {
            label1.Text = "Your card is locked as a precaution!";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            timer1.Enabled = false;
            Application.Exit();

        }

        private void BlokirovkaEng_Move(object sender, EventArgs e)
        {
            this.Move += delegate { this.Capture = false; };
        }
    }
}
