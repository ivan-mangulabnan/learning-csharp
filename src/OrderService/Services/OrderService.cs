using OrderService.Models;

namespace OrderService.Services;

public class OrderService : IOrderService
{
    List<Order> orders = [
        new Order { Id = 1, ProductId = 1, OrderDate = DateTime.UtcNow, Quantity = 2 },
        new Order { Id = 2, ProductId = 2, OrderDate = DateTime.UtcNow, Quantity = 1 },
        new Order { Id = 3, ProductId = 3, OrderDate = DateTime.UtcNow, Quantity = 2 }
    ];

    public IEnumerable<Order> GetAll()
    {
        return orders;
    }

    public Order? GetById (int id)
    {
        return orders.Find(o => o.Id == id);
    }

    public Order Create (Order order)
    {
        orders.Add(order);
        return order;
    }

    public bool Update (int id, Order order)
    {
        int targetIndex = orders.FindIndex(o => o.Id == id);
        if (targetIndex == -1) return false;
        orders[targetIndex] = order;
        return true;
    }

    public bool Delete (int id)
    {
        int targetIndex = orders.FindIndex(o => o.Id == id);
        if (targetIndex == -1) return false;
        orders.RemoveAt(targetIndex);
        return true;
    }

}