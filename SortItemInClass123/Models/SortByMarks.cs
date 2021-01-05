using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortItemInClass123.Models
{
    public class SortByMarks : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return x.Marks.CompareTo(y.Marks);  

        }
    }
}
