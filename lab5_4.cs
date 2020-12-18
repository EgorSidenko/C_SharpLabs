using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab5_1;
namespace lab5_3App
{
    class Program
    {

        static int TwoElemCollections(CollectionType<object>[] arr)
        {
            int count = 0;
            foreach (CollectionType<object> collection in arr)
            {
                if (collection.Count == 2)
                    count++;
            }
            return count;
        }
        //res[0] = IndexOfMax  res[1] = IndexOfMin
        static int[] MaxAndMin(CollectionType<object>[] arr)
        {
            int[] res = new int[2];
            int tmp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Count > tmp)
                {
                    tmp = arr[i].Count;
                    res[0] = i;
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Count < tmp)
                {
                    tmp = arr[i].Count;
                    res[1] = i;
                }
            }
            return res;
        }
        static void Main(string[] args)
        {
            string ask = "no";
            for (;ask == "no"; )
            { 
                CollectionType<object>[] array = new CollectionType<object>[100];
            Random r = new Random();
            for (int i = 0; i < 100; i++)
            {
                array[i] = new CollectionType<object>();
                for (int j = 0; j < r.Next(0, 100); j++)
                {
                    Random e = new Random();
                    array[i].Add(e);

                }
            }
            Console.WriteLine($"There are {TwoElemCollections(array)} collections with 2 elements");
            int[] max_min = MaxAndMin(array);
            Console.WriteLine($"Index of biggest collection : {max_min[0]}");
            Console.WriteLine($"Index of smallest collection : {max_min[1]}");
                Console.WriteLine("End?");
                ask = Console.ReadLine();
            }
        }
    }
}
