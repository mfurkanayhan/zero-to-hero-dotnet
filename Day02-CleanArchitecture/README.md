# 🧱 Day 02 – Clean Architecture in .NET 9

This project demonstrates a basic **ToDo API** using Clean Architecture principles in ASP.NET Core (.NET 9).

It consists of 4 layers:

```
CleanArchitecture/
├── Domain/
├── Application/
├── Infrastructure/
└── WebAPI/
```

---

## 📐 Project Structure

| Layer         | Responsibilities |
|---------------|------------------|
| **Domain**     | Core business logic & entities (`ToDoItem`) |
| **Application**| Business services (`TodoService`) and use cases |
| **Infrastructure** | Data access (EF Core with InMemory DB) |
| **WebAPI**     | API endpoints & presentation layer |

---

## 🧪 Tech Stack

- ASP.NET Core 9 (Minimal Hosting)
- Entity Framework Core InMemory
- Swagger UI for testing
- Clean Architecture layered design
- Dependency Injection

---

## ✅ Features

- `GET /api/todo` → Get all todos  
- `GET /api/todo/{id}` → Get a todo by ID  
- `POST /api/todo` → Add a new todo  
- `PUT /api/todo` → Update an existing todo  
- `DELETE /api/todo/{id}` → Delete a todo  

---

## 🚀 Getting Started

### 🔧 Run the application

```bash
dotnet run --project WebAPI
```

### 🌐 Open Swagger

```text
https://localhost:{PORT}/swagger
```

You can test all endpoints interactively.

---

## ✍️ Author

By **Muhammet Furkan Ayhan**  
GitHub → [mfurkanayhan](https://github.com/mfurkanayhan)

---

## 📁 Related Projects

- [Day01 - CSharp OOP + SOLID](../Day01-CSharp-OOP-SOLID/README.md)  
- ✅ This is `Day 02` of the [ZeroToHeroDotNet](https://github.com/mfurkanayhan/zero-to-hero-dotnet) series.