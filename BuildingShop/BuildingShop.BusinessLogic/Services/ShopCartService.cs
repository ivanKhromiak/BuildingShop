using BuildingShop.BusinessLogic.Interfaces;
using BuildingShop.Domain.DomainObjects;
using BuildingShop.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public async Task AddToCart(Product product, int amount, string sessionId)
        {
            _context.ShopCartItems.Add(new ShopCartItem() { Product = product, Amount = amount, ShopCartId = sessionId });
            await _context.SaveChangesAsync();
        }

        public async Task<List<ShopCartItem>> GetShopCartItems(string sessionId)
        {
            return await _context.ShopCartItems.Where(i => i.ShopCartId == sessionId).ToListAsync();
        }
    }
}
