using ConsoleApp1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Contexts
{
    internal class CompanyDBContext : DbContext
    {
        // When you create a DbContext class, you typically inherit from the DbContext base class provided by Entity Framework Core.
        // you must install this package -> Microsoft.EntityFrameworkCore.sqlserver

        public CompanyDBContext():base()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // connect between c# with database
            // connection string => server name, database name
            //optionsBuilder.UseSqlServer("Data Source = . ; Initial Catlog = CompanyDB ; Integrated Security = True");
            optionsBuilder.UseSqlServer("Server=. ; Database=CompanyDB ; Trusted_Connection = True ; TrustServerCertificate = True ;");
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
