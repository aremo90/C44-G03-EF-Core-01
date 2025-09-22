using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]

namespace ConsoleApp1.Models
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;


        // Nav prop many to many
        public virtual ICollection<Course> Courses { get; set; } = new HashSet<Course>();
    }
}
