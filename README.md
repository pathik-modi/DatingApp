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

## Deployed Link - https://datingapppathik-3e22183e1486.herokuapp.com/

## Key Learnings
- Deployed project to cloud with Heroku
  - used Docker images and hosted Postgres DB URL
  - Converted SQLite DB to Postgres QL
  - Configured Environment variables
  - Serving static content on the API server
  - CORS with client-side hosting in a separate domain
- SignalR
  - implementing live chat
  - connection management automaation
  - SignalR primarily supports WebSockets & falls back to Server-sent events or Long Polling
- Messaging
  - many to many relation management
  - route resolvers in Angular
- Cloud Photo Management with Cloudinary
  - Drag and drop functionality for images
  - Initially accepting on the server then pushing to the cloud (server doesn't store anymore)
- Paging sorting and filtering
  - implementing Pagination on API & Client
  - caching on client-side for pagination
- Angular Reactive forms
  - provides additional control on the component-based forms while setting custom validation and testing
- Error handling middleware
- Server & Client-side authentication

## Setup Development Environment
- Step1:
  - git switch DevelopmentEnv
  - Change the branch to "DevelopmentEnv" as main branch is connected to the deployed version.
- Step 2: Create an "appsettings.json" file in API folder
- Step 3: Paste the app settings text in the "appsettings.json" file.
- Step 4: Open the terminal
  - cd API : go to the API folder
  - dotnet run : run this command to start a local host
  - go to this url: https://localhost:5001/