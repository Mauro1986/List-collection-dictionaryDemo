using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QeueDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Queue<int> NextId = new Queue<int>();
            //NextId.Enqueue(1);
            //NextId.Enqueue(2);
            //NextId.Enqueue(3);
            //NextId.Enqueue(4);

            //Console.WriteLine($"total element {NextId.Count}");

            //while (NextId.Count > 0)
            //{
            //    Console.WriteLine(NextId.Dequeue());        //remove
            //}
            //Console.WriteLine($"total element {NextId.Count}");

            Queue<int> NextId = new Queue<int>();
            NextId.Enqueue(1);
            NextId.Enqueue(2);
            NextId.Enqueue(3);
            NextId.Enqueue(4);

            Console.WriteLine($"total element {NextId.Count}");

                                           //contain kan hier ook eventueel gebruikt worden

                Console.WriteLine(NextId.Peek());        
                Console.WriteLine(NextId.Peek());


            Console.WriteLine($"total element {NextId.Count}");
        }
    }
}
