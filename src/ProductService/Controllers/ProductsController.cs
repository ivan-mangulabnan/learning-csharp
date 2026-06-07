using Microsoft.AspNetCore.Mvc;
using ProductService.Models;

namespace ProductService.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
  List<Product> products  = [
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
    Product? targetProduct = products.Find(p => p.Id == id);
    if (targetProduct is null) return NotFound("Product does not exist");
    return Ok(targetProduct);
  }

  [HttpPost]
  public IActionResult CreateProduct (Product product)
  {
    bool productDoesExist = products.FindIndex(p => p.Id == product.Id) != -1;
    if (productDoesExist) return BadRequest();
    products.Add(product);
    return CreatedAtAction(nameof(GetProduct), new { id = product.Id}, product);
  }

  [HttpPut("{id}")]
  public IActionResult UpdateProduct (int id, [FromBody] Product product)
  {
    int targetIndex = products.FindIndex(p => p.Id == id);
    bool productExists = targetIndex != -1;

    if (productExists)
    {
      products[targetIndex] = product;
      return NoContent();
    }

    return NotFound("Product does not exist");
  }

  [HttpDelete("{id}")]
  public IActionResult DeleteProduct (int id)
  {
    int targetIndex = products.FindIndex(p => p.Id == id);
    bool productExists = targetIndex != -1;

    if (productExists)
    {
      products.RemoveAt(targetIndex);
      return NoContent();
    }

    return NotFound("Product does not exist");
  }
}