﻿using System;
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
    public partial class ToUpPhoneNumberUkr : Form
    {
        public ToUpPhoneNumberUkr()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.BackgroundImage = Properties.Resources.Процессы;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            timer1.Enabled = true;
            timer1.Tick += new EventHandler(timer1_Tick);
            progressBar1.Maximum = max;
            timer2.Enabled = true;
            label1.Text = "Процес виконується ...";
            timer3.Enabled = true;
            MaximizeBox = false;
            MinimizeBox = false;
            this.ControlBox = false;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            timer2.Interval = 4000;
            timer3.Interval = 3500;
        }

        int i = 0;

        int max = 50;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (max != progressBar1.Value)
            {
                progressBar1.Value = i;
                i++;
            }

            if (i > max)
            {
                timer1.Enabled = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            this.Hide();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            label1.Text = "Процес завершено!";
            timer3.Enabled = false;
        }

        private void ToUpPhoneNumberUkr_Move(object sender, EventArgs e)
        {
            this.Move += delegate { this.Capture = false; };
        }
    }
}