Starting with a database with one single table, since it were easier to convert pocsUnit22.csv to a single table. It could be possible to use som SQL statements to split it up into multiple tables, 
but I think the joins could be a problem, and it's probably easier to do something like that, by using Entity Framework. 

My plan is to create a class library with a dependency injection for the SQL connection and then an API that uses the class library.

Scaffold-DbContext command for retrieving something from database
Scaffold-DbContext "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=uom2023;Integrated Security=True;" Microsoft.EntityFrameworkCore.SqlServer -ContextDir Data -OutputDir Models


Made some changes to the database:
* Changed CatalogSymbol__isExplicit to bit type, instead of varchar.  Used bit, since SQL Server doesn't have any boolean type.
* Fixed som errors, that were caused by commas and double-quotes in the values of the csv file. I should have ignored any commas that were followed by a space,
  and any double-quotes.
* Added new length to most of the columns, since my first script for creating the UnitOfMeasures table created all columns with varchar(255)
* After I had recreated the UnitsOfMeasure table and inserted the values, I deleted the Data and Models folders, and ran the Scaffold-DbContext
  command again, with -DataAnnotions, to make it respect my new column sizes:
  Scaffold-DbContext "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=uom2023;Integrated Security=True;" Microsoft.EntityFrameworkCore.SqlServer -ContextDir Data -OutputDir Models -DataAnnotation

Create 2 more tables in the database
I'm considering creating new tables for QuantityTypes and SameUnits, since these are numbered in the database, just as they were in the pocsUnit22.csv file.
If I don't do this, It'll be more difficult to code for these types, and I will get a problem if anyone tries to add extra QuantityTypes or SameUnits.

The Base Units and Customary units could have been split into 2 new tables, but I don't think it's necessary. I think it should be easy to code a test
for this. 

# Trying to find info on how to use Entity Framework to split data:
1. https://www.youtube.com/watch?v=kGdUtm7UBxc
2. https://learn.microsoft.com/en-us/ef/core/modeling/table-splitting