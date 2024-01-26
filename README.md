# Dating App (Full Stack .Net ASP Angular)

## Stack
- .Net Core - backend
- Angular - front-end
- Entity framework - query database
- Languages: C#, HTML, Bootstrap, CSS, Typescript
- Node.js for angular javascript
- Postman for API testing

## Walking Skeleton
- Using the dotnet CLI
- API controllers and Endpoints
- Entity Framework
- API project structure
- Configuration and environment variables
- Source control

## Entities framework
- Object-relational mapper (ORM)
- Entity framework - link queries to talk to the Database

## Shortcuts
- dotnet -h - (terminal) - gives you a list of all options for dotnet commands
- dotnet new list - (terminal) - gives you a list of all possible templates you can create
- dotnet new sln - (terminal) - creates a new solution file
- dotnet new webapi -n API --use-controllers
- dotnet sln add API/ - (terminal) - to create sln API and complete - press tab at the end for the backslash
- dotnet sln list - shows what solution it has
- dotnet run - starts server for the app
- dotnet watch - same as "dotnet run" + hot reload - refresh as soon as you change things on your code
- dotnet ef - initiates the entity framework
- dotnet ef migrations add InitialCreate -o Data/Migrations - initiates the migration mentioned in the command
- dotnet build - builds the database from the migration
- dotnet ef database update - runs the migrations setup on the DB
