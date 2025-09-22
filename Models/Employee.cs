using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]
namespace ConsoleApp1.Models
{
    // POCO Class == entity == model
    internal class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }
        public int Age { get; set; }

        public Address? EmpAddress { get; set; }

        // Foreign Key
        public int? DeptId { get; set; }

        // Navigation Property (Many-to-One)
        public virtual Department EmployeeDepartment { get; set; } = null!;
    }
}

