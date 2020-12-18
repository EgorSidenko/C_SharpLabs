using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab04Lib;

namespace Lab04App
{
    class Program
    {
        static void CreateObject(List<Matrix> list)
        {   
            list.Add(new Matrix());
            Console.WriteLine("Creating Matrix object:");
            list[list.Count-1].Input();
        }
            static void Main(string[] args)
        {
            int ListInteretionFirstElement = 0;
            bool AskToExitFromProgram = false;
            List<Matrix> list = new List<Matrix>();

            if (list.Count == 0)
                CreateObject(list);
            for (; ; )
            {
                /*
                 * All those opperation go to AskForOperation
                 * variable
                 * c - to create new matrix 
                 * e - to exit 
                 * s - show how many object was created
                 */
                Console.WriteLine($"Input index of another object from 0 " +
                    $"to {list.Count-1} to perform operations that require two objects");
                Console.WriteLine($"[c] - create new object \t[s] - show already created object from " +
                    $"0 to {list.Count-1}\n[e] - to exit\t\t\t[opr] - to make opiration between two matrix");
                string AskToMakeOperation = Console.ReadLine();
                if (AskToMakeOperation == "c")
                {
                    CreateObject(list);
                }
                if(AskToMakeOperation == "s")
                {
                    Console.WriteLine($"Object have been already created from 0 to {list.Count - 1}");
                    ListInteretionFirstElement = int.Parse(Console.ReadLine());
                    Console.WriteLine($"{(string)list[ListInteretionFirstElement]}");
                }
                if (AskToMakeOperation == "e")
                {
                    AskToExitFromProgram = true;
                    break;
                }
                if(AskToMakeOperation == "opr")
                {
                    Console.WriteLine($"Object have been already created from 0 to {list.Count - 1}" +
                        $"\nChoose №1 matrix:");
                    int ChooseTheMatrix1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Choose №2 matrix");
                    int ChooseTheMatrix2 = int.Parse(Console.ReadLine());
                    for (; ; )
                    {
                        /* There is accessibile
                         * [+] [-] [*]
                         * [==], [>], [<], [>=], [<=], [!=]
                         * toString - implicit
                         * toDouble - explicit
                         */
                        Console.WriteLine("Choose the operator between two matrix" +
                            "\n\t[+],[-],[*] - math opr\n" +
                            "\t[==][>][<][>=][<=][!=] - bool opr");
                        AskToMakeOperation = Console.ReadLine();
                        if (AskToMakeOperation == "+")
                        {
                            list[ChooseTheMatrix1] += list[ChooseTheMatrix2];
                            break;
                        }
                        if (AskToMakeOperation == "-")
                        {
                            list[ChooseTheMatrix1] -= list[ChooseTheMatrix2];
                            break;
                        }
                        if (AskToMakeOperation == "*")
                        {
                            list[ChooseTheMatrix1] *= list[ChooseTheMatrix2];
                            break;
                        }
                        if (AskToMakeOperation == "==")
                        {
                           Console.WriteLine(list[ChooseTheMatrix1]==list[ChooseTheMatrix2]);
                            break;
                        }
                        if (AskToMakeOperation == ">")
                        {
                            Console.WriteLine(list[ChooseTheMatrix1] > list[ChooseTheMatrix2]);
                            break;
                        }
                        if (AskToMakeOperation == "<")
                        {
                            Console.WriteLine(list[ChooseTheMatrix1] < list[ChooseTheMatrix2]);
                            break;
                        }
                        if (AskToMakeOperation == ">=")
                        {
                            Console.WriteLine(list[ChooseTheMatrix1] >= list[ChooseTheMatrix2]);
                            break;
                        }
                        if (AskToMakeOperation == "<=")
                        {
                            Console.WriteLine(list[ChooseTheMatrix1] <= list[ChooseTheMatrix2]);
                            break;
                        }
                        if (AskToMakeOperation == "!=")
                        {
                            Console.WriteLine(list[ChooseTheMatrix1] != list[ChooseTheMatrix2]);
                            break;
                        }
                    }
                }
                if (AskToExitFromProgram)
                    break;
            }

        }
    }
}
