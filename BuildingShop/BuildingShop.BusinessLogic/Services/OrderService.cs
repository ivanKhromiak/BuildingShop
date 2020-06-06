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
                .Where(d => d.Date <= order.EndDate && d.Date >= order.StarDate && d.ProductId == order.ProductId)
                .ToListAsync();
            var Purchases = await _context.Purchases
                .Where(d => d.Date <= order.EndDate && d.Date >= order.StarDate && d.ProductId == order.ProductId)
                .ToListAsync();

            order.TotalIncome = Deliveries.Sum(d => d.Amount);
            order.TotalOutcome = Purchases.Sum(d => d.Amount);

            order.StartingAmount = (await _context.ProductAmountTrackers
                .Where(a => order.StarDate > a.Date)
                .OrderBy(a => a.Date)
                .ToListAsync())
                .LastOrDefault()
                .Amount;
            order.EndAmount = order.StartingAmount + order.TotalIncome - order.TotalOutcome;

            var currentDate = order.StarDate;
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

            order.AverageSalesPerDay = (decimal)(order.TotalOutcome / (order.EndDate.Subtract(order.StarDate).TotalDays + 1));

            order.FinalNumber = (int)(order.AverageSalesPerDay * (decimal)(order.EndDate - order.StarDate).TotalDays);

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
                .Where(d => d.Date <= order.EndDate && d.Date >= order.StarDate && d.ProductId == order.ProductId)
                .ToListAsync();
            var deliveries = await _context.Deliveries
                .Where(d => d.Date <= order.EndDate && d.Date >= order.StarDate && d.ProductId == order.ProductId)
                .ToListAsync();

            var currentDate = order.StarDate;
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
