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
    public partial class VihodRus : Form
    {
        public VihodRus()
        {

            InitializeComponent();

            timer1.Enabled = true;

            timer1.Interval = 3000;

            label1.Text = "Спасибо , что выбираете наш сервис :D";

            this.label1.BackColor = System.Drawing.Color.Transparent;

            this.BackgroundImage = Properties.Resources.Конец;

            this.BackgroundImageLayout = ImageLayout.Stretch;

            this.CenterToScreen();

            MaximizeBox = false;

            MinimizeBox = false;

            this.ControlBox = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            timer1.Enabled = false;

            Application.Exit();     //Заканчиваем программу

        }

        private void VihodRus_Move(object sender, EventArgs e)
        {

            this.Move += delegate { this.Capture = false; };

        }
   
    }
}
