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

    public partial class ChooseATM : Form
    {
        public ChooseATM()
        {

            InitializeComponent();      // Инициализация 

            bank1.BackColor = Color.Transparent;         //PictureBox bank1 для выбора банкомата невидимая! Установлен прозрачный фон.

            bank2.BackColor = Color.Transparent;         //PictureBox bank2 для выбора банкомата невидимая! Установлен прозрачный фон.

            bank3.BackColor = Color.Transparent;         //PictureBox bank3 для выбора банкомата невидимая! Установлен прозрачный фон.

            bank4.BackColor = Color.Transparent;         //PictureBox bank4 для выбора банкомата невидимая! Установлен прозрачный фон.

            bank5.BackColor = Color.Transparent;         //PictureBox bank5 для выбора банкомата невидимая! Установлен прозрачный фон.

            this.BackgroundImage = Properties.Resources.Банкомат;     //Добавления BackgroundImage программно

            this.BackgroundImageLayout = ImageLayout.Stretch;       //Что бы картинка не выходила за пределы формы и не обрезалась

            this.CenterToScreen();      //Установка формы по центру экрана програмно

            //Убираем кнопки на форме програмно
            MaximizeBox = false;

            MinimizeBox = false;

            this.ControlBox = false;

        }

        private void bank1_Click(object sender, EventArgs e)
        {

            Hide();     //Свернуть текущую форму

            SelectLanguage Form2 = new SelectLanguage();    //Экземпляр класса Form2

            Form2.Show();       //Открыть форму Form2

        }

        private void bank2_Click(object sender, EventArgs e)
        {
            Hide();     //Свернуть текущую форму

            SelectLanguage Form2 = new SelectLanguage();    //Экземпляр класса Form2

            Form2.Show();       //Открыть форму Form2

        }

        private void bank3_Click(object sender, EventArgs e)
        {
            Hide();     //Свернуть текущую форму

            SelectLanguage Form2 = new SelectLanguage();    //Экземпляр класса Form2

            Form2.Show();       //Открыть форму Form2
        }

        private void bank4_Click(object sender, EventArgs e)
        {
            Hide();     //Свернуть текущую форму

            SelectLanguage Form2 = new SelectLanguage();    //Экземпляр класса Form2

            Form2.Show();       //Открыть форму Form2
        }

        private void bank5_Click(object sender, EventArgs e)
        {
            Hide();     //Свернуть текущую форму

            SelectLanguage Form2 = new SelectLanguage();    //Экземпляр класса Form2

            Form2.Show();       //Открыть форму Form2
        }

        private void ChooseATM_Move(object sender, EventArgs e)
        {

            this.Move += delegate { this.Capture = false; };    //delegate - Записанные переменные в this, ControlCaprute

        }
    }
}
