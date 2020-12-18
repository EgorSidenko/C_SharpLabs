/*****************************************************/
/* Лабораторная работа No 3                          */
/* Наследование и полиморфизм                        */
/* Задание 3                                         */
/* Выполнил студент гр. 525б Cіденко Є.В             */
/*****************************************************/
using System;
using lab03lib_Seva;

namespace Practise
{
    class Program 
    {
        public static void Input_Info(Printed_Edition p)
        { 
            for (;;)
            {
                try
                {
                    Console.Write("\tInput name: ");
                    p.Name = Console.ReadLine();
                    Console.Write("\tInput number of pages:");
                    p.Pages = int.Parse(Console.ReadLine());
                    Console.Write("\tInput number of chapters: ");
                    p.Chapters = int.Parse(Console.ReadLine());
                    Console.Write("\tInput price in USD: ");
                    p.Price = double.Parse(Console.ReadLine());
                    Console.Write("\tInput number of goods: ");
                    p.Quantity = int.Parse(Console.ReadLine());
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("\t\t[Invalid input!]\n");
                    Console.WriteLine("\t\tNew input");
                    continue;
                }
                break;
            }
        }
        static void Main(string[] args)
        {
            Printed_Edition[] arr = new Printed_Edition[2];
            Magazine magazine = new Magazine();
            Book book = new Book();
            Console.WriteLine("Input book inforamtion");
            Input_Info(book);
            Console.WriteLine("\nInput magazine inforamtion");
            Input_Info(magazine);
            arr[0] = book;
            arr[1] = magazine;
            for (; ; )
            {
                string[] action;
                int i;
                Console.WriteLine("\nInput 1 to choose book or 2 to choose magazine");
                int.TryParse(Console.ReadLine(), out i);
                i--;
                Console.WriteLine("\t\t\t\tActions: ");
                Console.WriteLine("\t[sn] 'name' to set name            [gn] to get name");
                Console.WriteLine("\t[sp] 'pages' to set pages          [gp] to get pages");
                Console.WriteLine("\t[sc] 'chapters' to set chapters    [gc] to get chapters;");
                Console.WriteLine("\t[sr] 'price' to set price          [gp] to get price ");
                Console.WriteLine("\t[sq] 'quantity' to set quantity    [gq] to get quantity");
                Console.WriteLine("\t[pa] to print all info             [ex] to exit");
                Console.WriteLine("Input action: ");
                action = Console.ReadLine().Split(' ');
                if (action[0] == "sn")
                    arr[0].Name = action[1];
                try
                {
                    if (action[0] == "sp")
                        arr[0].Pages = int.Parse(action[1]);
                    if (action[0] == "sc")
                        arr[0].Chapters = int.Parse(action[1]);
                    if (action[0] == "sp")
                        arr[0].Price = double.Parse(action[1]);
                    if (action[0] == "sq")
                        arr[0].Quantity = int.Parse(action[1]);
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Invalid input!");
                }
                if (action[0] == "gn")
                    Console.WriteLine($"Name: {arr[i].Name}");
                if (action[0] == "gp")
                    Console.WriteLine($"Pages: {arr[i].Pages}");
                if (action[0] == "gc")
                    Console.WriteLine($"Chapters: {arr[i].Chapters}");
                if (action[0] == "gp")
                    Console.WriteLine($"Price: {arr[i].Price}");
                if (action[0] == "gq")
                    Console.WriteLine($"Quantity: {arr[i].Quantity}");
                if (action[0] == "pa")
                    Console.WriteLine(arr[i].GetInfo());
                if (action[0] == "ex")
                    break;

            }
            
        }
    }
}