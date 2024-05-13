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
    public partial class SelectLanguage : Form
    {
        public SelectLanguage()
        {

            InitializeComponent();

            this.label1.BackColor = System.Drawing.Color.Transparent;

            this.label2.BackColor = System.Drawing.Color.Transparent;

            this.label3.BackColor = System.Drawing.Color.Transparent;

            this.BackgroundImage = Properties.Resources.Фон_дефолт;     //Добавления BackgroundImage программно

            this.BackgroundImageLayout = ImageLayout.Stretch;       //Что бы картинка не выходила за пределы формы и не обрезалась

            pictureBoxukr.BackgroundImage = Properties.Resources.Флаг_Украины;      //Добавления BackgroundImage программно для pictureBox

            pictureBoxukr.BackgroundImageLayout = ImageLayout.Stretch;      //Что бы картинка не выходила за пределы кнопки и не обрезалась

            pictureBoxrus.BackgroundImage = Properties.Resources.Флаг_России;        //Добавления BackgroundImage программно для pictureBox

            pictureBoxrus.BackgroundImageLayout = ImageLayout.Stretch;     //Что бы картинка не выходила за пределы кнопки и не обрезалась

            pictureBoxeng.BackgroundImage = Properties.Resources.Флаг_Великобритании;       //Добавления BackgroundImage программно для pictureBox

            pictureBoxeng.BackgroundImageLayout = ImageLayout.Stretch;      //Что бы картинка не выходила за пределы кнопки и не обрезалась

            this.CenterToScreen();      //Установка формы по центру экрана програмно

            label1.Text = "Будь ласка , оберіть мову";

            label2.Text = "Пожалуйста , выберите язык";

            label3.Text = "Please , select a language";

            MaximizeBox = false;

            MinimizeBox = false;

            this.ControlBox = false;

        }

        private void pictureBoxukr_Click(object sender, EventArgs e)
        {

            Hide();     //Свернуть текущую форму

            InsertCardUkr rus = new InsertCardUkr();    //Экземпляр класса 

            rus.Show();       //Открыть форму 

        }

        private void pictureBoxrus_Click(object sender, EventArgs e)
        {
            Hide();     //Свернуть текущую форму

            InsertCardRus rus = new InsertCardRus();    //Экземпляр класса 

            rus.Show();       //Открыть форму 

        }

        private void pictureBoxeng_Click(object sender, EventArgs e)
        {

            Hide();     //Свернуть текущую форму

            InsertCardEng eng = new InsertCardEng();    //Экземпляр класса 

            eng.Show();       //Открыть форму 

        }

        private void SelectLanguage_Move(object sender, EventArgs e)
        {

            this.Move += delegate { this.Capture = false; };

        }

    }
}
