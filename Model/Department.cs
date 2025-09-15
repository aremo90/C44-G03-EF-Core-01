using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    internal class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime HiringDate { get; set; }
        public int? Ins_ID { get; set; }
        public Instructor Head { get; set; }

        public ICollection<Student> Students { get; set; } = new List<Student>();

        // 1 to many relation with Instructor
        [InverseProperty(nameof(Instructor.Department))]
        public ICollection<Instructor> Instructors { get; set; } = new HashSet<Instructor>();

    }
}
