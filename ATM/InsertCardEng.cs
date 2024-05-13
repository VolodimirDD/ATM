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
    public partial class InsertCardEng : Form
    {
        public InsertCardEng()
        {

            InitializeComponent();

            this.BackgroundImage = Properties.Resources.Фон_дефолт;     //Добавления BackgroundImage программно

            this.BackgroundImageLayout = ImageLayout.Stretch;       //Что бы картинка не выходила за пределы формы и не обрезалась  

            karta.BackgroundImage = Properties.Resources.Карта_монобанк;     //Добавления BackgroundImage программно

            karta.BackgroundImageLayout = ImageLayout.Stretch;       //Что бы картинка не выходила за пределы формы и не обрезалась  

            karta.BorderStyle = BorderStyle.Fixed3D;        //Установка BorderStyle программно

            this.CenterToScreen();      //Установка формы по центру экрана програмно

            vstavka.BackgroundImageLayout = ImageLayout.Stretch;        //Что бы картинка не выходила за пределы формы и не обрезалась  

            vstavka.BackColor = Color.Transparent; ;        //Делаем поле vstavka прозрачным

            shel.BackgroundImage = Properties.Resources.Щель_для_карты;     //Добавления BackgroundImage программно

            shel.BackgroundImageLayout = ImageLayout.Stretch;       //Что бы картинка не выходила за пределы формы и не обрезалась  

            label1.Text = "Insert your card please";        //Присвоение текста программно

            MaximizeBox = false;

            MinimizeBox = false;

            this.ControlBox = false;

            this.label1.BackColor = System.Drawing.Color.Transparent;

        }

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

            vstavka.BackgroundImage = (Bitmap)e.Data.GetData(DataFormats.Bitmap); //Передача данных

            vstavka.BackgroundImageLayout = ImageLayout.Stretch;       //Что бы картинка не выходила за пределы формы и не обрезалась

            karta.Dispose();        //Удаление объекта karta

            timer1.Interval = 1500;  //интервал(1000 = 1 сек). Спустя 1 секунду запустется таймер. Если поставить 10000, то форма 2 повиться через 10 сек;

            timer1.Enabled = true;      //запускаем таймер

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

        private void InsertCardEng_Move(object sender, EventArgs e)
        {

            this.Move += delegate { this.Capture = false; };

        }

        private void InsertCardEng_Load(object sender, EventArgs e)
        {

            vstavka.AllowDrop = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            Hide();

            timer1.Enabled = false;     //Останавливаем таймер

            RecognitionEng recognition = new RecognitionEng();        //Создаем экземпляр формы

            recognition.Show();       //Открывем другую форму

        }
    }
}
