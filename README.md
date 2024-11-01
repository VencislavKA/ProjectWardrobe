1. change ConnectionString in WardrobeT.Data in appsettings.json
2. dotnet restore in the whole sln
3. delete migrations from migrations folder in .Data
4. dotnet ef Migrations add InitialCreate
5. dotnet ef database update
6. then change the runtime connection string in .Web/appsettings.json
