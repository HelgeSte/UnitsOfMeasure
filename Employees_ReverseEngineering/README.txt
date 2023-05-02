Packages:
Install-Package Microsoft.EntityFrameworkCore
Install-Package Microsoft.EntityFrameworkCore.Design
Install-Package Microsoft.EntityFrameworkCore.SqlServer
Install-Package Microsoft.EntityFrameworkCore.Tools // Usikker på om denne er nødvendig

Opprett Employee klassen basert på Employees databasen i SplitEmployees databasen:
Connection-String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SplitEmployees;Integrated Security=True;"
Erstatt Connection-String feltet under
Scaffold-DbContext Connection-String Microsoft.EntityFrameworkCore.SqlServer -ContextDir Data -OutputDir Models	