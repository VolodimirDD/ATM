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
    public partial class OperationsEng : Form
    {
        public OperationsEng()
        {

            InitializeComponent();

            this.BackgroundImage = Properties.Resources.Ввод_пинкода;

            this.BackgroundImageLayout = ImageLayout.Stretch;

            this.CenterToScreen();      //Установка формы по центру экрана програмно

            balance.ReadOnly = true;

            sniat.Enabled = false;

            popolnit.Enabled = false;

            Tranzaksii.Enabled = false;

            MaximizeBox = false;

            MinimizeBox = false;

            this.ControlBox = false;

            CheckBalance.Select();

            balance.TabStop = false;

        }

        private void popolnit_Click(object sender, EventArgs e)
        {

            if (balance.Text.Length != 0)
            {

                this.Hide();

                PopovnitEng fm1 = new PopovnitEng();

                fm1.balance.Text = this.balance.Text;

                fm1.Show();

            }

        }

        private void sniat_Click(object sender, EventArgs e)
        {
            if (balance.Text.Length != 0)
            {

                this.Hide();

                SniatEng fm2 = new SniatEng();

                fm2.balance.Text = this.balance.Text;

                fm2.Show();

            }
        }

        private void Tranzaksii_Click(object sender, EventArgs e)
        {

            if (balance.Text.Length != 0)
            {

                this.Hide();

                TransactionEng perevodi = new TransactionEng();

                perevodi.balance.Text = this.balance.Text;

                perevodi.Show();

            }

        }

        private void CheckBalance_Click(object sender, EventArgs e)
        {

            Random RandomClass = new Random();

            int num1;

            num1 = RandomClass.Next(5000, 10000);

            balance.Text = num1.ToString();

            (sender as Button).Enabled = false;

        }

        private void zavershit_Click(object sender, EventArgs e)
        {
          
            this.Hide();

            VihodEng z = new VihodEng();  

            z.Show(); 
            
        }

        private void OperationsEng_Move(object sender, EventArgs e)
        {

            this.Move += delegate { this.Capture = false; };

        }

        private void balance_TextChanged(object sender, EventArgs e)
        {
            if (balance.Text.Length == 0)
            {

                sniat.Enabled = false;

                popolnit.Enabled = false;

                Tranzaksii.Enabled = false;

            }
            else
            {

                sniat.Enabled = true;

                popolnit.Enabled = true;

                Tranzaksii.Enabled = true;

            }
        }

        private void popolnit_MouseEnter(object sender, EventArgs e)
        {

            popolnit.BackColor = Color.DeepPink;

        }

        private void sniat_MouseEnter(object sender, EventArgs e)
        {

            sniat.BackColor = Color.DeepPink;

        }

        private void Tranzaksii_MouseEnter(object sender, EventArgs e)
        {

            Tranzaksii.BackColor = Color.DeepPink;

        }

        private void CheckBalance_MouseEnter(object sender, EventArgs e)
        {

            CheckBalance.BackColor = Color.Red;

        }

        private void zavershit_MouseEnter(object sender, EventArgs e)
        {

            zavershit.BackColor = Color.Blue;

        }

        private void popolnit_MouseLeave(object sender, EventArgs e)
        {

            popolnit.BackColor = Color.White;

        }

        private void sniat_MouseLeave(object sender, EventArgs e)
        {

            sniat.BackColor = Color.White;

        }

        private void Tranzaksii_MouseLeave(object sender, EventArgs e)
        {

            Tranzaksii.BackColor = Color.White;

        }

        private void CheckBalance_MouseLeave(object sender, EventArgs e)
        {

            CheckBalance.BackColor = Color.White;

        }

        private void zavershit_MouseLeave(object sender, EventArgs e)
        {

            zavershit.BackColor = Color.Crimson;

        }

    }
}
