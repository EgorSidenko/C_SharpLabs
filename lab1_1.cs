using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Title = "Task01";
            Console.WindowHeight = 20;
            Console.WindowWidth = 30;
            Console.Beep();
            Console.WriteLine("Input your name: ");
            string s = Console.ReadLine();
            Console.WriteLine("Hello, {0}!", s);
            DateTime dt = DateTime.Now;
            Console.WriteLine("Today is {0}, {1:D2}.{2:D2}.{3:D2}", dt.DayOfWeek, dt.Day, dt.Month, dt.Year);
            Console.Beep();

            Console.WriteLine("Время сейчас: {0}", DateTime.Now);

            Console.WriteLine("До Нового Года осталось:");
            var today = DateTime.Today;
            var newYear = new DateTime(today.Year + 0, 12, 31);
            var days = (newYear - today).TotalDays;
            Console.WriteLine("{0} дней.", days);
            Console.Beep();
        }
    }
}
