using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] {1,2,3 };

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("****************************");
            Array.Resize(ref array, 6);
            array[6] = 9;

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }


    }
}
