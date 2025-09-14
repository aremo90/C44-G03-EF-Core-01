using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
        public string? Name { get; set; }
        public decimal Salary { get; set; }
        public int Age { get; set; }
        // Navigation Property
        // Represent Relationship of 1
        //[ForeignKey(nameof(DeptManger))]
        //public int DeptMangerId { get; set; }
        //public Department DeptManger { get; set; } = null!;

        //public int DeptMangerId { get; set; }
        //public Department Manager { get; set; }

        // One to One total total

        public Address EmpAddress { get; set; }

        [InverseProperty(nameof(Department.Employees))]
        public Department EmployeeDepartment { get; set; } // by defult it will be 1 : 1 RS


    }
}
