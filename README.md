## National Park Web API Application

## Contributions by Stephen Zook

## Technologies Used

* Swagger
* JWT
* ASP.NET Core
* EF Core

### No known bugs at this time

## How To Run This Project

### Install Tools

Install the tools that are introduced in [this series of lessons on LearnHowToProgram.com](https://www.learnhowtoprogram.com/c-and-net/building-an-api/building-an-api-objectives).

### Set Up and Run Project

1. Clone this repo.
2. Open the terminal and navigate to this project's production directory called "ParksLookUpApi".
3. Within the production directory "ParksLookUpApi", create a new file called `appsettings.json`.
4. Within `appsettings.json`, put in the following code, replacing the `uid` and `pwd` values with your own username and password for MySQL.

```json
{
    "JwtSettings": {
        "securitykey": "[YOURKEYNAMEHERE]"
    },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=parks-lookup;uid=[USERNAME];pwd=[PASSWORD];"
  }
}
```
4. Within the production directory "ParksLookUpApi", create a new file called `appsettings.Development.json`.
5. Within `appsettings.Development.json`, put in the following code:
```json
{
    "Logging": {
      "LogLevel": {
        "Default": "Information",
        "Microsoft": "Trace",
        "Microsoft.AspNetCore": "Information",
        "Microsoft.Hosting.Lifetime": "Information"
      }
    }
  }
```
6. Create the database using the migrations in the To Do List project. Open your shell (e.g., Terminal or GitBash) to the production directory "Factory", and run `dotnet ef database update`. 
    - To optionally create a migration, run the command `dotnet ef migrations add MigrationName` where `MigrationName` is your custom name for the migration in UpperCamelCase. To learn more about migrations, visit the LHTP lesson [Code First Development and Migrations](https://www.learnhowtoprogram.com/c-and-net-part-time/many-to-many-relationships/code-first-development-and-migrations).
7. Within the production directory "ParksLookUpApi", run `dotnet run` in the command line to start the project in development mode.
8. Open the browser to _https://localhost:5001/swagger. If you cannot access localhost:5001 it is likely because you have not configured a .NET developer security certificate for HTTPS. To learn about this, review this lesson: [Redirecting to HTTPS and Issuing a Security Certificate](https://www.learnhowtoprogram.com/lessons/redirecting-to-https-and-issuing-a-security-certificate).
9. Scroll down to User Post action in the Swagger UI, click the 'Try it Out' button. Replace the strings with "admin" and "password" to generate a JWT token. Optionally you can rename the UserId and Password in ParksLookUpApiContext to your own creditionals and enter them here after using the command 'dotnet ef migrations add MigrationName and dotnet ef database update.
```json
{
  "username": "string",
  "password": "string"
}
```
10. Copy the generated token to the clipboard and open Postman
11. Open a new GET action in Postman. Enter http://localhost:5000/api/parks In the Headers options enter "Authorization" for the Key field. Next in the value field  "bearer [YOUR GENERATED KEY HERE]"
12. Click the SEND button and the JSON endpoints should appear.


## API ENDPOINTS

* http://localhost:5000/api/parks for all parks information
* http://localhost:5000/api/parks{id} for a specific park containing that ID number
* http://localhost:5000/api/parks?state=[ANY STATE HERE] is a query that will show all parks associated with that state
* http://localhost:5000/api/parks?state=[ANY NAME HERE] is a query that will show the state associated with that name


MIT License

Copyright (c) [2023] [Stephen David Zook]

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.