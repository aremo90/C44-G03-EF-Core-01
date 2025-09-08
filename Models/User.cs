using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class User
    {
        // Data Annotations
        [Key]
        public int SSN { get; set; } // primary key

        [Required]
        [Column("UserName" , TypeName = "varchar(50)")]                     // Sql Validation
        [MaxLength(50 , ErrorMessage = "Name must be less than 51 chars")]  // C# Validation
        [MinLength(3 , ErrorMessage = "Name must be greater than 3 chars")] // C# Validation
        public string Uname { get; set; }

        [Required]
        [Range(20 , 50)]
        public int Age { get; set; }

        [Required]
        [Phone]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
