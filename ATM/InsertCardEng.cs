﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace Курсовая_Имитация_банкомата_
{
    public partial class InsertCardEng : Form
    {
        public InsertCardEng()
        {
            InitializeComponent();

            this.BackgroundImage = Properties.Resources.Фон_дефолт;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            karta.BackgroundImage = Properties.Resources.Карта_монобанк;
            karta.BackgroundImageLayout = ImageLayout.Stretch;
            karta.BorderStyle = BorderStyle.Fixed3D;

            vstavka.BackgroundImageLayout = ImageLayout.Stretch;
            vstavka.BackColor = Color.Transparent;

            this.CenterToScreen();

            shel.BackgroundImage = Properties.Resources.Щель_для_карты;
            shel.BackgroundImageLayout = ImageLayout.Stretch;

            label1.Text = "Insert your card please";
            label1.BackColor = Color.Transparent;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.AutoSize = true; 
            int topMargin = 40;
            label1.Location = new Point((this.ClientSize.Width - label1.Width) / 2, topMargin); 

            // Отключаем кнопки управления 
            MaximizeBox = false;
            MinimizeBox = false;
            this.ControlBox = false;
        }

        // Перетаскивание карты
        private void karta_MouseClick(object sender, MouseEventArgs e)
        {
            karta.DoDragDrop(karta.BackgroundImage, DragDropEffects.Copy);
        }

        private void karta_MouseDown(object sender, MouseEventArgs e)
        {
            karta.DoDragDrop(karta.BackgroundImage, DragDropEffects.Copy);
        }

        private void vstavka_DragDrop(object sender, DragEventArgs e)
        {
            label1.Text = "Card inserted!";
            vstavka.BackgroundImage = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            vstavka.BackgroundImageLayout = ImageLayout.Stretch;
            karta.Dispose();

            timer1.Interval = 1500;
            timer1.Enabled = true;
        }

        private void vstavka_DragEnter(object sender, DragEventArgs e)
        {
            label1.Text = "Release the card!";
            e.Effect = e.AllowedEffect;
        }

        private void vstavka_DragLeave(object sender, EventArgs e)
        {
            label1.Text = "Insert the card into the marked area!";
        }

        private void InsertCardEng_Load(object sender, EventArgs e)
        {
            vstavka.AllowDrop = true;
        }

        // Обработчик события таймера
        private void timer1_Tick(object sender, EventArgs e)
        {
            Hide();
            timer1.Enabled = false;

            RecognitionEng recognition = new RecognitionEng();
            recognition.Show();
        }

        private void InsertCardEng_Move(object sender, EventArgs e)
        {
            this.Move += delegate { this.Capture = false; };
        }
    }
}