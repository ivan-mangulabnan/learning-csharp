using OrderService.Models;

namespace OrderService.Services;

public interface IOrderService
{
    IEnumerable<Order> GetAll();
    Order? GetById(int id);
    Order Create(Order order);
    bool Update(int id, Order order);
    bool Delete(int id);
}