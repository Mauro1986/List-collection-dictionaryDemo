using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(2);
            arrayList.Add(5);
            arrayList.Add(130);
            arrayList.Add(3);

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------------------------");

            arrayList.Add(55);
            arrayList.Add(77);

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
