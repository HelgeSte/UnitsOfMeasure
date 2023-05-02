using Employees_ReverseEngineering.Data;
using Employees_ReverseEngineering.Models;

using SplitEmployeesContext context = new SplitEmployeesContext();

foreach(Employee employee in context.Employees)
{
    Console.WriteLine($"{employee.FirstName} {employee.LastName}: \t{employee.Email}");
}