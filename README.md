# 🚀 CleanCrudApp – ASP.NET Core Clean Architecture API

A modern **ASP.NET Core Web API** built using **Clean Architecture principles**, implementing **CQRS pattern, MediatR, FluentValidation, Entity Framework Core, and PostgreSQL**.

This project demonstrates a scalable and maintainable backend structure suitable for real-world enterprise applications.

---

# 🧱 Architecture Overview

The solution follows **Clean Architecture** with clear separation of concerns:

CleanCrudApp
│
├── Api              → Presentation Layer (Controllers, Swagger)
├── Application      → Business Logic (CQRS, Commands, Queries, Validators)
├── Domain           → Core Entities
├── Infrastructure   → Database, EF Core, Repositories

---

# ⚙️ Technologies Used

- ASP.NET Core Web API  
- Clean Architecture  
- CQRS Pattern  
- MediatR (Command Handling)  
- FluentValidation  
- Entity Framework Core  
- PostgreSQL  
- Swagger / OpenAPI  

---

# ✨ Features

## 📦 Product Module
- Create Product  
- Get All Products  
- Get Product by ID  
- Update Product  
- Delete Product  

---

## 🧠 CQRS Implementation

- Commands → Handle write operations  
- Queries → Handle read operations  
- Separation of responsibilities for better scalability  

---

## 📩 MediatR Integration

All commands are processed through MediatR pipeline:

Controller → MediatR → Pipeline → Handler → Repository  

---

## ✅ FluentValidation

All commands are validated using FluentValidation:

- Product Name → Required, Max 100 characters  
- Price → Must be greater than 0  

Validation runs automatically via MediatR pipeline behavior.

---

## 🗄️ Database

- PostgreSQL database  
- Code-first approach using Entity Framework Core  
- Migrations supported for schema evolution  

---

## 📘 API Documentation

Swagger UI is enabled:

https://localhost:{port}/swagger  

---

# 🧱 Project Structure

Application
│
├── Features
│   └── Products
│       ├── Commands
│       ├── Queries
│       ├── Validators
│
├── Behaviors
│   └── ValidationBehavior.cs

Domain
│   └── Entities
│       └── Product.cs

Infrastructure
│   ├── Data
│   └── Repositories

Api
│   ├── Controllers
│   └── Program.cs

---

# 🔄 Request Flow

## Create Product Flow

Controller  
→ MediatR Command  
→ FluentValidation (Pipeline)  
→ Command Handler  
→ Repository (EF Core)  
→ PostgreSQL Database  

---

# 🚀 Getting Started

## 1️⃣ Clone the repository

git clone https://github.com/your-username/CleanCrudApp.git

---

## 2️⃣ Configure Database

Update appsettings.json:

{
  "ConnectionStrings": {
    "DefaultConnection": "Host=localhost;Port=5432;Database=cleancruddb;Username=postgres;Password=yourpassword"
  }
}

---

## 3️⃣ Run Migrations

dotnet ef migrations add InitialCreate -p Infrastructure -s Api  
dotnet ef database update -p Infrastructure -s Api  

---

## 4️⃣ Run the Application

dotnet run --project Api  

---

# 📍 API Endpoints

| Method | Endpoint | Description |
|--------|----------|-------------|
| GET | /api/products | Get all products |
| GET | /api/products/{id} | Get product by id |
| POST | /api/products | Create product |
| PUT | /api/products | Update product |
| DELETE | /api/products/{id} | Delete product |

---

# 🧠 Key Learning Highlights

- Clean separation of layers  
- CQRS implementation with MediatR  
- FluentValidation with pipeline behavior  
- Repository pattern with EF Core  
- Scalable backend architecture  

---

# 📌 Future Improvements

- JWT Authentication & Authorization  
- AutoMapper integration  
- Global exception handling middleware  
- Unit & Integration Testing  
- Docker support  

---

# 👨‍💻 Author

Developed by Kidist Samuel  
Software Engineer | ASP.NET Core | Angular | Clean Architecture Enthusiast  

---

# ⭐ Support

If you like this project, give it a ⭐ on GitHub and feel free to contribute.
