using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    internal class Student
    {
        public int ID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public int Dep_Id { get; set; }
        public Department Department { get; set; }

        //public ICollection<Stud_Course> Stud_Courses { get; set; } = new List<Stud_Course>();

        // M2M with Course
        public ICollection<Course> Courses { get; set; }
    }
}
