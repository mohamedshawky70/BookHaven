# BookHaven MVC Project

# Project Mind Map
![Image](https://github.com/user-attachments/assets/06bbdbdd-522a-4dc3-9943-8526af52bf4a)

## Project Overview

**Objective:** This is a Library Management System (LMS) web application built with .NET Core, designed to streamline the process of managing books, users, and borrowing records in a library. The system allows librarians and administrators to track books, users, issue/return books, and manage user roles.

## Tech Stack
-Backend: .NET Core 8 
-Frontend: HTML, CSS (Bootstrap or other frameworks can be used)
-Database: SQL Server (or SQLite for local setup)
-Authentication: ASP.NET Core Identity for user authentication
-ORM: Entity Framework Core for database interactions

## Key Features
-**WhatsApp Integration**: Subscribers and Users can receive notifications and updates via WhatsApp (e.g., book availability, due dates, reminders).

-**Email notificatin**: Subscribers and Users can receive notifications like welcom notification and renew notification. 

-**background tasks**: operations that run asynchronously or in the background, typically without direct interaction with a user.

-**Export Reports**:Export Excel sheet and Pdf for books , rentals and delay in rentals.

-**Save Images**:Save images on cloud (Cloudinary).

-**User Authentication**: Admin and user login functionality.

-**Book Management**: Add, update, delete, and search books in the library.

-**Borrowing System**: Issue and return books with due dates.

-**User Management**: Manage user profiles and roles (Admin/User).

-**Search Functionality**: Search for books by title and search for subscriber by email ,notional id phon number.

-**Book Categories**: Organize books by genre/category.

-**Responsive UI**: A simple, clean, and responsive user interface.




## Development Focus

### 1. [Genaric Repository Pattern](#repository-pattern)
- **Description:** Implement the Repository Pattern to abstract data access logic, making the code more testable and maintainable. 
- **Functionality:**
  - **Genaric Repository Pattern:** Simplifies data access by providing a consistent API for CRUD operations.
  - **Unit of Work:** Manages transactions across multiple repositories, ensuring data integrity.


### 2. [Entity Framework Core](#entity-framework-core)
- **Description:** Handle database interactions using Entity Framework Core, allowing for seamless integration with the database. The use of code-first migrations ensures that the database schema is in sync with the application models.
- **Features:**
  - **Code-First Migrations:** Automatically generate database schema from your code.
  - **Entity Mapping:** Ensure proper mapping of domain entities to database tables.

### 3. [Theme Integration](#theme-integration)
- **Description:** Integrate a pre-built theme into the project. Customize the theme to match the project’s requirements, ensuring it works well with ASP.NET Core.
- **Customization:** Modify the theme to align with the branding and functional needs of the project, ensuring consistency across all pages.

### 4. [User and Role Management](#user-and-role-management)
- **Description:** Implement user and role management using Microsoft ASP.NET Identity. This includes functionalities for user registration, login, role assignment, and permissions management.

### 5. Admin Capabilities
- **Create, Update, Delete Books:** Manage the books inventory with full CRUD operations.
- **Manage Categories:** Add, edit, or remove categories.
- **Manage Books:** Add, edit, or remove books.
- **Manage Subscriber** Add ,renew Subscriber's subscribtion,delete Subscriber's subscribtion,check if subscription paid penality and check if return book that he rantal.
- **User Management:** Create users, assign roles, lock or unlock users, and delete users as needed.
- **Role Assignment:** Define and assign roles such as Admin, Achieve, and Reception, with specific permissions.

### 6. Auth Section
- **Login:** Secure user authentication.
- **Reset Password:** Provide password recovery options.
- **Confirm Email** Sent Email virefication to user to avoid fake emails.
- **Edit Profile:** Enable users to update their personal information and settings.

### 7. [JavaScript Libraries](#javascript-libraries)
- **Description:** Utilize JavaScript libraries to enhance the user interface and provide dynamic functionality.
- **Libraries:**
  - **jQuery DataTables:** For dynamic tables with features like sorting, searching, and pagination.
  - **Toaster JS:** For displaying user-friendly notifications throughout the application.
  - **TinyMCE:**  user-friendly To formattin description book input.
  -  **Select2:**  user-friendly To select book's category and book's author with search.
  - **DateRangPicker:**  user-friendly To select range date time.
  - **Countup.Js:**  user-friendly for numbers.
  - **Flightbox:**  user-friendly for dispblay images.
  - **Bootbox Js confirmed:**  user-friendly to suring action.
  - **TypeAhead:**  user-friendly to searching.

### 8. [Admin Dashboard](#admin-dashboard)
- **Description:** Develop an admin dashboard that allows system administrators to manage the project effectively.
- **Features:**
  - **User Management:** View, create, update, and delete users.
  - **Role Management:** Assign and manage user roles.
  - **Book Management:** Oversee book listings, including adding, editing, and deleting products.
  - **rentals Management:** Add ,renew Subscriber's subscribtion,delete Subscriber's subscribtion,check if subscription paid penality and check if return book that he rantal.
  - **Charts:** Rentals Per Day,Subscribers Per City.

### 9. [Pagination](#pagination)
- **Description:** Implement pagination to manage large sets of products across multiple pages, ensuring a user-friendly experience.
- **Functionality:** Pagination will be integrated with search and filter functionalities to allow users to easily navigate through products.

### 10. [Session Management](#session-management)
- **Description:** Manage user sessions effectively, ensuring data is maintained across user interactions with the site.
- **Session Features:** 
  - Maintain user state across different pages.
  - Secure sensitive session data.

### 12. [Publishing to Monester](#publishing-to-monester)
- **Description:** Deploy the project on Monester, ensuring the deployment process is smooth and the application is optimized for the platform.
- **Deployment Focus:** Ensure the application is configured for performance, security, and scalability in a cloud environment.

### 13. [Publishing locally on IIS (Internet Information Services)](#Publishing locally on IIS (Internet Information Services))
- **Isolated Environment:** Running your website locally on IIS allows you to test and debug in an environment
    that is isolated from your production server. This helps in identifying and fixing issues without affecting live users.

### 14. [Data Seeding](#data-seeding)
- **Description:** Seed initial data for the admin role and users to ensure the system starts with essential data, improving ease of testing and initial use.
- **Seeded Data:**
  - **Admin Role:** Pre-configured admin role with full access.
  - **Sample Users:** Initial users with different roles for testing purposes.
---

## Links
- **[Project Repository](https://github.com/mohamedshawky70/BookHaven)**
