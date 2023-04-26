Starting with a database with one single table, since it were easier to convert pocsUnit22.csv to a single table. It could be possible to use som SQL statements to split it up into multiple tables, 
but I think the joins could be a problem, and it's probably easier to do something like that, by using Entity Framework. 

My plan is to create a class library with a dependency injection for the SQL connection and then an API that uses the class library.
