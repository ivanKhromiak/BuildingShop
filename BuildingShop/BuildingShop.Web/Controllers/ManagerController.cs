using Microsoft.AspNetCore.Mvc;

namespace BuildingShop.Web.Controllers
{
    public class ManagerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}