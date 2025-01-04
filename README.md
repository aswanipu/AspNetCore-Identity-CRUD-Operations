# ASP.NET Core Web App with Identity, CRUD, and Admin Authorization

This project is an implementation of ASP.NET Core Identity for user authentication and authorization. It includes basic CRUD operations on user data and other resources. Users who are not logged in will be redirected to the login page, and only users with admin privileges can perform deletion operations.

## Features

- **User Authentication**: Uses ASP.NET Core Identity for user registration, login, and logout.
- **CRUD Operations**: Provides basic Create, Read, Update, and Delete functionality for user and resource data.
- **Authorization**: Only authenticated users can perform CRUD operations. Deletion operations are restricted to users with an Admin role.
- **Role-based Authorization**: Implements role-based access control (RBAC) to ensure proper permission levels for users.
## Prerequisites

Before running the application, make sure you have the following installed:

- .NET SDK (version 8.0 or higher)
- A database (e.g., SQL Server) configured for Entity Framework
- An IDE (Visual Studio or Visual Studio Code)
### 1. Clone the repository

Clone the repository to your local machine:

```bash
git clone https://github.com/aswanipu/AspNetCore-Identity-CRUD-Operations.git

2. Install Dependencies
Make sure you have all required dependencies installed. Run the following command to restore NuGet packages:
dotnet restore

3. Database Configuration
Make sure your connection string is configured correctly in the appsettings.json file.
The application uses Entity Framework to manage the database. Before running the application, you need to update the database using migrations.

Open the Package Manager Console (in Visual Studio):

Navigate to Tools > NuGet Package Manager > Package Manager Console.
Run the Update-Database Command: This will apply any pending migrations and update your database schema to match the model changes. 
Update-Database

5. Run the Application
After updating the database, run the application:
dotnet run

5. Run the Application
To run the application, execute the following command:

dotnet run

You can now access the app at http://localhost:5000
### Summary of Key Points:

- **`Update-Database`** is used in the Package Manager Console in Visual Studio to apply database migrations.
- You can continue to use `dotnet ef database update` in the terminal if you are using the CLI.
- After the database is updated, the app can be run using `dotnet run`.

This ensures that your database schema stays in sync with your code changes and the application is ready to use.
