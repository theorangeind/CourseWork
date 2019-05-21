using System;
using System.Windows.Forms;

namespace ParkingDataBase
{
    public partial class FormPassword : Form
    {
        public FormPassword()
        {
            InitializeComponent();
        }

        private void AgreePasswordButton_Click(object sender, EventArgs e)
        {
            if (passwordBox.Text.Equals(FormMain.password))
            {
                FormMain.loged = true;
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
