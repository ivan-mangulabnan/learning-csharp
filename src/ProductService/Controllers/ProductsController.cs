using Microsoft.AspNetCore.Mvc;
using ProductService.Models;

namespace ProductService.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
  Product[] products = [
      new Product { Id = 1, Name = "Coke", Price = 10.5m },
      new Product { Id = 2, Name = "Sprite", Price = 10.5m },
      new Product { Id = 3, Name = "Royal", Price = 10.5m },
  ];

  [HttpGet]
  public IActionResult GetProducts ()
  {
    return Ok(products);
  }

  [HttpGet("{id}")]
  public IActionResult GetProduct (int id)
  {
    Product? targetProduct = Array.Find(products, p => p.Id == id);
    if (targetProduct is null) return NotFound("Product does not exist");
    return Ok(targetProduct);
  }

  [HttpPost]
  public IActionResult CreateProduct (Product product)
  {
    bool productDoesNotExist = Array.FindIndex(products, p => p.Id == product.Id) == -1;
    if (productDoesNotExist) return CreatedAtAction(nameof(GetProduct), new { id = product.Id}, product);
    return BadRequest();
  }
}