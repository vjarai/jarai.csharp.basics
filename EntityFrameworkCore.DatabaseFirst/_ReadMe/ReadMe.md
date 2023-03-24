# Database First mit EF Core

https://learn.microsoft.com/de-de/ef/core/managing-schemas/scaffolding/?tabs=dotnet-core-cli

- Beiligende Northwind.sql auf lokalem SQL Server ausführen
- Tools->Nuget Packet Manager->Packet Manager Console
- Im Fenster Package Manager Console nacheinander eingeben:<br><br>
Install-Package Microsoft.EntityFrameworkCore.Tools<br>
Install-Package Microsoft.EntityFrameworkCore.SqlServer<br>
Install-Package Microsoft.EntityFrameworkCore.Design<br>
Scaffold-DbContext 'Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind' Microsoft.EntityFrameworkCore.SqlServer<p>