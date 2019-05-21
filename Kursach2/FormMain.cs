using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ParkingDataBase
{
    public partial class FormMain : Form
    {
        private static string path = Environment.CurrentDirectory + "/ParkingDataBase.krs";
        public static string password = "____";

        private static int spaceAmount = 30;

        private static bool dataSaved = true;
        public static bool loged = false;

        List<AccountCard> cardList = new List<AccountCard>(spaceAmount); 

        public FormMain()
        {
            InitializeComponent();

            setDefaults();
            initToolTips();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (loadData())
            {

            }
            else
            {
                this.Hide();
                Form enterForm = new FormEnter();
                enterForm.ShowDialog();
                int spaceCounter = cardList.Count;

                while (cardList.Count < spaceAmount)
                {
                    AccountCard emptyCard = AccountCard.CreateEmpty(spaceCounter + 1);
                    cardList.Add(emptyCard);
                    spaceCounter++;
                }
            }
            updateTable();
        }

        private void initToolTips()
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(placeAfterButton, "Укажите фамилию пользователя, после которого необходимо добавить новую запись, в поле справа.");
            toolTip.SetToolTip(targetSurname, "Фамилия пользователя, после которого будет добавлуна новая запись.");
            toolTip.SetToolTip(changePaymentDateButton, "Для изменения требуется указать фамилию пользователя в поле 'Фамилия'.");
            toolTip.SetToolTip(freeSpaceButton, "Вывести список незабронированных мест.");
            toolTip.SetToolTip(getUnpaidButton, "Вывести список клиентов, не оплативших парковку.");
            toolTip.SetToolTip(deleteBySurname, "Удаление записи с указанной фамилией (поле 'Фамилия').");
            toolTip.SetToolTip(toTable, "Для добавления записи в таблицу необходимо заполнить все поля выше.");
            toolTip.SetToolTip(surname, "Может содержать заглавные и строчные буквы, символы '-' и пробелы (Необходим минимум 1 буквенный символ).");
            toolTip.SetToolTip(name, "Может содержать заглавные и строчные буквы, символы '-' и пробелы (Необходим минимум 1 буквенный символ).");
            toolTip.SetToolTip(lastname, "Может содержать заглавные и строчные буквы, символы '-' и пробелы (Необходим минимум 1 буквенный символ).");
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!loged)
            {
                logIn();
                return;
            }
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 6)
                {
                    if (MessageBox.Show("Стереть данные?", "Парковочное место №" + (e.RowIndex + 1), MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        insertTableRow(AccountCard.CreateEmpty(e.RowIndex + 1));
                        debugLog.AppendText("Данные стерты (Парковочное место " + (e.RowIndex + 1) + ")\r\n");
                    }
                    else debugLog.AppendText("Отмена перезаписи\r\n");
                }
                else if(e.ColumnIndex == 3 && isWord((string)dataGridView1[1, e.RowIndex].Value))
                {
                    if(cardList[e.RowIndex].carParked)
                    {
                        cardList[e.RowIndex].carParked = false;
                        dataGridView1[e.ColumnIndex, e.RowIndex].Value = "";
                    }
                    else
                    {
                        cardList[e.RowIndex].carParked = true;
                        dataGridView1[e.ColumnIndex, e.RowIndex].Value = "\u2713";
                    }
                    //debugLog.AppendText(cardList[e.RowIndex].carParked.ToString());
                }
                else if (e.ColumnIndex == 4 && isWord((string)dataGridView1[1, e.RowIndex].Value))
                {
                    if (cardList[e.RowIndex].parkingSpacePaid)
                    {
                        cardList[e.RowIndex].parkingSpacePaid = false;
                        dataGridView1[e.ColumnIndex, e.RowIndex].Value = "";
                    }
                    else
                    {
                        cardList[e.RowIndex].parkingSpacePaid = true;
                        dataGridView1[e.ColumnIndex, e.RowIndex].Value = "\u2713";
                        cardList[e.RowIndex].paymentDate = DateTime.Today;
                        dataGridView1[5, e.RowIndex].Value = DateTime.Today.ToShortDateString();
                    }
                    //debugLog.AppendText(cardList[e.RowIndex].carParked.ToString());
                }
            }
        }

        private void updateTable()
        {
            dataGridView1.Rows.Clear();
            foreach (var card in cardList)
            {
                if (card.paymentDate.AddDays(30) <= DateTime.Today)
                {
                    card.parkingSpacePaid = false;
                }
                dataGridView1.Rows.Add
                (
                    card.parkingSpaceNumber,
                    card.getFullName(),
                    card.carBrand,
                    card.carParked ? "\u2713" : "",
                    card.parkingSpacePaid ? "\u2713" : "",
                    card.getPaymentDate()
                );
            }

            debugLog.Clear();
        }

        private void setDefaults()
        {
            numericUpDown1.Minimum = 1;
            numericUpDown1.Maximum = spaceAmount;

            dateDay.Maximum = DateTime.Today.Day;
            dateMonth.Maximum = DateTime.Today.Month;
            dateYear.Maximum = DateTime.Today.Year;

            dateDay.Value = dateDay.Maximum;
            dateMonth.Value = dateMonth.Maximum;
            dateYear.Value = dateYear.Maximum;
        }

        public static void setTableLength(int length)
        {
            spaceAmount = length;
        }

        public static void setPassword(string newPassword)
        {
            password = newPassword;
        }

        public void saveData()
        {
            FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
            BinaryWriter writer = new BinaryWriter(fileStream);

            writer.Write(password);
            writer.Write(spaceAmount);
            for (int i = 0; i < spaceAmount; i++)
            {
                cardList[i].writeToFile(writer);
            }

            writer.Close();
            fileStream.Close();

            dataSaved = true;
        }

        public bool loadData()
        {
            FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
            BinaryReader reader = new BinaryReader(fileStream);

            try
            {
                password = reader.ReadString();
            }
            catch
            {
                reader.Close();
                fileStream.Close();
                return false;
            }

            if(password == null || !FormEnter.isPassword(password))
            {
                reader.Close();
                fileStream.Close();
                return false;
            }

            spaceAmount = reader.ReadInt32();
            cardList = new List<AccountCard>(spaceAmount);
            int i = 0;
            while(fileStream.CanRead && i < spaceAmount)
            {
                cardList.Add(AccountCard.readFromFile(reader));
                i++;
            }

            reader.Close();
            fileStream.Close();

            return true;
        }

        private void logIn()
        {
            FormPassword request = new FormPassword();
            request.Show();
        }

        private void ToTable_Click(object sender, System.EventArgs e)
        {
            if(!loged)
            {
                logIn();
                return;
            }
            DataGridViewCell selectedCell = dataGridView1.Rows[(int)numericUpDown1.Value - 1].Cells[1];
            if (isWord((string)selectedCell.Value))
            {
                debugLog.AppendText("Поле занято\r\n");

                int spaceNumber = selectedCell.RowIndex + 1;

                if (MessageBox.Show("Перезаписать данные?", "Парковочное место №" + spaceNumber, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (changeCellData((int)numericUpDown1.Value))
                    {
                        dataSaved = false;
                        debugLog.AppendText("Данные перезаписаны (Парковочное место " + spaceNumber + ")\r\n");
                    }
                }
                else debugLog.AppendText("Отмена перезаписи\r\n");
            }
            else
            {
                changeCellData((int)numericUpDown1.Value);
            }
        }

        private bool changeCellData(int spaceNumber)
        {
            if (surname.Text.Length == 0 || !isWord((string)surname.Text))
            {
                debugLog.AppendText("Некорректное значение поля: Фамилия\r\n");
            }
            else if (name.Text.Length == 0 || !isWord((string)name.Text))
            {
                debugLog.AppendText("Некорректное значение поля: Имя\r\n");
            }
            else if (lastname.Text.Length == 0 || !isWord((string)lastname.Text))
            {
                debugLog.AppendText("Некорректное значение поля: Отчество\r\n");
            }
            else if (carBrand.Text.Length == 0)
            {
                debugLog.AppendText("Некорректное значение поля: Автомобиль\r\n");
            }
            else
            {
                AccountCard card = new AccountCard(spaceNumber, name.Text, surname.Text, lastname.Text, carBrand.Text);
                insertTableRow(card);

                debugLog.Clear();
                debugLog.AppendText("Данные занесены в таблицу\r\n");
                dataSaved = false;
                return true;
            }
            return false;
        }

        private void insertTableRow(AccountCard card)
        {
            cardList.RemoveAt(card.parkingSpaceNumber - 1);
            cardList.Insert(card.parkingSpaceNumber - 1, card);

            dataGridView1.Rows.RemoveAt(card.parkingSpaceNumber - 1);
            dataGridView1.Rows.Insert
            (
                card.parkingSpaceNumber - 1,
                card.parkingSpaceNumber,
                card.getFullName(),
                card.carBrand,
                card.carParked ? "\u2713" : "",
                card.parkingSpacePaid ? "\u2713" : "",
                card.getPaymentDate()
            );
            dataSaved = false;
        }

        public bool isWord(string str)
        {
            bool hasLetter = false;
            foreach(char c in str)
            {
                if (!char.IsLetter(c))
                {
                    if (c != ' ' && c != '-') return false;
                }
                else hasLetter = true;
            }
            return hasLetter;
        }

        private void GetUnpaidButton_Click(object sender, System.EventArgs e)
        {
            updateTable();
            debugLog.AppendText("Задолженности:\r\n");
            for (int i = 0; i < spaceAmount; i++)
            {
                if (isWord(cardList[i].getFullName()) && !cardList[i].parkingSpacePaid)
                {
                    debugLog.AppendText("№ парковочного места: " + cardList[i].parkingSpaceNumber.ToString() + "\t");
                    debugLog.AppendText("Ф.И.О. должника: " + cardList[i].getFullName() + "\r\n");
                }
            }
        }

        private void DeleteBySurname_Click(object sender, System.EventArgs e)
        {
            if (!loged)
            {
                logIn();
                return;
            }
            if (!isWord(surname.Text))
            {
                debugLog.AppendText("Некорректное значение поля: Фамилия\r\n");
                return;
            }
            foreach(var card in cardList)
            {
                if(card.getSurname() == surname.Text)
                {
                    if (MessageBox.Show("Удалить данные?", "Парковочное место №" + card.parkingSpaceNumber, MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        insertTableRow(AccountCard.CreateEmpty(card.parkingSpaceNumber));
                        debugLog.AppendText("Данные перезаписаны (Парковочное место " + card.parkingSpaceNumber + ")\r\n");
                        dataSaved = false;
                        return;
                    }
                    else if (MessageBox.Show("Продолжить поиск?", "Поиск других совпадений", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        debugLog.AppendText("Поиск дургих совпадений...\r\n");
                    }
                    else return;
                }
            }
            debugLog.AppendText("Поиск не дал результатов\r\n");
        }

        private void DateYear_ValueChanged(object sender, EventArgs e)
        {
            if(dateYear.Value == DateTime.Today.Year)
            {
                dateDay.Maximum = DateTime.Today.Day;
                dateMonth.Maximum = DateTime.Today.Month;
            }
            else
            {
                dateDay.Maximum = DateTime.DaysInMonth((int)dateYear.Value, (int)dateMonth.Value);
                dateMonth.Maximum = 12;
            }
        }

        private void DateMonth_ValueChanged(object sender, EventArgs e)
        {
            if(dateYear.Value == DateTime.Today.Year && dateMonth.Value == DateTime.Today.Month)
            {
                dateDay.Maximum = DateTime.Today.Day;
            }
            else
            {
                dateDay.Maximum = DateTime.DaysInMonth((int)dateYear.Value, (int)dateMonth.Value);
            }
        }

        private void ChangePaymentDateButton_Click(object sender, EventArgs e)
        {
            if (!loged)
            {
                logIn();
                return;
            }
            if (!isWord(surname.Text))
            {
                debugLog.AppendText("Некорректное значение поля: Фамилия\r\n");
                return;
            }
            foreach (var card in cardList)
            {
                if (card.getSurname() == surname.Text)
                {
                    if (MessageBox.Show("Изменить дату оплаты?", "Парковочное место №" + card.parkingSpaceNumber, MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        DateTime newDate = new DateTime((int)dateYear.Value, (int)dateMonth.Value, (int)dateDay.Value);
                        cardList[card.parkingSpaceNumber - 1].paymentDate = newDate;
                        dataGridView1[5, card.parkingSpaceNumber - 1].Value = newDate.ToShortDateString();
                        debugLog.AppendText("Данные перезаписаны (Парковочное место " + card.parkingSpaceNumber + ")\r\n");
                        dataSaved = false;
                        return;
                    }
                    else if (MessageBox.Show("Продолжить поиск?", "Поиск других совпадений", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        debugLog.AppendText("Поиск дургих совпадений...\r\n");
                    }
                    else return;
                }
            }
            debugLog.AppendText("Поиск не дал результатов\r\n");
        }

        private void FreeSpaceButton_Click(object sender, EventArgs e)
        {
            debugLog.Clear();
            debugLog.AppendText("Свободные места:\r\n");
            for (int i = 0; i < spaceAmount; i++)
            {
                if (!isWord(cardList[i].getFullName()))
                    debugLog.AppendText(cardList[i].parkingSpaceNumber.ToString() + "\t");
            }
        }

        private void PlaceAfterButton_Click(object sender, EventArgs e)
        {
            if (!loged)
            {
                logIn();
                return;
            }
            if (!isWord(targetSurname.Text))
            {
                debugLog.AppendText("Некорректное значение поля: укажите запись, после которой производить добавление.\r\n");
                return;
            }
            foreach (var card in cardList)
            {
                if (card.getSurname() == targetSurname.Text)
                {
                    if (card.parkingSpaceNumber == spaceAmount) continue;
                    if (isWord(cardList[card.parkingSpaceNumber].getFullName()))
                    {
                        debugLog.AppendText("Парковочное место №" + (card.parkingSpaceNumber + 1) + " уже забронировано.\r\n");
                        return;
                    }
                    if (MessageBox.Show("Добавить запись?", "Парковочное место №" + (card.parkingSpaceNumber + 1), MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        changeCellData(card.parkingSpaceNumber + 1);
                        debugLog.AppendText("Данные перезаписаны (Парковочное место " + (card.parkingSpaceNumber + 1) + ")\r\n");
                        dataSaved = false;
                        return;
                    }
                    else if (MessageBox.Show("Продолжить поиск?", "Поиск других совпадений", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        debugLog.AppendText("Поиск дургих совпадений...\r\n");
                    }
                    else return;
                }
            }
            debugLog.AppendText("Подходящее место не найдено.\r\n");
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!dataSaved) saveData();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveData();
        }

        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateTable();
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            helpTextBox.Visible = !helpTextBox.Visible;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            debugLog.Clear();
            if(!isWord(surname.Text))
            {
                debugLog.AppendText("Некорректное значение поля: Фамилия\r\n");
                return;
            }
            debugLog.AppendText("Поиск по фамилии:\r\n");
            int counter = 0;
            for (int i = 0; i < spaceAmount; i++)
            {
                if (cardList[i].getSurname().Equals(surname.Text))
                {
                    debugLog.AppendText("Ф.И.О. клиента: " + cardList[i].getFullName() + "\t");
                    debugLog.AppendText("№ парковочного места: " + cardList[i].parkingSpaceNumber.ToString() + "\t");
                    debugLog.AppendText("Автомобиль клиента: " + cardList[i].carBrand + "\r\n");
                    counter++;
                }
            }

            if(counter == 0) debugLog.AppendText("Поиск не дал результатов.\r\n");
        }
    }
}
