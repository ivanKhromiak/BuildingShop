using BuildingShop.BusinessLogic.Interfaces;
using BuildingShop.Domain.DomainObjects;
using BuildingShop.Persistence;
using BuildingShop.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using System.Threading.Tasks;

namespace BuildingShop.Web.Controllers
{
    public class OrderController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService, ApplicationDbContext context)
        {
            _orderService = orderService;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _orderService.GetAllOrders());
        }

        // GET: Orders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            var order = await _orderService.GetOrder(id.Value);
            if (order == null)
            {
                return NotFound();
            }

            var orderViewModel = new OrderViewModel()
            {
                Order = order,
                DateInfo = await _orderService.GetDateInfo(order)
            };

            return View(orderViewModel);
        }

        public IActionResult Create()
        {
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Name");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("ProductId,StartDate,EndDate")] Order order)
        {
            if (ModelState.IsValid)
            {
                await _orderService.CreateOrder(order);
                return RedirectToAction(nameof(Index));
            }

            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Id", order.ProductId);
            return View(order);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _orderService.GetOrder(id.Value);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("ProductId,StarDate,EndDate,StartingAmount,EndAmount,TotalIncome,TotalOutcome,MaxDaysWithoutProduct,AverageSalesPerDay,MinSalePerDay,FinalNumber,Id")] Order order)
        {
            if (id != order.Id)
            {
                return NotFound();
            }

            await _orderService.EditOrder(order);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _orderService.GetOrder(id.Value);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _orderService.DeleteOrder(id);
            return RedirectToAction(nameof(Index));
        }

        private bool OrderExists(int id)
        {
            return _context.Orders.Any(e => e.Id == id);
        }
    }
}
