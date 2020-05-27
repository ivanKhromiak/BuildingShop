using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuildingShop.BusinessLogic.Interfaces;
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

        public IActionResult Index()
        {
            string CartId = HttpContext.Session.GetString("CartId");
            if (string.IsNullOrEmpty(CartId))
            {
                HttpContext.Session.SetString("CartId", Guid.NewGuid().ToString());
                CartId = HttpContext.Session.GetString("CartId");
            }
            var items = _shopCartService.GetShopCartItems(CartId);
            return View(items);
        }

        public IActionResult Buy(string CartId)
        {
            //shopCartService.Buy(CartId);
            return RedirectToAction("Index");
        }
    }
}