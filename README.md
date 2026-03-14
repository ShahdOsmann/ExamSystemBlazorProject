# ExamBlazorProject

[Demo Link Here](https://drive.google.com/file/d/1WSn7xG9aFjrqeBIzxMbtNlTDIPiSrY0Z/view?usp=sharing)

---

## Technologies Used

- **Blazor Server** (.NET 9)
- **Entity Framework Core** (Code First approach)
- **SQL Server** (Database)
- **Bootstrap 5** (UI & responsive design)
- **JavaScript Interop** 
- **Dependency Injection** 

---

## Project Overview

**ExamBlazorProject** is a Blazor Server application for managing Exams. It is designed for both **Admin** and **User** roles.

- **Admin** can create subjects, exams, questions, and choices.
- **Users** can take exams, track their grades, and view results.
 
---

## Architecture & Structure

The project is organized using **clean architecture principles** with services and repositories:

- **Data Layer**:  handles all EF Core entities. 
- **Repositories**: Generic and specialized repositories handle database operations.
- **Services**: All CRUD operations and business logic go through services 
- **Pages**: 
  - **Admin**: Manage subjects, exams, and questions.
  - **User**: Take exams, see grades, and view results.
- **Configurations**: Dependency injection, authentication, and authorization are configured in `Program.cs`.

 
