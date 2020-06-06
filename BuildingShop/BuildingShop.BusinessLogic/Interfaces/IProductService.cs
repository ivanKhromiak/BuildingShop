using BuildingShop.Domain.DomainObjects;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BuildingShop.BusinessLogic.Interfaces
{
    public interface IProductService
    {
        List<Product> GetAllProducts();
        Task<Product> GetProduct(int id);
    }
}
