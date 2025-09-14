using ConsoleApp1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

        #region FluentApi

        // to applay mapping with Fluent api You must override method OnModelCreating
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //modelBuilder.Entity<Employee>().HasKey(e => e.Id);


        ////applay constrain
        //modelBuilder.Entity<Employee>()
        //    .Property(e => e.Id)
        //    .UseIdentityColumn(1,1);

        //// Delete constrain
        //modelBuilder.Entity<Employee>()
        //    .Property(e => e.Id)
        //    .ValueGeneratedNever();

        //modelBuilder.Entity<Employee>()
        //    .Property(e => e.Name) // .Property("Name") May throw exception at runtime => if property name is changed
        //    .HasColumnName("EmpName")
        //    .HasColumnType("varchar(50)") // if varchar without length => default length is 1
        //    .HasMaxLength(50)
        //    .IsRequired();


        //another Way
        //modelBuilder.Entity<Employee>(entity =>
        //{
        //    entity.HasKey(e => e.Id);
        //    entity.Property(e => e.Id)
        //        .UseIdentityColumn(10, 10);
        //    entity.Property(e => e.Name)
        //        .HasColumnName("EmpName")
        //        .HasColumnType("varchar(50)")
        //        .HasMaxLength(50)
        //        .IsRequired(false);
        //});
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            // Employee → Department (Many-to-One)
            modelBuilder.Entity<Employee>()
                .HasOne(e => e.EmployeeDepartment)
                .WithMany(d => d.Employees)
                .HasForeignKey(e => e.DeptId)
                .OnDelete(DeleteBehavior.Cascade);

            // Employee → Address (Owned Type)
            modelBuilder.Entity<Employee>()
                .OwnsOne(e => e.EmpAddress, a =>
                {
                    a.WithOwner();
                });

            //modelBuilder.Entity<Department>()
            //    .HasData
            //    (
            //        new Department { Id = 4, Name = "Backend" },
            //        new Department { Id = 5, Name = "Software" }
            //    );
        }

        #endregion

        public DbSet<Employee> Employees { get; set; }
        public DbSet<User> Users { get; set; }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        }
}
