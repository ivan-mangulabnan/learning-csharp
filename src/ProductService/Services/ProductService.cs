using ProductService.Models;

namespace ProductService.Services;

public class ProductService : IProductService
{
  List<Product> products  = [
      new Product { Id = 1, Name = "Coke", Price = 10.5m },
      new Product { Id = 2, Name = "Sprite", Price = 10.5m },
      new Product { Id = 3, Name = "Royal", Price = 10.5m },
  ];

  public List<Product> GetAll()
  {
    return products;
  }

  public Product? GetById (int id)
  {
    var targetIndex = products.FindIndex(p => p.Id == id);
    return targetIndex == -1 ? null : products[targetIndex];
  }

  public Product Create (Product product)
  {
    products.Add(product);
    return product;
  }

  public bool Update (int id, Product product)
  {
    var targetIndex = products.FindIndex(p => p.Id == id);
    if (targetIndex == -1) return false;
    products[targetIndex] = product;
    return true;
  }

  public bool Delete (int id)
  {
    var targetIndex = products.FindIndex(p => p.Id == id);
    if (targetIndex == -1) return false;
    products.RemoveAt(targetIndex);
    return true;
  }
}