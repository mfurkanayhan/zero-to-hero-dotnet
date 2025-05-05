# Day 05 - Authentication & Authorization

Basic JWT-based authentication and role-based authorization in ASP.NET Core 9 Web API.

---

## Project Structure

```
Day05-Auth/
??? AuthAPI/
?   ??? Controllers/
?   ?    ??? AuthController.cs
?   ?    ??? SecureController.cs
?   ??? Models/
?   ?    ??? User.cs
?   ??? Services/
?   ?    ??? TokenService.cs
?   ??? Program.cs
?   ??? appsettings.json
```

---

## Endpoints

| Method | Route                       | Auth Requirement    | Description          |
| ------ | --------------------------- | ------------------- | -------------------- |
| POST   | `/api/auth/login`           | Public              | Generate JWT token   |
| GET    | `/api/secure/public`        | None                | Accessible by anyone |
| GET    | `/api/secure/authenticated` | Authenticated users | Requires valid JWT   |
| GET    | `/api/secure/admin`         | Role: Admin         | Requires admin role  |

---

## How to Test

1. **Run the project:**

```bash
dotnet run --project AuthAPI
```

2. **Go to Swagger UI:**

```
http://localhost:{port}/swagger
```

3. **Login as a user:**

```json
{
  "username": "user",
  "password": "1234"
}
```

4. **Login as admin:**

```json
{
  "username": "admin",
  "password": "1234"
}
```

5. **Authorize in Swagger** using the JWT token you received and test protected endpoints.

---

## Features Implemented

* JWT Token generation using secret key
* Adding `claims` and `roles` to token
* `[Authorize]` & `[Authorize(Roles = "Admin")]` filters
* Custom forbidden message for 403 responses
* Swagger UI authorization

---

## Technologies

* ASP.NET Core 9
* JWT Bearer Authentication
* Role-based Authorization
* Swagger (Swashbuckle)

---

## Author

**Muhammet Furkan Ayhan**
[GitHub Profile](https://github.com/mfurkanayhan)

---

Happy coding! ??
