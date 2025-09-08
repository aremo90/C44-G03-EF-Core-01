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
        // Mapping by convention
        public int Id { get; set; }
        // Primary Key by default
        public string? Name { get; set; }
        // Nullable Reference Type
        // Mapped to navchar(Max)
        public decimal Salary { get; set; }
        // value type
        // not allow null
        // Decimal(18,2)
        public int Age { get; set; }
        // value type
        // not allow null
        // int mapped to int
    }
}
