using ConsoleApp1.Context;
using ConsoleApp1.Model;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Database connection

            using ITIDbContext context = new ITIDbContext();

            #endregion

            #region Assignment 03

            #region Apply Manual & Migrate Data Seed

            Topic Topic01 = new Topic() {  Name = "C#" };
            Topic Topic02 = new Topic() { Name = "Java" };

            context.Add(Topic01);
            context.Add(Topic02);

            context.SaveChanges();

            #endregion

            #endregion

        }
    }
}
