using System;
using SortItemInClass123.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortItemInClass123
{
    class Program
    {
        static void Main(string[] args)
        {
            Helper.SortByName = false;

            List<Student> students = new List<Student>();

            Student student1 = new Student()
            {
                Id = 3,
                Name = "Toon",
                Marks = 6
            };
            Student student2 = new Student()
            {
                Id = 2,
                Name = "auro",
                Marks = 4
            };
            Student student3 = new Student()
            {
                Id = 1,
                Name = "Jeff",
                Marks = 5
            };

            students.Add(student1);
            students.Add(student2);
            students.Add(student3);

            if (Helper.SortByName)
            {
                SortByName sn = new SortByName();
                students.Sort(sn);
                Console.WriteLine("Sorting by name");
                ShowInfo(students);
            }
            else if (Helper.SortByMarks)
            {
                SortByMarks sm = new SortByMarks();
                students.Sort(sm);
                Console.WriteLine("Sorting by marks");
                ShowInfo(students);
            }
            else
            {
                students.Sort();
                Console.WriteLine("sort by id");
                ShowInfo(students);
            }

            //Console.WriteLine("after");
            //ShowInfo(students);

        }

        private static void ShowInfo(List<Student> students)
        {
            foreach (var item in students)
            {
                Console.WriteLine(item.Id + " " + item.Name);
            }
        }
    }
}
