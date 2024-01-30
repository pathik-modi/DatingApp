# Dating App (Full Stack .Net ASP Angular)

## Stack
- .Net Core - backend
- Angular - front-end/client side
- Entity framework - query database
- Languages: C#, HTML, Bootstrap, CSS, Typescript
- Node.js for angular javascript
- Postman for API testing
- Angular Bootstrap
- MKcert for SSL certificate
- ASP.Net Identity


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

## Section 1 Summary
- Using dotnet CLI
- API controllers and Endpoints
- Entity Framework - get data from database with link queries
- The API project structure
- Configuration and Environment Variables
- Source Control - Github

## Angular - Client Side
- ng add ngx-bootstrap - use Angular bootstrap package with this command - check their website for details

## Mkcert
- Sets up a new server-side certificate for .Net
- mkcert -install

## Authenticaton
- Store password on a database - clear text is not a good option, password hashing is not a good option too.
- Hashing and salting to store passwords
- using Data Transfer Objects (DTO's) - similar usability to Zod
- JSON Web Tokens JWTs - JWT tokens are an industry standard tokens. initially are a string seperated by dot. Benefits of JWT tokens - they manage sessions. they are portable, single token can be used with multiple backends. No cookies required. Performance, once token is issued, there is no need to make a database request to verify a users authentication.

## Section 4 Summary - Authentication
- storing passwords on Database
- Using inheritance in C# - DRY
- Using c# debugger
- Used Data transfer objects DTO's
- Validation
- JSON Web tokens JWTs
- Using services in C# to generate token
- Authentication Middleware
- extension methods - API/Extension folder

## Shortcuts
- dotnet -h - (terminal) - gives you a list of all options for dotnet commands
- dotnet new list - (terminal) - gives you a list of all possible templates you can create
- dotnet new sln - (terminal) - creates a new solution file
- dotnet new webapi -n API --use-controllers
- dotnet sln add API/ - (terminal) - to create sln API and complete - press tab at the end for the backslash
- dotnet sln list - shows what solution it has
- dotnet run - starts server for the app
- dotnet watch - same as "dotnet run" + hot reload - refresh as soon as you change things on your code
- dotnet watch --no-hot-reload - better version than above as hot reload is unreliable
- dotnet ef - initiates the entity framework
- dotnet ef migrations add InitialCreate -o Data/Migrations - initiates the migration mentioned in the command
- dotnet build - builds the database from the migration
- dotnet ef database update - runs the migrations setup on the DB
- ng new client - (After angular has been installed use this code) starts an angular client-side service
- ng serve - sets up an angular client-side server
- mkcert -install - to install mkcert in ssl folder in client folder
- mkcert localhost - to assign the certificate to the localhost certificate
- dotnet dev-certs https --trust - this makes the api server trusted with the https
