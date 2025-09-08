using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Context
{
    internal class ITIDbContext : DbContext
    {
        public ITIDbContext() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = . ; Database = ITI; Trusted_Connection = true; TrustServerCertificate = true");
        }
        public DbSet<Model.Instructor> Instructors { get; set; }
        public DbSet<Model.Department> Departments { get; set; }
        public DbSet<Model.Course_Inst> Course_Insts { get; set; }
        public DbSet<Model.Stud_Course> Stud_Courses { get; set; }
        public DbSet<Model.Student> Students { get; set; }
        public DbSet<Model.Course> Courses { get; set; }
        public DbSet<Model.Topic> Topics { get; set; }



    }
}
