using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_09
{
    class Program
    {
        static void Main(string[] args)
        {
            #region First part of Task
            Person_Class.Director man1 = new Person_Class.Director("Maxim", "Primakov", 18, "EPAM", 1500);
            Person_Class.Turner man2 = new Person_Class.Turner("Nikita", "Divanov", 25, "EPAM", 4, 300);
            Person_Class.Turner man3 = new Person_Class.Turner("Katya", "Drobusheva", 22, "EPAM", 2, 400);


            man1.Raise += man2.Raise;
            man1.Raise += man3.Raise;

            man1.Fine += man3.Fine;

            man1.TakeRaise(42);
            man1.TakeFine(50);
            #endregion First part of Task

            #region Second part of Task
            //string Data = "This, is sentense! with? puntctuation..";
            //Action<string> action;
            //action = (str) => Console.WriteLine(PunctuationDelete(str));
            //action += (str) => Console.WriteLine(str.ToUpper());
            //action += (str) => Console.WriteLine(str.ToLower());

            //action(Data);


            #endregion Second part of Task


        }

        static string PunctuationDelete(string data)
        {
            char[] punctuation = { '.', ',', '!', '?', ';', ':', '-' };
            
            int puntctuationCount = data.Where(s => punctuation.Contains(s)).Count();
            string temp = new string(data.Select(s => (punctuation.Contains(s) ? ' ' : s)).ToArray());
            string result = string.Join(" ", temp.Split(new[] { ' ' },
                            StringSplitOptions.RemoveEmptyEntries));

            return result;
        }
    }
}
