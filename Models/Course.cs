using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }


        // Nav prop many to many
        public ICollection<Student> Students { get; set; } = new HashSet<Student>();
    }
}
