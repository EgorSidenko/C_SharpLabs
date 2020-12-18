/*****************************************************/
/* Лабораторная работа No 2                          */
/* Абстрактные сущности и связи между ними           */
/* Задание 2                                         */
/* Выполнил студент гр. 525б Cіденко Є.В             */
/*****************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sidenko.Lab02.Task02.ClassLib;
//ELECTROLUX, SIEMENTS, CANDY, Sumsung
namespace Lab02App
{
    class Program
    {
        static void Main(string[] args)
        {
            int count;
            bool dw1 = false, dw2 = false, dw3 = false, dw4 = false, dw5 = false;
            //Empty 
            DishWasher DishWash1 = new DishWasher();
            int DW1 = DishWash1.numb();
            //Only brand
            DishWasher DishWash2 = new DishWasher("ELECTROLUX");
            int DW2 = DishWash2.numb();

            //Brand and model
            DishWasher DishWash3 = new DishWasher("Sumsung", "DW60M50");
            int DW3 = DishWash3.numb();
            //Only mode
            DishWasher DishWash4 = new DishWasher(1);
            int DW4 = DishWash4.numb();
            //Brand, model and mode
            DishWasher DishWash5 = new DishWasher("CANDY", "WE32M45", 3);
            int DW5 = DishWash4.numb();

            DishWash1.ShowDW();
            DishWash2.ShowDW();
            DishWash3.ShowDW();
            DishWash4.ShowDW();
            DishWash5.ShowDW();
            //Turn on the dishwaher
            Console.WriteLine("\nWitch dishwasher turn on?");
            int ask = int.Parse(Console.ReadLine());
            switch (ask)
            {
                case 1: { dw1 = DishWash1.switchOn(dw1); break; }
                case 2: { dw2 = DishWash2.switchOn(dw2); break; }
                case 3: { dw3 = DishWash3.switchOn(dw3); break; }
                case 4: { dw4 = DishWash4.switchOn(dw4); break; }
                case 5: { dw5 = DishWash5.switchOn(dw5); break; }
                default: { Console.WriteLine("Wrong input"); break; }
            }
            
            if (dw1)
            {
                Console.WriteLine("You are turned on dishwaher number {0}: ", DW1);
                Console.WriteLine("Input on of three operations on DishWasher: \nNext mode(Next)\nPrevius mode(Back)\nTurn Off(TurnOff)");
                while (dw1) { 
                    string str = Console.ReadLine();
                    switch (str)
                    {
                        case "Next": DishWash1.NextMode(); break;
                        case "Back": DishWash1.PrevMode(); break;
                        case "TurnOff":
                            {
                                Console.WriteLine("You are turned off the first DishWaher");
                                dw1 = DishWash1.switchOff(dw1); break;
                            }
                        default: break;
                    }
                }
            }
            if (dw2)
            {
                Console.WriteLine("You are turned on dishwaher number {0}: ", DW2);
                Console.WriteLine("Input on of three operations on DishWasher: \nNext mode(Next)\nPrevius mode(Back)\nTurn Off(TurnOff)");
                while (dw2)
                {
                    string str = Console.ReadLine();
                    switch (str)
                    {
                        case "Next": DishWash2.NextMode(); break;
                        case "Back": DishWash2.PrevMode(); break;
                        case "TurnOff":
                            {
                                Console.WriteLine("You are turned off the second DishWaher");
                                dw2 = DishWash2.switchOff(dw2); break;
                            }
                        default: break;
                    }
                }
            }
            if (dw3)
            {
                Console.WriteLine("You are turned on dishwaher number {0}: ", DW3);
                Console.WriteLine("Input on of three operations on DishWasher: \nNext mode(Next)\nPrevius mode(Back)\nTurn Off(TurnOff)");
                while (dw3)
                {
                    string str = Console.ReadLine();
                    switch (str)
                    {
                        case "Next": DishWash3.NextMode(); break;
                        case "Back": DishWash3.PrevMode(); break;
                        case "TurnOff":
                            {
                                Console.WriteLine("You are turned off the third DishWaher");
                                dw3 = DishWash3.switchOff(dw3); break;
                            }
                        default: break;
                    }
                }
            }
            if (dw4)
            {
                Console.WriteLine("You are turned on dishwaher number {0}: ", DW4);
                Console.WriteLine("Input on of three operations on DishWasher: \nNext mode(Next)\nPrevius mode(Back)\nTurn Off(TurnOff)");
                while (dw4)
                {
                    string str = Console.ReadLine();
                    switch (str)
                    {
                        case "Next": DishWash4.NextMode(); break;
                        case "Back": DishWash4.PrevMode(); break;
                        case "TurnOff":
                            {
                                Console.WriteLine("You are turned off the fourth DishWaher");
                                dw4 = DishWash4.switchOff(dw4); break;
                            }
                        default: break;
                    }
                }
            }
            if (dw5)
            {
                Console.WriteLine("You are turned on dishwaher number {0}: ", DW5);
                Console.WriteLine("Input on of three operations on DishWasher: \nNext mode(Next)\nPrevius mode(Back)\nTurn Off(TurnOff)");
                while (dw5)
                {
                    string str = Console.ReadLine();
                    switch (str)
                    {
                        case "Next": DishWash5.NextMode(); break;
                        case "Back": DishWash5.PrevMode(); break;
                        case "TurnOff":
                            {
                                Console.WriteLine("You are turned off the third DishWaher");
                                dw5 = DishWash5.switchOff(dw5); break;
                            }
                        default: break;
                    }
                }
            }
        }
    }
}
