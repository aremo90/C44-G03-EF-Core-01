using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    internal class Course_Inst
    {
        [Key] // to avoid Migration primary key error
        public int inst_Id { get; set; }
        public int Course_Id { get; set; }
        public string evaluate { get; set; }
    }
}
