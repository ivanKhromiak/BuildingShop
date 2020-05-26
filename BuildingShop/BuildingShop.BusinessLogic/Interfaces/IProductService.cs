using BuildingShop.Domain.DomainObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingShop.BusinessLogic.Interfaces
{
    public interface IProductService
    {
        List<Product> GetAllProducts();
        Product GetProduct(int id);
    }
}
