using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Question1.Course;

namespace Question1
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        private Dictionary<Student, double> list;
        public delegate void NumberOfStudentChange(int oldS, int newS);
        public event NumberOfStudentChange OnNumberOfStudentChange;
        public Course(int CourseId, string CourseName)
        {
            this.CourseId = CourseId;
            this.CourseName = CourseName;
            list = new Dictionary<Student, double>();
        }
        public void AddStudent(Student p, double g)
        {
            if(!list.ContainsKey(p)){
                int oldS = list.Count;
                list.Add(p, g);
                int newS = list.Count;
                OnNumberOfStudentChange?.Invoke(oldS,newS);
            }
        }
        public void RemoveStudent(int StudentId)
        {
            Student s = null;
            foreach(KeyValuePair<Student,double> entry in list)
            {
                if(entry.Key.StudentId == StudentId)
                {
                    s = entry.Key; 
                    break;
                }
            }
            if(s != null)
            {
                int oldS = list.Count;
                list.Remove(s);
                int newS = list.Count;
                OnNumberOfStudentChange?.Invoke(oldS, newS);
            }
        }
        public override string ToString()
        {
            string s = "Course: " + CourseName + " - \n";
            foreach(KeyValuePair<Student,double> entry in list)
            {
                s += "Student: " + entry.Key.StudentId + "-" + entry.Key.StuedntName+ " - Mark" + " :" + entry.Value + "\n";
            }
            return s;
        }
    }
}
