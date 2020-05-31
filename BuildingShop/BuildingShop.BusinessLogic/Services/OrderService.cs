using BuildingShop.Domain.DomainObjects;
using BuildingShop.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingShop.BusinessLogic.Services
{
    public class OrderService
    {
        private readonly ApplicationDbContext _context;

        public OrderService(ApplicationDbContext context)
        {
            _context = context;
        } 

        public async Task<List<Order>> GetAllOrders()
        {
            return await _context.Orders.ToListAsync();
        }

        public async Task<Order> GetOrder(int orderId)
        {
            return await _context.Orders.FindAsync(orderId);
        }

        public async Task CreateOrder(Order order)
        {
            order.Deliveries = _context.Deliveries
                .Where(d => d.Date <= order.EndDate && d.Date >= order.StarDate)
                .ToList();
            order.Purchases = _context.Purchases
                .Where(d => d.Date <= order.EndDate && d.Date >= order.StarDate)
                .ToList();

            order.StartingAmount = _context.ProductAmountTrackers.Where(a => a.Date < order.StarDate).LastOrDefault().Amount;

            //order.EndAmount = 
        }

        public async Task DeleteOrder(int orderId)
        {
            var order = await _context.Orders.FindAsync(orderId);
            _context.Orders.Remove(order);
            await _context.SaveChangesAsync();
        }
    }
}
