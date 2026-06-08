# Learning Progress

## Current Status

**Stage:** OrderService in progress — controller started, endpoints pending

---

## Built So Far

### ProductService
- `Program.cs` — minimal setup: `AddControllers()`, `AddOpenApi()`, `MapControllers()`
- `Models/Product.cs` — model with `Id (int)`, `Name (string)`, `Price (decimal)`
- `Controllers/ProductsController.cs` — full CRUD, thin controller delegating to service
- `Services/IProductService.cs` — interface defining the service contract
- `Services/ProductService.cs` — concrete implementation with in-memory `List<Product>`

### Completed
- Registered `IProductService` / `ProductService` in `Program.cs` with `AddScoped` — DI fully wired

### OrderService (in progress)
- `Models/Order.cs` — `Id`, `ProductId`, `OrderDate`, `Quantity`
- `Services/IOrderService.cs` — full CRUD interface defined
- `Services/OrderService.cs` — implemented with in-memory list
- `Controllers/OrderController.cs` — scaffolded, constructor injection done, endpoints pending

---

## Concepts Covered

- ASP.NET Core project structure vs Express
- `[ApiController]`, `[Route]`, `[HttpGet/Post/Put/Delete]` attributes
- `ControllerBase` and `IActionResult` — `Ok()`, `NotFound()`, `NoContent()`, `CreatedAtAction()`
- C# auto-properties `{ get; set; }`, nullable types (`?`), `readonly` fields
- `decimal` for money, namespaces, `using` statements
- `List<T>` vs arrays — dynamic sizing, `.Add()`, `.RemoveAt()`, `.FindIndex()`
- Dependency Injection — interface + implementation pattern, constructor injection, `private readonly`
- Service/controller separation — controller handles HTTP, service handles data logic

---

## What's Next

1. Register the service in `Program.cs` to wire up DI
2. Build `OrderService`
3. Service-to-service HTTP (`HttpClientFactory`)
4. Docker + docker-compose
5. API Gateway
