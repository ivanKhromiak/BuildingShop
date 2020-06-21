using BuildingShop.BusinessLogic.Interfaces;
using BuildingShop.Domain.DomainObjects;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Threading.Tasks;

namespace BuildingShop.Web.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _productService.GetAllProducts();
            return View(applicationDbContext);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _productService.GetProduct(id.Value);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        public async Task<IActionResult> Create(int сharacteristicsAmount = 1)
        {
            ViewData["CategoryId"] = new SelectList(await _productService.GetProductsCategories(), "Id", "Name");
            ViewData["СharacteristicsAmount"] = сharacteristicsAmount;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Image,Price,Amount,CategoryId,Сharacteristics")] Product product)
        {
            if (ModelState.IsValid)
            {
                await _productService.AddProduct(product);
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(await _productService.GetProductsCategories(), "Id", 
                "Name", product.CategoryId);
            return View(product);
        }

        public async Task<IActionResult> Edit(int? id, int сharacteristicsAmount = 0)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _productService.GetProduct(id.Value);
            if (product == null)
            {
                return NotFound();
            }
            ViewData["СharacteristicsAmount"] = сharacteristicsAmount;
            ViewData["CategoryId"] = new SelectList(await _productService.GetProductsCategories(), "Id",
                "Name", product.CategoryId);
            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Name,Image,Price,Amount,CategoryId,Сharacteristics")] Product product)
        {
            if (id != product.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await _productService.EditProduct(product);
                return RedirectToAction(nameof(Index));
            }

            ViewData["CategoryId"] = new SelectList(await _productService.GetProductsCategories(), "Id",
                "Name", product.CategoryId);
            return View(product);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _productService.GetProduct(id.Value);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _productService.DeleteProduct(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
