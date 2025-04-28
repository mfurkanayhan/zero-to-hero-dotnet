# Day 03 - WebAPI Basics

Simple Product Management API built with ASP.NET Core WebAPI (.NET 9).

---

## Project Structure

```
Day03-WebAPI-Basics/
├── ProductAPI/
│   ├── Controllers/
│   │    └── ProductsController.cs
│   ├── Models/
│   │    └── Product.cs
│   ├── Program.cs
│   ├── ProductAPI.csproj
└── Day03-WebAPI-Basics.sln
```

---

## Endpoints

| Method | Route                  | Description                 |
|:------:|:----------------------:|:----------------------------|
| GET    | `/api/products`         | Get all products             |
| GET    | `/api/products/{id}`     | Get product by id            |
| POST   | `/api/products`         | Create new product           |
| PUT    | `/api/products/{id}`     | Update existing product      |
| DELETE | `/api/products/{id}`     | Delete product by id         |

---

## How to Run

1. Navigate to the project folder:

```bash
cd Day03-WebAPI-Basics
```

2. Build and run the API:

```bash
dotnet run --project ProductAPI
```

3. Open browser and visit:

```
http://localhost:{port}/swagger
```

(Port is displayed in terminal after starting the project.)

---

## Technologies

- .NET 9
- ASP.NET Core WebAPI
- Swagger (Swashbuckle)
- File-scoped namespaces

---

## Author

**Muhammet Furkan Ayhan**  
[GitHub Profile](https://github.com/mfurkanayhan)

---

Happy coding! 🚀

