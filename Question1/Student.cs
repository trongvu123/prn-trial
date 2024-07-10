using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StuedntName { get; set; }
        public Student(int id, string name)
        {
            StudentId = id;
            StuedntName = name;
        }

    }

}
