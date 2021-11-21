# filtro_blazor

- gerar projeto blazor
dotnet new blazorserver

- Pacotes para instalar
dotnet add package Microsoft.EntityFrameworkCore.Relational -v 3.1.12
dotnet add package Microsoft.EntityFrameworkCore.SqlServer -v 3.1.12
dotnet add package Microsoft.EntityFrameworkCore.Tools -v 3.1.12
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design -v 5.0.2
dotnet add package Pomelo.EntityFrameworkCore.MySql -v 3.2.4 

- instalar dotnet-ef
dotnet tool install --global dotnet-ef

- Gerar configuração do banco de dados
dotnet-ef dbcontext scaffold "server=localhost;uid=usuario;pwd=senha;database=banco de dados" Pomelo.EntityFrameworkCore.MySql


