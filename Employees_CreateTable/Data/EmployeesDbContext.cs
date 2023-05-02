using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employees_CreateTable.Models;
using Microsoft.EntityFrameworkCore;

namespace Employees_CreateTable.Data
{
    internal class EmployeesDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder); // ToDo: Replace this one later with code from the WinForms & WPF Applications
            // section or with a a Startup.cs file
            // https://learn.microsoft.com/nb-no/ef/core/miscellaneous/connection-strings
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SplitEmployees;Integrated Security=True;");
        }
    }
}
