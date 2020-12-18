using System;
using System.Collections.Generic;
using Lab5_1;
namespace Practise
{
    class Program
    {
        class lab5_1
        {

            static void Main(string[] args)
            {
                CollectionType<int> test = new CollectionType<int>();
                test.Add(240);
                Console.Write(test[0]);
            }
        }
    }
}
