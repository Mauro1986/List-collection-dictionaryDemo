using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Declare Stack
            //Stack<int> intLst = new Stack<int>();
            //intLst.Push(1);                             //toont laatste input eerst, dan voorlaatste etc
            //intLst.Push(2);
            //intLst.Push(3);
            //intLst.Push(4);


            //foreach (var item in intLst)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Pop returns last elememn and removes it from collection

            //Stack<int> intLst = new Stack<int>();
            //intLst.Push(1);         //pop returns last element and remove it from collection
            //intLst.Push(2);
            //intLst.Push(3);
            //intLst.Push(4);

            //Console.WriteLine($"total elements in stack: {intLst.Count}");

            //while (intLst.Count > 0)
            //{
            //    Console.WriteLine(intLst.Pop());
            //}
            //Console.WriteLine($"total elements in stack: {intLst.Count}");

            #endregion

            #region Peek show lastly addes value but not removing it
            //Stack<int> intLst = new Stack<int>();
            //intLst.Push(1);        
            //intLst.Push(2);
            //intLst.Push(3);
            //intLst.Push(4);

            //Console.WriteLine($"total elements in stack: {intLst.Count}");

            //Console.WriteLine(intLst.Peek());
            //Console.WriteLine(intLst.Peek());

            ////while (intLst.Count > 0)
            ////{
            ////    Console.WriteLine(intLst.Peek());
            ////    Console.WriteLine(intLst.Peek());
            ////}
            //Console.WriteLine($"total elements in stack: {intLst.Count}");

            #endregion

            #region Contains (bevat)
            //Stack<int> intLst = new Stack<int>();
            //intLst.Push(1);
            //intLst.Push(2);
            //intLst.Push(3);
            //intLst.Push(4);

            //Console.WriteLine(intLst.Contains(3));       // contains voor te checken of die in lijst zit
            //Console.WriteLine(intLst.Contains(5));

            #endregion

         
        }
    }
}
