using System;
using System.IO;

namespace ParkingDataBase
{
    class AccountCard //класс структуры учетной карты владельца парковочного места
    {
        public int parkingSpaceNumber { get; set; } //номер парк. места

        public string[] fullName; //массив полного имени клиента (имя, фамилия, отчество)
        public string carBrand { get; set; } //марка автомобиля

        public bool carParked { get; set; } //отметка о наличии автомобиля на стоянке
        public bool parkingSpacePaid { get; set; } = true; //отметка о наличии оплаты за текущий месяц

        public DateTime paymentDate; //дата последней оплаты

        //конструктор класса
        public AccountCard(int parkingSpace, string name, string secondName, string lastName, string carBrand)
        {
            string[] personName = { name, secondName, lastName };
            this.fullName = personName;
            this.carBrand = carBrand;
            this.parkingSpaceNumber = parkingSpace;
            this.paymentDate = DateTime.Today;
        }

        public void setFullName(string name, string secondName, string lastName) //метод задания имени
        {
            this.fullName[0] = name;
            this.fullName[1] = secondName;
            this.fullName[2] = lastName;
        }

        public string getFullName() //метод для получения полного имени в виде строки
        {
            return $"{fullName[1]} {fullName[0]} {fullName[2]}";
        }

        public string getSurname() //метод для получения фамилии в виде строки
        {
            return fullName[1];
        }

        public static AccountCard CreateEmpty(int parkingSpace) //метод создания пустой учетной карты
        {
            AccountCard emptyCard = new AccountCard(parkingSpace, " ", " ", " ", " ");
            emptyCard.parkingSpacePaid = false;
            emptyCard.paymentDate = DateTime.MinValue;
            return emptyCard;
        }

        public string getPaymentDate() //метод для получения даты оплаты в виде строки
        {
            if (this.paymentDate != DateTime.MinValue) return this.paymentDate.ToShortDateString();
            return "";
        }

        public void writeToFile(BinaryWriter output) //метод записи данных карты в файл
        {
            output.Write(this.parkingSpaceNumber);
            output.Write(this.fullName[0]);
            output.Write(this.fullName[1]);
            output.Write(this.fullName[2]);
            output.Write(this.carBrand);
            output.Write(this.carParked);
            output.Write(this.parkingSpacePaid);
            output.Write(paymentDate.Day);
            output.Write(paymentDate.Month);
            output.Write(paymentDate.Year);
        }

        public static AccountCard readFromFile(BinaryReader input) //метод чтения карты из файла
        {
            int space = input.ReadInt32(); //считывание парковочного места
            AccountCard readenCard = AccountCard.CreateEmpty(space); //создание пустой карты для дальнейшей записи информации
            //чтение основных данных
            readenCard.fullName[0] = input.ReadString();
            readenCard.fullName[1] = input.ReadString();
            readenCard.fullName[2] = input.ReadString();
            readenCard.carBrand = input.ReadString();
            readenCard.carParked = input.ReadBoolean();
            readenCard.parkingSpacePaid = input.ReadBoolean();
            //чтение даты оплаты
            int pDay = input.ReadInt32();
            int pMonth = input.ReadInt32();
            int pYear = input.ReadInt32();
            readenCard.paymentDate = new DateTime(pYear, pMonth, pDay);

            return readenCard;
        }
    }
}
