# Day 04 - Entity Framework Core with In-Memory DB

Product management API using Entity Framework Core and In-Memory database for development/testing purposes.

---

## 📁 Project Structure

```
Day04-EntityFrameworkCore/
├── ProductAPI/
│   ├── Controllers/
│   │    └── ProductsController.cs
│   ├── Data/
│   │    └── AppDbContext.cs
│   ├── Models/
│   │    └── Product.cs
│   ├── Program.cs
│   ├── ProductAPI.csproj
└── Day04-EntityFrameworkCore.sln
```

---

## 🔧 Features

- Built CRUD Web API for Product management
- Integrated Entity Framework Core
- Used In-Memory DB provider for testing without external DB
- Implemented all endpoints: GET, POST, PUT, DELETE
- Tested API with Swagger

---

## 🚀 How to Run

```bash
cd Day04-EntityFrameworkCore
dotnet run --project ProductAPI
```

Open in browser: `http://localhost:{port}/swagger`  
(Port appears in terminal output)

---

## 🛠 Tech Stack

- .NET 9
- ASP.NET Core WebAPI
- EF Core with InMemory provider
- Swagger (Swashbuckle)
- File-scoped namespaces

---

## 👤 Author

**Muhammet Furkan Ayhan**  
[GitHub Profile](https://github.com/mfurkanayhan)

---

Happy coding! 🚀