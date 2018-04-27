using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNIDB.Data;
using UNIDB.Data.Models;

namespace UNIDB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(Console.BufferWidth, 1000);

            using (var dbContext = new SoftUniContext())
            {
                //using (var dbContext = new SoftUniContext())
                //{
                //    dbContext.Employees
                //        .Where(e => e.Salary > 50000)
                //        .Select(e => new { e.FirstName})
                //        .OrderByDescending(e => e.FirstName)
                //        .ToList()
                //        .ForEach(e => Console.WriteLine(e.FirstName));
                //        Console.ReadLine();

                //}


                //using (var dbContext = new SoftUniContext())
                //{
                //    dbContext.Employees
                //        .Where(e => e.Salary > 50000)
                //        .Select(e => new { e.FirstName, e.MiddleName, e.LastName,dep= e.Departments1.Name, e.Salary })
                //        .OrderBy(e => e.Salary)
                //        .ToList()
                //        .ForEach(e => Console.WriteLine($"{e.FirstName} {e.MiddleName} {e.LastName} from {e.dep} - ${e.Salary:f2}"));
                //    Console.ReadLine();

                //}

                //dbContext.Employees
                //    .Where(e => e.Departments1.Name == "Research and Development")
                //    .OrderBy(e => e.Salary).
                //    ThenByDescending(e => e.FirstName)
                //    .Select(e => new { e.FirstName, e.LastName, DepartmentName = e.Departments1.Name, e.Salary })
                //    .ToList()
                //    .ForEach(e => Console.WriteLine($"{e.FirstName} {e.LastName} from {e.DepartmentName} - ${e.Salary:f2}"));


                //var address = new Addresses()
                //{
                //    AddressText = "Vitoshka 15",
                //    TownID = 4
                //};

                //dbContext.Employees
                //    .Single(e => e.LastName == "Nakov")
                //    .Addresses = address;

                //dbContext.SaveChanges();

                //dbContext.Employees
                //    .OrderByDescending(e => e.Addresses.AddressID)
                //    .Take(10)
                //    .Select(e => e.Addresses.AddressText)
                //    .ToList()
                //    .ForEach(at => Console.WriteLine(at));


                //dbContext.Employees

                //.Join(dbContext.Employees,
                //    e => e.ManagerID,
                //    m => m.EmployeeID,
                //(e, m) => new { Employees = e, Managers = m })
                //.Where(e => e.Employees.Projects
                //.Any(p => p.StartDate.Year >= 2001 && p.StartDate.Year <= 2003))
                //.Take(30)
                //.Select((e) => new
                //{
                //    e.Employees.FirstName,
                //    e.Employees.LastName,
                //    ManagerFirstName = e.Managers.FirstName,
                //    ManagerLastName = e.Managers.LastName,
                //    e.Employees.Projects

                //})
                //.ToList()
                //.ForEach(e => Console.WriteLine($"{e.FirstName} {e.LastName} - Manager: {e.ManagerFirstName} {e.ManagerLastName}{Environment.NewLine}" +
                // $"{String.Join(Environment.NewLine, e.Projects.Select(p => $"--{p.Name} - {p.StartDate.ToString("M/d/yyyy h:mm:ss tt")} - {(p.EndDate == null ? "not finished" : p.EndDate.ToString())}"))}"));


                //dbContext.Addresses
                //    .GroupBy(a => new { a.AddressID, a.AddressText, a.Towns.Name },
                //        (key, group) => new { AddressText = key.AddressText, Town = key.Name, Count = group.Sum(a => a.Employees.Count) })
                //    .OrderByDescending(o => o.Count)
                //    .ThenBy(o => o.Town)
                //    .ThenBy(o => o.AddressText)
                //    .Take(10)
                //    .ToList()
                //    .ForEach(o => Console.WriteLine($"{o.AddressText}, {o.Town} - {o.Count} employees"));

                var employee = dbContext.Employees.
                   Where(e => e.EmployeeID == 147)
                   .Select(e => new
                   {
                       e.FirstName,
                       e.LastName,
                       e.JobTitle,
                       Projects = e.EmployeesProjects
                           .Select(ep => ep.Project.Name)
                           .OrderBy(p => p)
                           .ToList()
                   })
                   .First();

                Console.WriteLine($"{employee.FirstName} {employee.LastName} - {employee.JobTitle}{Environment.NewLine}{String.Join(Environment.NewLine, employee.Projects)}");

                //dbContext.Departments
                //   .Include(d => d.Employees)
                //   .Include(d => d.Manager)
                //   .Where(d => d.Employees.Count > 5)
                //   .OrderBy(d => d.Employees.Count)
                //   .ThenBy(d => d.Name)
                //   .ToList()
                //   .ForEach(d => Console.WriteLine($"{d.Name} - {d.Manager.FirstName} {d.Manager.LastName}{Environment.NewLine}{String.Join(Environment.NewLine, d.Employees.OrderBy(e => e.FirstName).ThenBy(e => e.LastName).Select(e => $"{e.FirstName} {e.LastName} - {e.JobTitle}").ToList())}{Environment.NewLine}{new string('-', 10)}"));


                Console.ReadLine();
            }
        }
    }
}
