using BuildingShop.Domain.DomainObjects;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BuildingShop.BusinessLogic.Interfaces
{
    public interface IOrderService
    {
        Task CreateOrder(Order order);
        Task DeleteOrder(int orderId);
        Task<List<Order>> GetAllOrders();
        Task<Order> GetOrder(int orderId);
    }
}