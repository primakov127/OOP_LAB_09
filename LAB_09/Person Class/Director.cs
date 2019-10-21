using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_09.Person_Class
{
    class Director : Working
    {
        public delegate void SalaryHandler(int money);
        
        public event SalaryHandler Raise;
        public event SalaryHandler Fine;

        public Director() : base()
        {

        }

        public Director(string firstName, string lastName, int age, string placeOfWork, int salary) : base(firstName, lastName, age, placeOfWork, salary)
        {
            
        }

        public override void Sleep()
        {
            Console.WriteLine("Сплю как Директор!");
        }

        //public void Rise(Working man)
        //{
            
        //}

        public void TakeRaise(int money)
        {
            Raise(money);
        }

        public void TakeFine(int money)
        {
            Fine(money);
        }

    }
}
