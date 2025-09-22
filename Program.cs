using ConsoleApp1.Contexts;
using ConsoleApp1.Data;
using ConsoleApp1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;

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

            //bool flag = CompanyDbContexetSeed.Seed(dBContext);

            //if (flag)
            //    Console.WriteLine("Data Added Susccufly");
            //else
            //    Console.WriteLine("Error while adding the data");

            #endregion

            #region Loading Related Data [Defult Loading]

            //var Emp01 = dBContext.Employees.FirstOrDefault(e => e.Id == 5);

            //if (Emp01 != null)
            //{
            //    Console.WriteLine($"Emp Name : {Emp01.Name}");
            //    Console.WriteLine($"Emp Age  : {Emp01.Age}");
            //    Console.WriteLine($"Dept ID  : {Emp01.EmployeeDepartment}");
            //}


            //var EmpDept = (from D in dBContext.Departments
            //               where D.Id == Emp01.DeptId
            //               select D).FirstOrDefault();
            //Console.WriteLine($"DeptName : {EmpDept.Name}");

            #endregion

            #region Eager Loading

            //var Emp02 = dBContext.Employees.Include(E => E.EmployeeDepartment).FirstOrDefault(e => e.Id == 5);

            //if (Emp02 != null)
            //{
            //    Console.WriteLine($"Emp Name : {Emp02.Name}");
            //    Console.WriteLine($"Emp Age  : {Emp02.Age}");
            //    Console.WriteLine($"Dept ID  : {Emp02.EmployeeDepartment?.Name}");
            //}
            #endregion

            #region Explicit Loading
            // casue delay in loading related data for first time not noticeble but it exixit

            // Manual loading
            // two requeries to database
            // first request to retrieve data
            // second request to retrieve related data

            //var emp01 = dBContext.Employees.FirstOrDefault(e => e.Id == 5); // Data from Employees table

            //if(emp01 != null)
            //{
            //    Console.WriteLine($"Emp Name : {emp01.Name}");
            //    Console.WriteLine($"Dept ID  : {emp01.DeptId}");
            //    //Console.WriteLine($"Dept Name : {emp01.EmployeeDepartment.Name}"); => Error because EmployeeDepartment is null

            //    dBContext.Entry(emp01).Reference(e => e.EmployeeDepartment).Load(); // Load related data from Department table
            //    // Reference() for one Navigation property

            //    Console.WriteLine($"Dept Name : {emp01.EmployeeDepartment.Name}");
            //}

            #endregion

            #endregion

            #region Session 04

            #region Lazy Loading

            /*
             * Enable lazy loading in your project :-
             *      1. Install the package Microsoft.EntityFrameworkCore.Proxies
             *      2. Configure your DbContext to use lazy loading proxies by overriding the OnConfiguring method in your DbContext class
             *      3. Make your navigation properties virtual in your entity classes and Classes must be public
             * 
             * 
             */

            //var emp02 = dBContext.Employees.FirstOrDefault(e => e.Id == 5);

            //if (emp02 != null)
            //{
            //    Console.WriteLine($"Emp Name: ${emp02.Name}");
            //    Console.WriteLine($"Dept ID: ${emp02.DeptId}");
            //    Console.WriteLine($"Dept Name: ${emp02.EmployeeDepartment?.Name}"); // when access EmployeeDepartment it will load related data from Department table
            //}

            #endregion

            #region Join Queries

            #region Problem #1

            // Inner Join or Group join only

            //var res = dBContext.Departments.Join(dBContext.Employees,
            //                                     D => D.Id,
            //                                     E => E.DeptId,
            //                                     (D, E) => new
            //                                     {
            //                                         EmpName = E.Name,
            //                                         EmpID = E.Id,
            //                                         DeptID = D.Id,
            //                                         DeptName = D.Name
            //                                     });

            //var res = from D in dBContext.Departments
            //          join E in dBContext.Employees
            //          on D.Id equals E.DeptId
            //          select new
            //          {
            //              EmpName = E.Name,
            //              EmpID = E.Id,
            //              DeptID = D.Id,
            //              DeptName = D.Name
            //          };

            //foreach (var item in res)
            //{
            //    Console.WriteLine($"EmpID: {item.EmpID} , EmpName: {item.EmpName} , DeptID: {item.DeptID} , DeptName: {item.DeptName}");
            //}   
            #endregion

            #region Group Join - Left Outer Join

            #region Get all Departments that has Employees or not

            //var res = dBContext.Departments.GroupJoin(dBContext.Employees,
            //                                     D => D.Id,
            //                                     E => E.DeptId,
            //                                     (D, Emps) => new
            //                                     {
            //                                         DeptID = D.Id,
            //                                         DeptName = D.Name,
            //                                         Employees = Emps
            //                                     });
            //foreach (var item in res)
            //{
            //    Console.WriteLine($"DeptID: {item.DeptID} , DeptName: {item.DeptName}");
            //    if (item.Employees != null && item.Employees.Count() > 0)
            //    {
            //        foreach (var emp in item.Employees)
            //        {
            //            Console.WriteLine($"\t EmpID: {emp.Id} , EmpName: {emp.Name}");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine($"\t No Employees");
            //    }
            //}

            #endregion

            #endregion

            #region Right Outer Join

            /*
             *  EF core does not support right outer join directly
             *  But you can achieve similar results using left join by reversing the order of the tables
             */


            #endregion

            #region Cross Join

            /*
             *  EF core does not support cross join directly
             *  But you can achieve similar results using SelectMany method
             *  or when you select from two tables without any join condition
             *  
             *  var res = from e in dbContext.Employees
                from d in dbContext.Departments
                select new { e.Name, d.DeptName };
             */

            #endregion

            #endregion

            #region TPCT

            //FullTimeEmp ftEmp = new FullTimeEmp()
            //{
            //    Name = "Ali",
            //    Age = 30,
            //    Salary = 8000,
            //    StartDate = DateTime.Now,
            //    Address = "Cairo",
            //};  

            //PartTimeEmp ptEmp = new PartTimeEmp()
            //{
            //    Name = "Omar",
            //    Age = 22,
            //    Address = "Giza",
            //    CountOfHours = 100,
            //    HourRate = 50,
            //};

            //dBContext.Add(ftEmp);
            //dBContext.Add(ptEmp);
            //dBContext.SaveChanges();

            //var FTE = (from fte in dBContext.FullTimeEmployees
            //           select fte).FirstOrDefault();
            //Console.WriteLine($"{FTE.Name} - {FTE.Age}");

            #endregion

            #region TPH



            #endregion


            #endregion

            #region Session 05
            using MySroVtShardContext ShardDbContext = new MySroVtShardContext();

            #region Local

            /*
             * Local works on the local data in memory AKA [In C#]
             */

            //var res = dBContext.Employees.Any(E => E.Age != null);
            //Console.WriteLine(res);

            //local
            //var res = dBContext.Employees.Local.Any(E => E.Age != null);
            //Console.WriteLine(res);


            var emp01 = dBContext.Employees.FirstOrDefault();

            if (emp01 != null)
            {
                Console.WriteLine($"Emp Name: {emp01.Name}");
            }

            var res = dBContext.Employees.Local.Any(E => E.Age == null);
            Console.WriteLine(res);


            #endregion

            #region database first with Commands

            /*
             *  download Packages :-
             *      - Microsoft.EntityFrameworkCore.SqlServer
             *      - Microsoft.EntityFrameworkCore.Tools
             *      - Microsoft.EntityFrameworkCore.Proxies (if you want to use lazy loading)
             * 
             *  use Database => Scaffold => Package Mangeer Console
             */
            //using MySroVtShard ShardDbContext = new MySroVtShard();

            //var res03 = ShardDbContext.RefObjCommons.Where(O => O.Id > 1000);
            //if (res03 != null)
            //{
            //    foreach (var item in res03)
            //    {
            //        Console.WriteLine($"ID: {item.Id} , Name: {item.CodeName128}");
            //    }
            //}

            #endregion

            #region database first with EF Core Power Tools

            /*
             *  download the extension => EF Core Power Tools
             *  
             *  dont forget to add TrustServerCertificate = true
             */
            //using MySroVtShardContext ShardDbContext = new MySroVtShardContext();
            //var res04 = ShardDbContext.RefObjCommons.Where(O => O.Id > 1000);
            //if (res04 != null)
            //{
            //    foreach (var item in res04)
            //    {
            //        Console.WriteLine($"ID: {item.Id} , Name: {item.CodeName128}");
            //    }
            //}
            #endregion

            #region Run Queries VIA App

            #region Select

            //int CommonID = 1000;

            //var res05 = ShardDbContext.RefObjCommons.FromSqlRaw("SELECT * FROM _RefObjCommon WHERE ID = {0}" , CommonID);

            //res05 = ShardDbContext.RefObjCommons.FromSqlInterpolated($"SELECT * FROM _RefObjCommon WHERE ID = {CommonID}");

            //if (res05 != null)
            //{
            //    foreach (var item in res05)
            //    {
            //        Console.WriteLine($"ID: {item.Id} , Name: {item.CodeName128}");
            //    }
            //}

            #endregion

            #region Update - Delete
            //int ID = 1001;
            //var res06 = ShardDbContext.Database.ExecuteSqlRaw("UPDATE _RefObjCommon SET CodeName128 = 'CHN_11' WHERE ID = 1000");
            //var res06 = ShardDbContext.Database.ExecuteSqlInterpolated($"UPDATE _RefObjCommon SET CodeName128 = 'CHN_22' WHERE ID = {ID}");

            //Console.WriteLine(res06);

            //var res07 = ShardDbContext.Database.ExecuteSqlRaw("DELETE FROM _RefObjCommon WHERE ID = 62972");

            #endregion

            #endregion

            #region Views

            var res08 = ShardDbContext.TimItemOnChars.Where(I => I.CharId > 1000);

            #endregion

            #endregion

        }
    }
}
