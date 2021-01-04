using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>(/*5*/);
            list.Add(1);
            list.Add(2);
            list.Add(8);
            list.Add(50);
            list.Add(120);

            //list.Insert(3, 500);
            ////list.RemoveAt(3);
            ////list.Remove(120);
            //list.IndexOf(50);

            //int index = list.IndexOf(800);
            //if (index > 0)
            //{
            //    Console.WriteLine(index);
            //}
            //else
            //{
            //    Console.WriteLine("element not found");
            //}

            list.Sort();

            int index = list.BinarySearch(600);
            if (index > 0)
            {
                Console.WriteLine("Binary search index is: " + index); ;
            }
            else
            {
                Console.WriteLine("Element not found");
            }



            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"the count of elements in list {list.Count}");



            #region

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            //List<string> lstring = new List<string>();
            //lstring.Add("Toon");
            //lstring.Add("Emre");
            //lstring.Add("Mauro");

            //foreach (var item in lstring)
            //{
            //    Console.WriteLine(item);
            //}

            //student s1 = new student();
            //s1.Id = 1;
            //s1.Name = "Mauro";

            //student s2 = new student() {Id= 2 , Name = "Emre" };

            //student s3 = new student() { Id = 3, Name = "Jan" };


            //List<student> Students = new List<student>();
            //Students.Add(s1);
            //Students.Add(s2);
            //Students.Add(s3);
            //List<student> Students = new List<student>
            //{
            //new student(){Id=1, Name="Toon" },
            //new student(){Id=2, Name="Emre" },
            //new student(){Id=3, Name="Jan" }
            //};


            //foreach (var item in Students)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
        }
    }
    class student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
