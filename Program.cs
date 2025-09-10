using ConsoleApp1.Contexts;
using ConsoleApp1.Models;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

            using CompanyDBContext dBContext = new CompanyDBContext(); // open connection

            Employee employee = new Employee()
            {
                // ID = 1, not vaild because identity column
                Name = "Ahmed",
                Salary = 5000,
                Age = 25
            };

            Console.WriteLine(dBContext.Entry<Employee>(employee).State); // Detached
            // to start add 
            // 1-
            dBContext.Employees.Add(employee);
            // 2-
            dBContext.Set<Employee>().Add(employee);
            // 3-
            dBContext.Add(employee);

            Console.WriteLine(dBContext.Entry<Employee>(employee).State); // Added

            // to save in database
            // call SaveChanges()
            dBContext.SaveChanges();

            /* Note:-
             *      With Every Run to program it will add new record
             */

            #endregion
        }
    }
}
