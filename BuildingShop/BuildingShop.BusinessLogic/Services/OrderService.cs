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
            
            order.TotalIncome = order.Purchases.Sum(d => d.Amount);
            order.TotalOutcome = order.Deliveries.Sum(d => d.Amount);

            order.StartingAmount = _context.ProductAmountTrackers.Where(a => a.Date < order.StarDate).LastOrDefault().Amount;
            order.EndAmount = order.StartingAmount + order.TotalIncome - order.TotalOutcome;

            var currentDate = order.StarDate;
            int currentAmount = order.StartingAmount;

            order.MinSalePerDay = order.Purchases.Min(p => p.Amount);

            while (currentDate <= order.EndDate)
            {
                currentAmount += order.Deliveries.FirstOrDefault(d => d.Date == currentDate)?.Amount ?? 0
                    - order.Purchases.FirstOrDefault(d => d.Date == currentDate)?.Amount ?? 0;
                if(currentAmount == 0)
                {
                    order.DaysWithoutProduct++;
                }
                currentDate.AddDays(1);
            }

            order.AverageSalesPerDay = (decimal)(order.TotalOutcome / (order.EndDate - order.StarDate).TotalDays);

            order.FinalNumber = (int)(order.AverageSalesPerDay * (decimal)(order.EndDate - order.StarDate).TotalDays);
        }

        public async Task DeleteOrder(int orderId)
        {
            var order = await _context.Orders.FindAsync(orderId);
            _context.Orders.Remove(order);
            await _context.SaveChangesAsync();
        }
    }
}
