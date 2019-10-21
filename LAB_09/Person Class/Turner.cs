using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_09.Person_Class
{
    class Turner : Working
    {
        private int discharge; // разряд

        public Turner() : base()
        {
        }

        public Turner(string firstName, string lastName, int age, string placeOfWork, int discharge, int salary) : base(firstName, lastName, age, placeOfWork, salary)
        {
            this.discharge = discharge;
        }

        public override string ToString()
        {
            return $"First Name: {this.FirstName}\nLast Name: {this.LastName}\nAge: {this.Age}\nPlace of Work: {this.PlaceOfWork}\nDischarge: {this.discharge}";
        }

        public void Raise(int money)
        {
            this.Salary += money;
            Console.WriteLine($"Я: {this.FirstName} {this.LastName}\nМоя зарпалата увеличилась на {money}, теперь она {this.Salary}");
        }

        public void Fine(int money)
        {
            this.Salary -= money;
            Console.WriteLine($"Я: {this.FirstName} {this.LastName}\nЯ получил(-а) штраф {money}, теперь моя зарпалата {this.Salary}");
        }

        public override void Sleep()
        {
            Console.WriteLine("Сплю 8 часов в сутки...");
        }

    }
}
