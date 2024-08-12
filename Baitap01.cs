using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Section_02
{
    internal class Baitap01
    {
        static void Main(string[] args)
        {
            int val = 55;
            Console.WriteLine("Hello " + "World");
            Console.WriteLine("Value = " + val); //concatenated string
            Console.WriteLine("Value = {0}", val); //Formatted String
            Baitap02();
        }
        static void Baitap02()
        {
            var name = "Mark";
            var date = DateTime.Now;

            
            Console.WriteLine("Hello, {0}! Today is {1}, it's {2:HH:mm} now", name, date.DayOfWeek, date);
            Console.WriteLine($"Hello, {name}! Today is {date.DayOfWeek},"+$"it's {date:HH:mm} now");
            Console.Write("Enter value:");
            String userInput = Console.ReadLine();
            int intVal = Convert.ToInt32(userInput);
            Console.WriteLine("You entered {0}", intVal);
            Console.Write("Enter value:");
            userInput = Console.ReadLine();
            double doubleVal = Convert.ToDouble(userInput);
            Console.WriteLine("You entered {0}", doubleVal);
            Console.Write("Kq cong hai so:");
            Console.WriteLine($"{intVal+doubleVal}");

        }

    }
}
