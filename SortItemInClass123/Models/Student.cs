using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortItemInClass123.Models
{
    public class Student: IComparable<Student>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Marks { get; set; }

        public int CompareTo(Student other)
        {
            //if (this.Id > other.Id)               //ouder manier
            //{
            //    return 1;
            //}
            //else if (this.Id < other.Id)
            //{
            //    return -1;
            //}
            //else
            //{
            //    return 0;
            //}

            return this.Name.CompareTo(other.Name);    // nieuwe manier  (id name marks kunnen wordenvergeleken)
        }
    }
}
