using System;
using System.Windows.Forms;

namespace Курсовая_Имитация_банкомата_
{
    public partial class SelectLanguage : Form
    {
        public SelectLanguage()
        {
            InitializeComponent();

            //прозрачный фон для меток
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            label3.BackColor = System.Drawing.Color.Transparent;

            //фон формы
            this.BackgroundImage = Properties.Resources.Фон_дефолт;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            //форму по центру экрана
            this.CenterToScreen();

            //изображения и прозрачный фон для PictureBox'ов
            pictureBoxukr.BackgroundImage = Properties.Resources.Флаг_Украины;
            pictureBoxrus.BackgroundImage = Properties.Resources.Флаг_России;
            pictureBoxeng.BackgroundImage = Properties.Resources.Флаг_Великобритании;
            pictureBoxukr.BackgroundImageLayout = pictureBoxrus.BackgroundImageLayout = pictureBoxeng.BackgroundImageLayout = ImageLayout.Stretch;

            //текст меток
            label1.Text = "Будь ласка, оберіть мову";
            label2.Text = "Пожалуйста, выберите язык";
            label3.Text = "Please, select a language";

            // Отключаем кнопки управления 
            MaximizeBox = false;
            MinimizeBox = false;
            this.ControlBox = false;
        }

        private void pictureBoxukr_Click(object sender, EventArgs e)
        {
            Hide(); // Скрываем текущую форму
            InsertCardUkr ukr = new InsertCardUkr(); // Создаем экземпляр формы InsertCardUkr
            ukr.Show(); // Показываем форму InsertCardUkr
        }

        private void pictureBoxrus_Click(object sender, EventArgs e)
        {
            Hide();
            InsertCardRus rus = new InsertCardRus();
            rus.Show();
        }

        private void pictureBoxeng_Click(object sender, EventArgs e)
        {
            Hide();
            InsertCardEng eng = new InsertCardEng();
            eng.Show();
        }

        private void SelectLanguage_Move(object sender, EventArgs e)
        {
            this.Move += delegate { this.Capture = false; };
        }
    }
}