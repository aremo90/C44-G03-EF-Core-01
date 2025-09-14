using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Department
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        //public Employee? Manager { get; set; } = null!;
        //public Employee MangedDept { get; set; 



        //one to many
        [InverseProperty(nameof(Employee.EmployeeDepartment))] // to avoid ambuiguity and conflict
        public ICollection<Employee> Employees { get; set; } = new HashSet<Employee>(); // can use list or hashset


    }
}
