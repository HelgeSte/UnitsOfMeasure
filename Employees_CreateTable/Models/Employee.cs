using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees_CreateTable.Models
{
    internal class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; } = null!; // Sjekk om denne blir NOT NULL i databasen
        public string LastName { get; set; } = null!;
        public string? Gender { get; set; }             // Sammenlikn denne med FirstName og LastName i databasen
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string? LandLine { get; set; }
    }
}
