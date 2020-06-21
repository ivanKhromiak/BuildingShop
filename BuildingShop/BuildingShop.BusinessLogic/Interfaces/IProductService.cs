using BuildingShop.Domain.DomainObjects;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BuildingShop.BusinessLogic.Interfaces
{
    public interface IProductService
    {
        Task AddProduct(Product product);
        Task DeleteProduct(int id);
        Task EditProduct(Product product);
        List<Product> GetAllProducts();
        Task<Product> GetProduct(int id);
        Task<List<Category>> GetProductsCategories();
    }
}
