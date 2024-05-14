using System;
using System.Drawing;
using System.Windows.Forms;

namespace Курсовая_Имитация_банкомата_
{
    public partial class InsertCardUkr : Form
    {
        public InsertCardUkr()
        {
            InitializeComponent();

            this.BackgroundImage = Properties.Resources.Фон_дефолт;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            karta.BackgroundImage = Properties.Resources.Карта_монобанк;
            karta.BackgroundImageLayout = ImageLayout.Stretch;
            karta.BorderStyle = BorderStyle.Fixed3D;

            vstavka.BackgroundImageLayout = ImageLayout.Stretch;
            vstavka.BackColor = Color.Transparent;

            shel.BackgroundImage = Properties.Resources.Щель_для_карты;
            shel.BackgroundImageLayout = ImageLayout.Stretch;

            this.CenterToScreen();

            label1.Text = "Вставте свою карту, будь ласка!";
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

        private void karta_MouseDown(object sender, MouseEventArgs e)
        {
            karta.DoDragDrop(karta.BackgroundImage, DragDropEffects.Copy);
        }

        private void InsertCardUkr_Load(object sender, EventArgs e)
        {
            vstavka.AllowDrop = true;
        }

        private void karta_MouseClick(object sender, MouseEventArgs e)
        {
            karta.DoDragDrop(karta.BackgroundImage, DragDropEffects.Copy);
        }

        private void vstavka_DragEnter(object sender, DragEventArgs e)
        {
            label1.Text = "Відпустіть карту!";
            e.Effect = e.AllowedEffect;
        }

        private void vstavka_DragDrop(object sender, DragEventArgs e)
        {
            label1.Text = "Карта вставлена!";
            vstavka.BackgroundImage = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            vstavka.BackgroundImageLayout = ImageLayout.Stretch;
            karta.Dispose();

            timer1.Interval = 1500;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Hide();
            timer1.Enabled = false;

            RecognitionUkr recognition = new RecognitionUkr();
            recognition.Show();
        }

        private void vstavka_DragLeave(object sender, EventArgs e)
        {
            label1.Text = "Вставте карту в зазначену зону!";
        }

        private void InsertCardUkr_Move(object sender, EventArgs e)
        {
            this.Move += delegate { this.Capture = false; };
        }
    }
}