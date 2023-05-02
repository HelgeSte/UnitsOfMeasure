using Employees_CreateTable.Data;
using Employees_CreateTable.Models;

using EmployeesDbContext context = new EmployeesDbContext();

Employee donald = new Employee()
{
    FirstName = "donald",
    LastName = "duck",
    Gender = "male",
    Email = "donald@duckburg.com",
    Mobile = "555-313"
};

Employee daisy = new Employee()
{
    FirstName = "daisy",
    LastName = "duck",
    Gender = "female",
    Email = "daisy@duckburg.com",
    Mobile = "555-7175"
};

Employee mickey = new Employee()
{
    FirstName = "mickey",
    LastName = "mouse",
    Gender = "male",
    Email = "mickey@duckburg.com",
    Mobile = "555-9325"
};

Employee homer = new Employee()
{
    FirstName = "homer",
    LastName = "simpson",
    Gender = "male",
    Email = "homer@springville.com",
    Mobile = "555-1254"
};

Employee james = new Employee()
{
    LastName = "bond",
    FirstName = "james",
    Gender = "male",
    Email = "james.bond@mi-5.gov.uk",
    Mobile = "007"
};

Employee butters = new Employee()
{
    FirstName = "butters",
    LastName = "stotch",
    Gender = "male",
    Email = "butters.stotch@southpark.Email",
    Mobile = "555-1235"
};

Employee cartman = new Employee()
{
    FirstName = "Eric",
    LastName = "Cartman",
    Email = "RespectMyAuthoritha@Eric.Cartman.gov",
    Mobile = "555-1270"
};

//context.Employees.Add(donald);
//context.Employees.Add(daisy);
//context.Employees.Add(mickey);
//context.Employees.Add(homer);
//context.Employees.Add(james);
//context.Employees.Add(butters);

//context.SaveChanges();