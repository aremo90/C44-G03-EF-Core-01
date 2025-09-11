using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    internal class Instructor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Bonus { get; set; }
        public decimal Salary { get; set; }
        public string Address { get; set; }
        public int HourRate { get; set; }
        public int Dept_Id { get; set; }
        public Department Department { get; set; }


        public ICollection<Department> ManagedDepartments { get; set; } = new List<Department>();

        public ICollection<Course_Inst> Course_Insts { get; set; } = new List<Course_Inst>();
    }
}
