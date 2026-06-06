# Learning Progress

## Current Status

**Stage:** ProductService — basic GET endpoint working

---

## Built So Far

### ProductService
- `Program.cs` — minimal setup: `AddControllers()`, `AddOpenApi()`, `MapControllers()`
- `Models/Product.cs` — model with `Id (int)`, `Name (string)`, `Price (decimal)`
- `Controllers/ProductsController.cs` — `GET /api/products`, returns hardcoded list

---

## Concepts Covered

- ASP.NET Core project structure vs Express
- `[ApiController]`, `[Route]`, `[HttpGet]` attributes
- `ControllerBase` and returning `IActionResult` / `Ok()`
- C# model properties `{ get; set; }` and default values
- `decimal` for money, namespaces, `using` statements

---

## What's Next

1. Full CRUD on ProductService (`POST`, `PUT`, `DELETE`)
2. In-memory repository + Dependency Injection (DI)
3. Build OrderService
4. Service-to-service HTTP (`HttpClientFactory`)
5. Docker + docker-compose
6. API Gateway
