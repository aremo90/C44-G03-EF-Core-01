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

        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public string Grade { get; set; }

    }
}
