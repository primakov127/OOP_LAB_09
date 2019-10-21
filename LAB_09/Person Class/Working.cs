using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_09.Person_Class
{
    abstract class Working : Person
    {
        protected string PlaceOfWork;
        protected int Salary;

        public Working() : base()
        {

        }

        public Working(string firstName, string lastName, int age, string placeOfWork, int salary) : base(firstName, lastName, age)
        {
            this.PlaceOfWork = placeOfWork;
            this.Salary = salary;
        }

        public override string ToString()
        {
            return $"First Name: {this.FirstName}\nLast Name: {this.LastName}\nAge: {this.Age}\nPlace of Work: {this.PlaceOfWork}";
        }

        public override void GetMoney()
        {
            Console.WriteLine("Получаю зарплату");
        }
    }
}
