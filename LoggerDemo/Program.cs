using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Equal = Calculator.AreEqual(10, 11);
            if (Equal)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }
    }
    public class Calculator
    {

        public static bool AreEqual<T>(T value1, T value2)
        {
            return value1.Equals(value2);
        }

        //public static bool AreEqualString(string a, string b)
        //{
        //    return a == b;
        //}

        
    }
}




