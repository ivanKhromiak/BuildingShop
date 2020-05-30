using BuildingShop.Domain.DomainObjects;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BuildingShop.BusinessLogic.Interfaces
{
    public interface IShopCartService
    {
        Task AddToCart(int productId, int amount, string sessionId);
        Task<List<ShopCartItem>> GetShopCartItems(string sessionId);
        Task Buy(string sessionId);
    }
}