
https://learn.microsoft.com/de-de/ef/core/managing-schemas/scaffolding/?tabs=dotnet-core-cli

Tools->Nuget Manager->Pakt Manager Console
Install-Package Microsoft.EntityFrameworkCore.Tools
Install-Package Microsoft.EntityFrameworkCore.SqlServer
Install-Package Microsoft.EntityFrameworkCore.Design

Scaffold-DbContext 'Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind' Microsoft.EntityFrameworkCore.SqlServer