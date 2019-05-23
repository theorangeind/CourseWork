using System;
using System.Windows.Forms;

namespace ParkingDataBase
{
    public partial class FormEnter : Form //класс формы создания базы
    {
        public FormEnter()
        {
            InitializeComponent();
        }

        private void FormEnter_FormClosed(object sender, FormClosedEventArgs e) //если форма была закрыта, выйти из программы
        {
            Application.Exit();
        }

        private void StartButton_Click(object sender, EventArgs e) //кнопка "Начало работы"
        {
            if(createPassword.Text.Equals(checkPassword.Text)) //проверка совпадения паролей в полях создания и подтверждения
            {
                if (isPassword(checkPassword.Text)) //проверка допустимости пароля
                {
                    //запрос о создании новой базы
                    if (MessageBox.Show("Создать базу данных? Количество парковочных мест: " + tableLength.Value, "Начало работы", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        FormMain.setPassword(createPassword.Text); //передача пароля главной форме
                        FormMain.setTableLength((int)tableLength.Value); //установка размера таблицы в главной форме
                        Hide();
                    }
                    return;
                }
                else MessageBox.Show("Пароль не соответствует требованиям.");
            }
            else MessageBox.Show("Пароли не совпадают.");
        }

        public static bool isPassword(string pw) //метод для проверки пароля на наличие недопустимых символов
        {
            if (pw.Length < 4) return false; //если пароль короче 4 символов, вернуть false

            int normalSymbols = 0; //счетчик подходящих символов (исключая _ )
            foreach (char c in pw)
            {
                if (char.IsLetter(c) || char.IsNumber(c))
                {
                    normalSymbols++;
                }
                else if (c != '_') return false;
            }
            return normalSymbols > 3;
        }
    }
}
