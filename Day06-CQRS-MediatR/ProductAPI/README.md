# Day 06 - CQRS with MediatR

This project demonstrates how to implement CQRS (Command and Query Responsibility Segregation) in an ASP.NET Core Web API using MediatR.

---

## ?? Concepts Covered

- CQRS (Command-Query Responsibility Segregation)
- MediatR setup and usage
- Command and Query separation
- In-memory data storage via ProductStore
- GET and POST endpoints only (update/delete handled via POST for simplicity)

---

## ?? Project Structure

```
Day06-CQRS-MediatR/
??? ProductAPI/
?   ??? Commands/
?   ?   ??? CreateProductCommand.cs
?   ?   ??? UpdateProductCommand.cs
?   ?   ??? DeleteProductCommand.cs
?   ??? Handlers/
?   ?   ??? CreateProductHandler.cs
?   ?   ??? UpdateProductHandler.cs
?   ?   ??? DeleteProductHandler.cs
?   ??? Queries/
?   ?   ??? GetAllProductsQuery.cs
?   ??? Repositories/
?   ?   ??? ProductStore.cs
?   ??? Controllers/
?   ?   ??? ProductsController.cs
?   ??? Models/
?   ?   ??? Product.cs
?   ??? Program.cs
?   ??? ProductAPI.csproj
??? Day06-CQRS-MediatR.sln
```

---

## ?? How to Run

```bash
cd Day06-CQRS-MediatR
dotnet run --project ProductAPI
```

Visit Swagger UI: `http://localhost:{port}/swagger`

---

## ? Endpoints

| Method | Route                 | Description             |
|--------|----------------------|-------------------------|
| GET    | /api/products        | Get all products        |
| POST   | /api/products        | Create a new product    |
| POST   | /api/products/update | Update an existing one  |
| POST   | /api/products/delete | Delete a product        |

---

## ????? Author

**Muhammet Furkan Ayhan**  
[GitHub Profile](https://github.com/mfurkanayhan)