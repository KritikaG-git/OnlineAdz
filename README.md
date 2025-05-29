# Online Advertising Platform-OnlineAdz

This is a role-based web application developed using **ASP.NET Core MVC**, **Entity Framework Core**, and **SQL Server**. The platform enables users to **post, manage, and browse advertisements** across various categories. Developed as part of an internship using **Visual Studio Code**, this project simulates a real-world online classifieds portal.

---

## Project Objective

To build a functional and user-friendly web application that allows:
- Admins to manage advertisements and categories
- Users to create, search, and interact with ads
- Secure, scalable access through role-based features

---

## User Roles & Functionalities

### Administrator:
- Add, modify, view, and delete **ad categories**
- View and manage **all user-posted ads**
- Change **ad statuses** (active/inactive)
- Search and manage **user details**

### User:
- Register and log in to the application
- Search and browse ads by category
- Post new advertisements
- Modify or delete their own ads
- View their own ads and express interest in others

---

## Project Structure

OnlineAdz
┣ 📁Controllers # Business logic and routing
┣ 📁Models # Data models (e.g., User, Ad, Category)
┣ 📁Views # Razor pages for UI
┣ 📁Migrations # EF Core migration history
┣ 📁wwwroot # Static files (CSS, JS, images)
┣ 📄 Startup.cs # Middleware and service config
┣ 📄 Program.cs # App entry point
┣ 📄 DataContext.cs # Database context setup
┣ 📄 appsettings.json # Configuration for DB connection
┣ 📄 OnlineAdz.csproj # Project configuration

---

## Technologies Used

- **Frontend**: ASP.NET Core MVC (Razor Views)
- **Backend**: ASP.NET Core Web API
- **Language**: C#
- **ORM**: Entity Framework Core
- **Database**: SQL Server
- **IDE**: Visual Studio Code

---

## Learning Outcomes

- Implemented **full CRUD functionality** using ASP.NET Core MVC
- Applied **role-based access control** with secure login/logout
- Worked with **Entity Framework Core migrations**
- Gained experience in **real-world software development workflows**
- Understood the structure of MVC applications and best practices for API development

---

## How to Run the Project

1. **Clone the repository**  
2. **Update** the `appsettings.json` file with your SQL Server connection string
3. Run the following in the terminal:
   ```bash
   dotnet ef database update
   dotnet run
4. Open your browser and go to the localhost as per terminal output
   
