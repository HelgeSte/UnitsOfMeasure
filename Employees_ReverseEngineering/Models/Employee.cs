using System;
using System.Collections.Generic;

namespace Employees_ReverseEngineering.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? Gender { get; set; }

    public string Email { get; set; } = null!;

    public string Mobile { get; set; } = null!;

    public string? LandLine { get; set; }
}
