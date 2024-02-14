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
- some basic css to enhance the look
- 3rd party photo gallery - to display photos

## Section 10 - updating resources
- Angular templates forms - access form from html to the component ts file with Viewchild decorator
- updating profile details on client and API side
- CanDeactivate route guard - to protect data loss from leaving the page with unsaved changes in a form
- Adding loading indicators to the client side
- Caching data using angular services instead of loading data from API everytime a component is loaded.
- components are temporary to the window i.e. they refresh when a page is loaded.
- services on the other hand, are alive until the life of the application (meaning they stay alive until the app is closed or the whole app is refreshed)

## Section 11 - photo uploading functionality
- Photo storage options
  - in binary large options in database - disadvantage - they are very large and not optimized
  - file system in server - optimized way to store - but have to think about how much storage we are using - also to consider aspect ratio of upload by users need to add extra logic for this if we want only square images
  - use cloud service - virtually unlimited storage but can be expensive - using a free service from Cloudinary
- Image upload 
    - drag and drop an image on app
    - only authenticated users can upload - need their JWT token
    - server uploads photo to clourinary
    - cloudinary stores photo & sends response
    - API saves photo url and public Id of images which saves to DB
    - auto-generated ID from database - this returns to client - 201 created response with the id to the client so they can display the image
- Adding related entities
- Using 3rd party API - photo storage options
- Using & practicing Debugger
- Updating and deleting resources in API controller
- What to return when creating resources in a REST based API - not RESTFUL as we confirm to dotnet and angular rules

## Section 12 - angular reactive forms
- Use reactive forms (advanced usage)
  - built around observable streams
  - reactive forms are component-based as opposed to angular template forms - so reactive forms give more control for customizing validation
  - inputs are values can be used synchronously - easier to test
- Use Angular Validation - implement custom validation input on client side 
- Implementing reusable form controls - with setting up boilerplate - form controls for inputs used at this stage
- Working with Date inputs - moving away from browser input

## Section 13 - paging sorting and filtering
- implement Pagination on the API client
- deferred execution using iQueryable
    - iQueryable<User>
    - var query = context.Users.Where(x => x.Gender == gender).OrderBy(x => x.UserName).Take(5).Skip(5).AsQueryable()
    - executing
    - query.ToListAsync()
    - query.ToArrayAsync()
    - query.ToDictionary()
    - query.Count()
- implement filtering on the API & client side
- using action filters
- adding a TimeAgo pipe
- Implementing caching in the client for the pagination
- Pagination - helps avoid performance problems
- Parameters are passed by query string: eg https://localhost:5001/api/users?pageNumber=1&pageSize=5
    - Page size should be limited
    - we should always page result

## Section 15 - adding messaging
- many to many relationship
- query params in angular
- using route resolvers in angular
- create entity - add list in AppUser - add connection in Data/dataContext file - add message reposotory

## Section 17 - Signal R
- implementing signalR to inplement live chat 
- connection management automatically
- reconnect automatically to server in network issues
- Signal R supports these below:
  - WebSockets (typically preferred to this)
  - Server-sent events - fallback
  - Long polling - fallback

## Section 19 - Publishing
- switch DBs - SQLite to postGres QL
- serving static content from the API server
- integrate publishing platform on Github
- When publishing
  - environment variables
  - localhost
  - CORS - if hosting the client app in different domain
  - Database change to postgrees - entity framework uses with all relational DB not non-relational DB
  - Capacity/scalibality
  - Seed data
  - Fake delays - remove them


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
- docker run --name postgres -e POSTGRES_PASSWORD=postgrespw -p 5432:5432 -d postgres:latest - this runs the docker sql file

after committing changes on main branch
- ng build --prod : adds changes to wwwroot folder
- then gaa && gcmsg "" then push to main

## Stretch
- Caching data for making app faster
