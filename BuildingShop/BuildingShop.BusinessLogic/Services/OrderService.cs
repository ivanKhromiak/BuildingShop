using BuildingShop.BusinessLogic.Interfaces;
using BuildingShop.Domain.DomainObjects;
using BuildingShop.Persistence;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace BuildingShop.BusinessLogic.Services
{
    public class OrderService : IOrderService
    {
        private readonly ApplicationDbContext _context;

        public OrderService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Order>> GetAllOrders()
        {
            return await _context.Orders.Include(o => o.Product).ToListAsync();
        }

        public async Task<Order> GetOrder(int orderId)
        {
            return await _context.Orders.Include(p => p.Product).FirstOrDefaultAsync(o => o.Id == orderId);
        }

        public async Task CreateOrder(Order order)
        {
            var Deliveries = await _context.Deliveries
                .Where(d => d.Date <= order.EndDate && d.Date >= order.StartDate && d.ProductId == order.ProductId)
                .ToListAsync();
            var Purchases = await _context.Purchases
                .Where(d => d.Date <= order.EndDate && d.Date >= order.StartDate && d.ProductId == order.ProductId)
                .ToListAsync();

            order.TotalIncome = Deliveries.Sum(d => d.Amount);
            order.TotalOutcome = Purchases.Sum(d => d.Amount);

            order.StartingAmount = (await _context.ProductAmountTrackers
                .Where(a => order.StartDate > a.Date)
                .OrderBy(a => a.Date)
                .ToListAsync())
                .LastOrDefault()
                .Amount;
            order.EndAmount = order.StartingAmount + order.TotalIncome - order.TotalOutcome;

            var currentDate = order.StartDate;
            int currentAmount = order.StartingAmount;

            while (currentDate <= order.EndDate)
            {
                currentAmount += Deliveries.FirstOrDefault(d => d.Date == currentDate)?.Amount ?? 0;
                if (currentAmount == 0)
                {
                    order.DaysWithoutProduct++;
                }
                currentAmount -= Purchases.FirstOrDefault(d => d.Date == currentDate)?.Amount ?? 0;
                currentDate = currentDate.AddDays(1);
            }

            order.MinSalePerDay = Purchases.Min(p => p.Amount);

            order.AverageSalesPerDay = (decimal)(order.TotalOutcome / (order.EndDate.Subtract(order.StartDate).TotalDays + 1));

            order.FinalNumber = (int)(order.AverageSalesPerDay * (decimal)(order.EndDate - order.StartDate).TotalDays);

            await _context.Orders.AddAsync(order);
            await _context.SaveChangesAsync();
        }

        public async Task EditOrder(Order order)
        {
            _context.Update(order);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteOrder(int orderId)
        {
            var order = await _context.Orders.FindAsync(orderId);
            _context.Orders.Remove(order);
            await _context.SaveChangesAsync();
        }

        public async Task<Dictionary<string, string[]>> GetDateInfo(Order order)
        {
            var purchases = await _context.Purchases
                .Where(d => d.Date <= order.EndDate && d.Date >= order.StartDate && d.ProductId == order.ProductId)
                .ToListAsync();
            var deliveries = await _context.Deliveries
                .Where(d => d.Date <= order.EndDate && d.Date >= order.StartDate && d.ProductId == order.ProductId)
                .ToListAsync();

            var currentDate = order.StartDate;
            var dateInfo = new Dictionary<string, string[]>();
            while (currentDate <= order.EndDate)
            {
                dateInfo.Add(
                    currentDate.ToShortDateString(),
                    new string[] {
                        deliveries.FirstOrDefault(p => p.Date == currentDate)?.Amount.ToString() ?? "-",
                        purchases.FirstOrDefault(p => p.Date == currentDate)?.Amount.ToString() ?? "-"
                    }
                );
                currentDate = currentDate.AddDays(1);
            }

            return dateInfo;
        }
    }
}
