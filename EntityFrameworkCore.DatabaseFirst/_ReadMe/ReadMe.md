# Database First mit EF Core

https://learn.microsoft.com/de-de/ef/core/managing-schemas/scaffolding/?tabs=dotnet-core-cli

- Neues Projekt erstellen und als Startprojekt festlegen
- Beiligende Northwind.sql auf lokalem SQL Server ausführen
- Extras->Nuget Paket Manager->Paket Manager Console
- Das neue Projekt  Project in der Paket Manager Console als "Default Project" auswählen
- Im Fenster Paket Manager Console nacheinander eingeben:<br><br>
Install-Package Microsoft.EntityFrameworkCore.Tools<br>
Install-Package Microsoft.EntityFrameworkCore.SqlServer<br>
Install-Package Microsoft.EntityFrameworkCore.Design<br>
Scaffold-DbContext 'Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind' Microsoft.EntityFrameworkCore.SqlServer<p>

