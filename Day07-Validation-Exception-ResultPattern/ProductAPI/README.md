# Day 07 - FluentValidation, Exception Handling & Result Pattern

A simple .NET 9 Web API project demonstrating input validation with FluentValidation, centralized exception handling, and standardized API responses using a `Result<T>` wrapper.

---

## 📁 Project Structure

```
Day07-Validation-Exception-ResultPattern/
├── ProductAPI/
│   ├── Common/
│   │   └── Result.cs
│   ├── Controllers/
│   │   └── ProductsController.cs
│   ├── Middlewares/
│   │   └── ExceptionMiddleware.cs
│   ├── Models/
│   │   └── Product.cs
│   ├── Validators/
│   │   └── ProductValidator.cs
│   ├── Program.cs
│   └── ProductAPI.csproj
└── Day07-Validation-Exception-ResultPattern.sln
```

---

## 🔧 Features

- ✅ FluentValidation for model validation
- ✅ Centralized error handling with custom middleware
- ✅ Standard API responses using `Result<T>` class
- ✅ Endpoints return consistent JSON format

---

## 🔌 Endpoints

| Method | Route                    | Description           |
|--------|--------------------------|-----------------------|
| GET    | `/api/products/getall`   | Get all products      |
| POST   | `/api/products/create`   | Add a new product     |
| POST   | `/api/products/update`   | Update existing item  |
| POST   | `/api/products/delete`   | Delete product by id  |

---

## 🚀 How to Run

```bash
cd Day07-Validation-Exception-ResultPattern
dotnet run --project ProductAPI
```

Then visit:

```
http://localhost:{port}/swagger
```

---

## 📦 Technologies

- .NET 9
- ASP.NET Core Web API
- FluentValidation
- Custom Middleware
- Swagger / Swashbuckle

---

## 👤 Author

**Muhammet Furkan Ayhan**  
[GitHub Profile](https://github.com/mfurkanayhan)

---

Venturing into best practices, one day at a time ☕