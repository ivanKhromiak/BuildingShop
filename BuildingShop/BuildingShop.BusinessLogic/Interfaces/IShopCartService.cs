using BuildingShop.Domain.DomainObjects;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BuildingShop.BusinessLogic.Interfaces
{
    public interface IShopCartService
    {
        Task AddToCart(ShopCartItem item);
        Task<List<ShopCartItem>> GetShopCartItems(string sessionId);
        Task Buy(string sessionId);
    }
}