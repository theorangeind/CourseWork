using System;
using System.Windows.Forms;

namespace ParkingDataBase
{
    public partial class FormPassword : Form //класс формы запроса пароля
    {
        public FormPassword()
        {
            InitializeComponent();
        }

        private void AgreePasswordButton_Click(object sender, EventArgs e) //кнопка подтверждения ввода
        {
            if (passwordBox.Text.Equals(FormMain.password)) //проверка правильности пароля
            {
                FormMain.loged = true; //установка флага доступа в главной форме
                this.Close();
                return;
            }
            else
            {
                MessageBox.Show("Неверный пароль.");
            }
        }
    }
}
