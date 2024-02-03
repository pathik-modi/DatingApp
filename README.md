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
- JSON Web Tokens JWTs - JWT tokens are industry standard tokens. initially are a string seperated by dot. Benefits of JWT tokens - they manage sessions. they are portable, single token can be used with multiple backends. No cookies required. Performance, once token is issued, there is no need to make a database request to verify a users authentication.

## Section 4 Summary - Authentication
- storing passwords on the Database
- Using inheritance in C# - DRY
- Using c# debugger
- Used Data transfer objects DTO's
- Validation
- JSON Web tokens JWTs
- Using services in C# to generate a token
- Authentication Middleware
- extension methods - API/Extension folder

## section 5 - Client-side authentication
- using bootstrap to add nav bar
- using Angular forms for registration and login
- Observables and RxJS - its like a promise but can be cancelled, is lazy (so will not execute if no data), and can perform map, filter and other such methods.
- implementing login and register functionality
- two-way binding data
- async pipe - automatically subscribe and unsubscribe

## Section 6 - Angular routing
- implementing routing with Angular app - specially useful for single page app - to organize seeing and hiding different components
- using angular route guards - to stop from seeing some components based on authorization
- adding bootstrap theme
- implemented a shared module under "_modules" folder for external modules
-------------
- app-routing.module.ts defines the routes in the app

## Section 7 - Error handling
- API middleware
- angular interceptors - errors going out and coming into the API server
- Cenralise error handling
- Implementing global error handling - both API & Angular application. On API side we setup an API exception class that went through the API middleware and returned custom errors to front end. API middleware suitable for development mode but can be used in production.
- Angular interceptors - when http request goes to API - check responses from API and instructed how to handle errors coming back
- Troubleshoot exceptions - client-side visibility for error handling

## Section 8 - extending API
- Entity framework relationships on API
- Entity framework conventions - using conventions for relationships in the database
- Seeding data into the database
- Repository pattern - architecture pattern - DB context class - repository mediates between domain and data mapping layers
- AutoMapper utility/tool - this helps quering data from the DB bu selecting the properties you want to return and helps setup relation between two tables easliy
- web server <=> controller <=> repository <=> DB context <=> database
- setup first relationship between tables in the DB
- fully defined relationship between user and photo - so photo can only be added to a user & not without a user
- seeding data to the DB using random generator
- add repository pattern architecture for further abstracting data coming to and from the DB

## Section 9 - building user interface
- components for user interface (client-side)
- using typescript for client-side - very good language and angulr uses typescript by default
- Using async pipe
- using bootstrap for styling - get the look and feel for app
- basic css to enhance look
- 3rd party photo gallery - to display photos

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
- dotnet ef database drop - delete the migrations setup on the DB
- ng new client - (After angular has been installed use this code) starts an angular client-side service
- ng serve - sets up an angular client-side server
- mkcert -install - to install mkcert in ssl folder in client folder
- mkcert localhost - to assign the certificate to the localhost certificate
- dotnet dev-certs https --trust - this makes the api server trusted with the https


## Stretch
- Caching data for making app faster
