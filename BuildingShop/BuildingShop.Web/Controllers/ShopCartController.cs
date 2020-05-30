using System;
using System.Threading.Tasks;
using BuildingShop.BusinessLogic.Interfaces;
using BuildingShop.Domain.DomainObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BuildingShop.Web.Controllers
{
    public class ShopCartController : Controller
    {
        private readonly IShopCartService _shopCartService;

        public ShopCartController(IShopCartService shopCartService)
        {
            _shopCartService = shopCartService;
        }

        public async Task<IActionResult> Index()
        {
            string CartId = GetCartId();
            var items = await _shopCartService.GetShopCartItems(CartId);
            return View(items);
        }

        public IActionResult AddToCart(ShopCartItem item)
        {
            item.ShopCartId = GetCartId();
            _shopCartService.AddToCart(item);
            return RedirectToAction("Details", "Home", item.ProductId);
        }

        public IActionResult Buy()
        {
            string CartId = GetCartId();
            _shopCartService.Buy(CartId);
            return RedirectToAction("Index");
        }

        private string GetCartId()
        {
            string CartId = HttpContext.Session.GetString("CartId");
            if (string.IsNullOrEmpty(CartId))
            {
                HttpContext.Session.SetString("CartId", Guid.NewGuid().ToString());
                CartId = HttpContext.Session.GetString("CartId");
            }
            return CartId;
        }
    }
}