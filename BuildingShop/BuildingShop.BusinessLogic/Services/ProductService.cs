﻿using BuildingShop.BusinessLogic.Interfaces;
using BuildingShop.Domain.DomainObjects;
using BuildingShop.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
            return _context.Products.ToList();
        }
    }
}
