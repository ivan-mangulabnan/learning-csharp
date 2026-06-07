using Microsoft.AspNetCore.Mvc;
using ProductService.Models;
using ProductService.Services;

namespace ProductService.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
  private readonly IProductService _productService;

  public ProductsController(IProductService productService)
  {
    _productService = productService;  
  }

  [HttpGet]
  public IActionResult GetProducts ()
  {
    var products = _productService.GetAll();
    return Ok(products);
  }

  [HttpGet("{id}")]
  public IActionResult GetProduct (int id)
  {
    Product? targetProduct = _productService.GetById(id);
    if (targetProduct is null) return NotFound("Product does not exist");
    return Ok(targetProduct);
  }

  [HttpPost]
  public IActionResult CreateProduct (Product product)
  {
    bool productDoesExist = _productService.GetById(product.Id) != null;
    if (productDoesExist) return BadRequest();
    _productService.Create(product);
    return CreatedAtAction(nameof(GetProduct), new { id = product.Id}, product);
  }

  [HttpPut("{id}")]
  public IActionResult UpdateProduct (int id, [FromBody] Product product)
  {
    bool updateSuccess = _productService.Update(id, product);

    if (updateSuccess) return NoContent();
    return NotFound("Product does not exist");
  }

  [HttpDelete("{id}")]
  public IActionResult DeleteProduct (int id)
  {
    bool deleteSuccess = _productService.Delete(id);

    if (deleteSuccess) return NoContent();
    return NotFound("Product does not exist");
  }
}