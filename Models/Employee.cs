using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    // POCO Class == entity == model
    internal class Employee
    {
        public int Id { get; set; }
        // Primary Key by default
        public string? Name { get; set; }
        public decimal Salary { get; set; }
        public int Age { get; set; }
    }
}
