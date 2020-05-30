using BuildingShop.BusinessLogic.Interfaces;
using BuildingShop.Domain.DomainObjects;
using BuildingShop.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildingShop.BusinessLogic.Services
{
    public class ShopCartService : IShopCartService
    {
        private readonly ApplicationDbContext _context;

        public ShopCartService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddToCart(int productId, int amount, string sessionId)
        {
            _context.ShopCartItems.Add(new ShopCartItem() { ProductId = productId, Amount = amount, ShopCartId = sessionId });
            await _context.SaveChangesAsync();
        }

        public async Task Buy(string sessionId)
        {
            var products = await _context.ShopCartItems
                .Where(i => i.ShopCartId == sessionId)
                .GroupBy(p => p.Product)
                .ToListAsync();

            foreach (var product in products)
            {
                int totalAmount = product.Sum(p => p.Amount);
                var item = _context.Products.Find(product.Key);
                if(item.Amount < totalAmount)
                {
                    throw new ArgumentException("No such amount of product for purchase");
                }
                item.Amount -= totalAmount;
                _context.SaveChanges();

                var amountChange = new ProductAmountTracker()
                {
                    Amount = _context.Products.Find(product.Key).Amount,
                    Date = DateTime.Now
                };
                _context.Add(amountChange);
                _context.SaveChanges();

                var purchase = new Purchase() { Product = product.Key, Amount = totalAmount, Date = DateTime.Now };
                _context.Add(purchase);
                _context.SaveChanges();
            }

            _context.ShopCartItems.RemoveRange(_context.ShopCartItems.Where(s => s.ShopCartId == sessionId));
            _context.SaveChanges();
        }

        public async Task<List<ShopCartItem>> GetShopCartItems(string sessionId)
        {
            return await _context.ShopCartItems.Where(i => i.ShopCartId == sessionId).ToListAsync();
        }
    }
}
