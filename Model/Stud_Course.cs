using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    internal class Stud_Course
    {
        [Key] // to avoid Migration primary key erro
        public int Student_Id { get; set; }
        public int Course_Id { get; set; }
        public int Grade { get; set; }
    }
}
