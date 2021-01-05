using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student()
            {
                Id = 1,
                Name = "Jeff",
                Marks = 6
            }; 
            Student student2 = new Student()
            {
                Id = 2,             //keys zijn belangrijk
                Name = "Mauro",
                Marks = 7
            };
            Student student3 = new Student()
            {
                Id = 3,
                Name = "Kenan",
                Marks = 9
            };

            // deze keer geen list maar een dictionary
            Dictionary < int, Student > students = new Dictionary<int, Student>();
            students.Add(student1.Id, student1);
            students.Add(student2.Id, student2);
            students.Add(student3.Id, student3);

            //trukje zoals kenan het noemde
            if (!students.ContainsKey(2))  //als hij niet bestaat, gaat hij hem toevoegen
            {
                students.Add(student2.Id, student2);
            }
            else
            {
                Console.WriteLine("duplicate key not allowd");
            }







            foreach (var item in students)
            {
                Console.WriteLine(item.Key + "  " + item.Value.Name);
            }
        }

        class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Marks { get; set; }
        }
    }
}
