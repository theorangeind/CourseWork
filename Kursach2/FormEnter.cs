using System;
using System.Windows.Forms;

namespace ParkingDataBase
{
    public partial class FormEnter : Form
    {
        public FormEnter()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void FormEnter_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if(createPassword.Text.Equals(checkPassword.Text))
            {
                if (isPassword(checkPassword.Text))
                {
                    if (MessageBox.Show("Создать базу данных? Количество парковочных мест: " + tableLength.Value, "Начало работы", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        FormMain.setPassword(createPassword.Text);
                        FormMain.setTableLength((int)tableLength.Value);
                        Hide();
                    }
                    return;
                }
                else MessageBox.Show("Пароль не соответствует требованиям.");
            }
            else MessageBox.Show("Пароли не совпадают.");
        }

        public static bool isPassword(string pw)
        {
            if (pw.Length < 4) return false;

            int normalSymbols = 0;
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
