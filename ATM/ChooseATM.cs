using System;
using System.Drawing;
using System.Windows.Forms;

namespace Курсовая_Имитация_банкомата_
{
    public partial class ChooseATM : Form
    {
        public ChooseATM()
        {
            InitializeComponent(); 

            bank1.BackColor = Color.Transparent;
            bank2.BackColor = Color.Transparent;
            bank3.BackColor = Color.Transparent;
            bank4.BackColor = Color.Transparent;
            bank5.BackColor = Color.Transparent;

            //фон формы
            this.BackgroundImage = Properties.Resources.Банкомат;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            //форму по центру экрана
            this.CenterToScreen();

            // Отключаем кнопки управления 
            MaximizeBox = false;
            MinimizeBox = false;
            this.ControlBox = false;
        }
       
        private void bank1_Click(object sender, EventArgs e)
        {
            Hide(); // Скрываем текущую форму
            SelectLanguage Form2 = new SelectLanguage(); // Создаем экземпляр формы SelectLanguage
            Form2.Show(); // Показываем форму SelectLanguage
        }

        private void bank2_Click(object sender, EventArgs e)
        {
            Hide();
            SelectLanguage Form2 = new SelectLanguage();
            Form2.Show();
        }

        private void bank3_Click(object sender, EventArgs e)
        {
            Hide();
            SelectLanguage Form2 = new SelectLanguage();
            Form2.Show();
        }

        private void bank4_Click(object sender, EventArgs e)
        {
            Hide();
            SelectLanguage Form2 = new SelectLanguage();
            Form2.Show();
        }

        private void bank5_Click(object sender, EventArgs e)
        {
            Hide();
            SelectLanguage Form2 = new SelectLanguage();
            Form2.Show();
        }

        private void ChooseATM_Move(object sender, EventArgs e)
        {
            this.Move += delegate { this.Capture = false; };
        }
    }
}