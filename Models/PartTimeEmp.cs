using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class PartTimeEmp : EmployeeInherit
    {
        public decimal HourRate { get; set; }
        public int CountOfHours { get; set; }
    }
}
