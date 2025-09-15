using ConsoleApp1.Contexts;
using ConsoleApp1.Data;
using ConsoleApp1.Models;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using CompanyDBContext dBContext = new CompanyDBContext(); // open connection

            #region Session 01
            #region EF Core

            /*
             * Features :- 
             *      => Object Relational Mapping (ORM)
             *      => LINQ Support
             *      => Support for Multiple Databases
             *      => Cross platform
             *      => Auto Tracker
             *      => Migrations Supported
             *      
             * disadvantages :-
             *      => Performance Overhead (auto tracker)
             *      => complexity
             */


            #endregion

            #region ADO.NET

            /*
             * Features :-
             *      => Low level Framework
             *      => no tracking
             *      => manual control on SQL Queries
             *      => Direct Database access  
             */

            #endregion

            #region Dapper

            /*
             * Features :-
             *      => Lightweight
             *      => Micro ORM
             *      => Performance
             *      => No Tracking
             *      => Simple API
             *      => Faster and easy to use
             *      
             * disadvantages :-
             *      => Limited features compared to full ORM (like EF Core)
             *      => Manual Mapping (less automation)
             */

            #endregion

            #region DBContext

            //CompanyDBContext dBContext = new CompanyDBContext();

            //close Connection
            //try
            //{

            //}
            //finally
            //{ 
            //    dBContext.Dispose();
            //}

            //using CompanyDBContext dBContext = new CompanyDBContext();

            //dBContext.Database.Migrate(); => bad use

            // to applay migration you must download the package => Microsoft.EntityFrameworkCore.Tools


            // To applay database in sql server
            // use Update Database

            #endregion
            #endregion

            #region Session 02


            #region CRUD Operations

            #region Insert
            //Employee employee = new Employee()
            //{
            //    // ID = 1, not vaild because identity column
            //    Name = "Ahmed",
            //    Salary = 5000,
            //    Age = 25
            //};

            //Console.WriteLine(dBContext.Entry<Employee>(employee).State); // Detached
            //// to start add 
            //// 1-
            //dBContext.Employees.Add(employee);
            //// 2-
            //dBContext.Set<Employee>().Add(employee);
            //// 3-
            //dBContext.Add(employee);

            //Console.WriteLine(dBContext.Entry<Employee>(employee).State); // Added

            // to save in database
            // call SaveChanges()
            //dBContext.SaveChanges();

            /* Note:-
             *      With Every Run to program it will add new record
             */

            #endregion

            #region Select

            //var emp01 = dBContext.Employees.Where(e => e.Id == 1).FirstOrDefault(); // search by primary key
            //var emp01 = dBContext.Employees.FirstOrDefault( E => E.Id == 1); // search by primary key

            //if (emp01 != null)
            //{
            //    Console.WriteLine($"ID: {emp01.Id} , Name: {emp01.Name} , Salary: {emp01.Salary} , Age: {emp01.Age}");
            //}

            #endregion

            #region Update

            //var emp02 = dBContext.Employees.FirstOrDefault(E => E.Id == 1);

            //if ( emp02 != null)
            //{ 
            //    Console.WriteLine(dBContext.Entry<Employee>(emp02).State); // Unchanged
            //    emp02.Name = "Mohamed";
            //    emp02.Salary = 6000;
            //    emp02.Age = 26;

            //    dBContext.Update(emp02);
            //    Console.WriteLine(dBContext.Entry<Employee>(emp02).State); // Modified
            //    dBContext.SaveChanges();
            //}

            #endregion

            #region Delete

            //var emp03 = dBContext.Employees.FirstOrDefault(E => E.Id == 2);
            //if (emp03 != null)
            //{
            //    Console.WriteLine(dBContext.Entry<Employee>(emp03).State); // Unchanged
            //    dBContext.Remove(emp03);
            //    Console.WriteLine(dBContext.Entry<Employee>(emp03).State); // Deleted
            //    dBContext.SaveChanges();
            //}

            #endregion
            #endregion

            #region Relationships between Classes
            /* 
             *  3 ways to configure relationships :-
             *      Navigation Properties
             *      Fluent API
             *      By Conventions
             */


            #endregion


            #endregion

            #region Session 03

            #region Data Seed

            /*
             *      If you want to seed Data to your database thorught EF Core
             *      
             *      you have 3 ways to do that :-
             *          1. Manual Data Seeding
             *          2. Data Seeding with Migrations
             *          3. Dynamic Data Seeding
             */

            #endregion
            #region Manual Data Seeding

            //Department dept01 = new Department()
            //{
            //    Name = "IT"
            //};

            //dBContext.Add(dept01);
            //dBContext.SaveChanges();


            //List<Department> departments = new List<Department>()
            //{
            //    new Department() { Name = "HR" },
            //    new Department() { Name = "Sales" },
            //    new Department() { Name = "Marketing" }
            //};
            //dBContext.AddRange(departments);
            //dBContext.SaveChanges();
            #endregion
            #region migration data seeding

            // to applay migration data seeding we send data in OnModelCreating method in DBContext class



            #endregion
            #region Dynamic Data Seeding

            bool flag = CompanyDbContexetSeed.Seed(dBContext);

            if (flag)
                Console.WriteLine("Data Added Susccufly");
            else
                Console.WriteLine("Error while adding the data");

            #endregion

            #endregion

        }
    }
}
