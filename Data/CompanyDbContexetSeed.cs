using ConsoleApp1.Contexts;
using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleApp1.Data
{
    internal class CompanyDbContexetSeed
    {
        public static bool Seed(CompanyDBContext dBContext)
        {
            // table employees

            try
            {
                if (!dBContext.Employees.Any())
                {
                    var EmpsData = File.ReadAllText("Files\\employees.json");

                    // convert from json to file
                    // make sure data in json file matches Employee class properties
                    var Employees = JsonSerializer.Deserialize<List<Employee>>(EmpsData);

                    // add employees in database
                    if (Employees.Count > 0)
                    {
                        dBContext.AddRange(Employees); // Added
                        dBContext.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
