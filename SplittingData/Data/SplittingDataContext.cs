using Microsoft.EntityFrameworkCore;
using SplittingData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplittingData.Data
{
    internal class SplittingDataContext : DbContext 
    {
        public DbSet<Employee> Employees { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Not safe. Change with code similar to the WinForms & WPF Applications or the Startup.cs code from the Connection Strings page at
            // https://learn.microsoft.com/nb-no/ef/core/miscellaneous/connection-strings
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SplittingData;Integrated Security=True;");
        }
    }
}
