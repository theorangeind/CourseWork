using System;
using System.IO;

namespace ParkingDataBase
{
    class AccountCard
    {
        public int parkingSpaceNumber { get; set; }

        public string[] fullName;
        public string carBrand { get; set; }

        public bool carParked { get; set; }
        public bool parkingSpacePaid { get; set; } = true;

        public DateTime paymentDate;

        public AccountCard(int parkingSpace, string name, string secondName, string lastName, string carBrand)
        {
            string[] personName = { name, secondName, lastName };
            this.fullName = personName;
            this.carBrand = carBrand;
            this.parkingSpaceNumber = parkingSpace;
            this.paymentDate = DateTime.Today;
        }

        public void setFullName(string name, string secondName, string lastName)
        {
            this.fullName[0] = name;
            this.fullName[1] = secondName;
            this.fullName[2] = lastName;
        }

        public string getFullName()
        {
            return $"{fullName[1]} {fullName[0]} {fullName[2]}";
        }

        public string getSurname()
        {
            return fullName[1];
        }

        public static AccountCard CreateEmpty(int parkingSpace)
        {
            AccountCard emptyCard = new AccountCard(parkingSpace, " ", " ", " ", " ");
            emptyCard.parkingSpacePaid = false;
            emptyCard.paymentDate = DateTime.MinValue;
            return emptyCard;
        }

        public string getPaymentDate()
        {
            if (this.paymentDate != DateTime.MinValue) return this.paymentDate.ToShortDateString();
            return "";
        }

        public void writeToFile(BinaryWriter output)
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

        public static AccountCard readFromFile(BinaryReader input)
        {
            int space = input.ReadInt32();
            AccountCard readenCard = AccountCard.CreateEmpty(space);
            readenCard.fullName[0] = input.ReadString();
            readenCard.fullName[1] = input.ReadString();
            readenCard.fullName[2] = input.ReadString();
            readenCard.carBrand = input.ReadString();
            readenCard.carParked = input.ReadBoolean();
            readenCard.parkingSpacePaid = input.ReadBoolean();
            int pDay = input.ReadInt32();
            int pMonth = input.ReadInt32();
            int pYear = input.ReadInt32();
            readenCard.paymentDate = new DateTime(pYear, pMonth, pDay);

            return readenCard;
        }
    }
}
