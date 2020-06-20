﻿using BuildingShop.BusinessLogic.Interfaces;
using BuildingShop.Domain.DomainObjects;
using BuildingShop.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildingShop.BusinessLogic.Services
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext _context;

        public ProductService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Product> GetAllProducts()
        {
            return _context.Products.Include(p => p.Category).ToList();
        }

        public async Task<List<Category>> GetProductsCategories()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task<Product> GetProduct(int id)
        {
            return await _context.Products.Include(p => p.Category).Where(p => p.Id == id).FirstOrDefaultAsync();
        }

        public async Task AddProduct(Product product)
        {
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
            await _context.ProductAmountTrackers.AddAsync(new ProductAmountTracker()
            {
                ProductId = product.Id,
                Amount = product.Amount,
                Date = DateTime.Now
            });
            await _context.SaveChangesAsync();
        }
    }
}
