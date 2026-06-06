using Microsoft.AspNetCore.Mvc;
using ProductService.Models;

namespace ProductService.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
  [HttpGet]
  public IActionResult GetProducts ()
  {
    Product[] products = [
      new Product { Id = 1, Name = "Coke", Price = 10.5m },
      new Product { Id = 2, Name = "Sprite", Price = 10.5m },
      new Product { Id = 3, Name = "Royal", Price = 10.5m },
    ];

    return Ok(products);
  }
}