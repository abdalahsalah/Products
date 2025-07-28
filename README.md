# Project Readme

## Overview

This is an **ASP.NET Core MVC** project designed for managing products and their associated categories. The application provides full **CRUD (Create, Read, Update, Delete)** functionality for products, along with user authentication capabilities to secure access.

## Project Structure

This project follows a standard ASP.NET Core MVC structure, organized into logical components:

### Controllers

* `HomeController.cs` - Handles home page and privacy page actions

* `ProductsController.cs` - Manages all product-related operations (CRUD)

### Data

* `ProductsContext.cs` - Entity Framework Core DbContext for database operations

* `Migrations/` - Contains database migration files for schema changes

### Models

* **`ErrorViewModel.cs`**: Defines the model used for displaying error information.

* **`LoginViewModel.cs`**: Represents the data model for user login functionality.

* **`Products.cs`**: The entity model for products, including their properties.

* **`Categories.cs`**: The entity model for product categories.

### Views

* **Home**: Contains the views for the application's home page and privacy page.

* **Products**: Houses all views for product management, such as `Create.cshtml`, `Details.cshtml`, `Edit.cshtml`, and `Index.cshtml`.

* **Shared**: Includes common layout and shared components:

  * **`_Layout.cshtml`**: The main application layout, providing a consistent structure across pages.

  * **`_ValidationScriptsPartial.cshtml`**: Contains client-side validation scripts.

  * **`Error.cshtml`**: The view displayed when an error occurs.

### Properties

* **`launchSettings.json`**: Configures application launch profiles for different development environments.

## Prerequisites

Before you can set up and run this project, ensure you have the following installed:

* **.NET Core SDK**: The version should match the project's target framework.

* **SQL Server or compatible database provider**: The application is designed to work with a SQL Server database, but can be adapted for others.

* **Entity Framework Core tools**: Required for applying database migrations.

## Setup Instructions

Follow these steps to get the project up and running on your local machine:

1. **Clone the repository**

   ```
   git clone [(https://github.com/abdalahsalah/Products)]
   
   ```

2. **Restore dependencies**
   Navigate to the project's root directory in your terminal and run:

   ```
   dotnet restore
   
   ```

   This command downloads all necessary NuGet packages.

3. **Apply database migrations**
   After restoring dependencies, apply the database migrations to create or update your database schema:

   ```
   dotnet ef database update
   
   ```

4. **Run the application**
   Finally, start the application:

   ```
   dotnet run
   
   ```

   This will launch the application, typically accessible via `https://localhost:5001` or `http://localhost:5000` in your web browser.

## Features

This application offers the following key features:

* **Product Management**: Comprehensive functionality to create, read, update, and delete product records.

* **Category Association**: Products can be associated with specific categories, enabling better organization.

* **User Authentication**: Includes login functionality to secure access to certain parts of the application.

* **Responsive Layout**: Designed with CSS styling to ensure a consistent and user-friendly experience across various devices.

* **Client-Side Validation**: Forms incorporate client-side validation for immediate user feedback and improved data integrity.

## Configuration

Database connection strings and other environment-specific settings can be configured in the **`appsettings.json`** file.

## Migration Notes

The project includes several Entity Framework Core migrations to manage the database schema's evolution. These migrations cover:

* **Initial product data creation**: Sets up the initial tables for products and categories.

* **Design validation updates**: Incorporates schema changes related to design requirements.

* **Resource assessment updates**: Implements further schema modifications based on resource assessments.

## License

\[Specify your license here, for example: `MIT License`, `Apache 2.0 License`, or state that it's `Proprietary` if no public license is intended.\]

## Contact

For any questions, issues, or support, please contact:
