using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab5_1;
using Lab5_2;
using System.Diagnostics;
using System.Collections;
namespace lab5_4App
{
    class Program
    {
        void RandomData(int amount, ArrayList alis, List<School> list, School[] arr, CollectionType<School> collection)
        {
            Random r = new Random();
            for (int i = 0; i < amount; i++)
            {
                School p = new School();
                p.Amount_Pupils = r.Next(0, Int32.MaxValue) / 100;
                alis.Add(p);
                list.Add(new School());
                arr[i] = new School();
                collection.Add(new School());
                list[i].Amount_Pupils = r.Next(0, Int32.MaxValue) / 100;
                arr[i].Amount_Pupils = r.Next(0, Int32.MaxValue) / 100;
                collection[i].Amount_Pupils = r.Next(0, Int32.MaxValue) / 100;
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            int amount;
            Console.WriteLine("Input number of elements: ");
            for (; ; )
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out amount))
                    break;
            }
            Stopwatch sw = new Stopwatch();
            ArrayList alis = new ArrayList(amount);
            List<School> list = new List<School>(amount);
            School[] arr = new School[amount];
            CollectionType<School> collection = new CollectionType<School>(amount);
            p.RandomData(amount, alis, list, arr, collection);
            sw.Start();
            alis.Sort();
            sw.Stop();
            TimeSpan duration = sw.Elapsed;
            Console.WriteLine("ArrayList : {0}", duration.ToString());
            sw.Reset();
            sw.Start();
            list.Sort();
            sw.Stop();
            duration = sw.Elapsed;
            Console.WriteLine("List : {0}", duration.ToString());
            sw.Reset();
            sw.Start();
            Array.Sort(arr);
            sw.Stop();
            duration = sw.Elapsed;
            Console.WriteLine("Array : {0}", duration.ToString());
            sw.Reset();
            sw.Start();
            collection.Sort();
            sw.Stop();
            duration = sw.Elapsed;
            Console.WriteLine("CollectionType : {0}", duration.ToString());
        }
    }
}
