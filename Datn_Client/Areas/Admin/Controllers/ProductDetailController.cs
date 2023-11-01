using Datn_Shared.Models;
using Datn_Shared.ViewModels.ProductDetailViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Datn_Client.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductDetailController : Controller
    {
        private readonly HttpClient _httpClient;

        public ProductDetailController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        [HttpGet]
        public async Task<IActionResult> Index(Guid id)
        {
            var tip = await _httpClient.GetFromJsonAsync<List<Tip>>("https://localhost:7033/api/Tip/GetAll");
            ViewData["t"] = tip;
            var shaft = await _httpClient.GetFromJsonAsync<List<Shaft>>("https://localhost:7033/api/Shaft/GetAll");
            ViewData["s"] = shaft;
            var weight = await _httpClient.GetFromJsonAsync<List<Weight>>("https://localhost:7033/api/Weight/GetAll");
            ViewData["w"] = weight;
            var product = await _httpClient.GetFromJsonAsync<List<Product>>("https://localhost:7033/api/Product/GetAll");
            ViewData["p"] = product;
            if (id == Guid.Empty)
            {
                var categories = await _httpClient.GetFromJsonAsync<IEnumerable<ViewProductDetail>>("https://localhost:7033/api/ProductDetail/GetAll");
                return View(categories);
            }
            else
            {
                var categories = await _httpClient.GetFromJsonAsync<IEnumerable<ViewProductDetail>>("https://localhost:7033/api/ProductDetail/GetAll");
                var category = await _httpClient.GetFromJsonAsync<ViewProductDetail>($"https://localhost:7033/api/ProductDetail/GetById/{id}");
                List<ViewProductDetail> c = new List<ViewProductDetail>();
               
                c.Add(category);
                ViewData["pdt"] = c;
                return View(categories);
            }
        }
        public async Task<IActionResult> Create( CreateProductDetail create)
        {
            await _httpClient.PostAsJsonAsync($"https://localhost:7033/api/ProductDetail/Create", create);
            return RedirectToAction("Index", "ProductDetail");
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            await _httpClient.DeleteAsync($"https://localhost:7033/api/ProductDetail/Delete/{id}");
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Update(Guid id)
        {
            var t = await _httpClient.GetFromJsonAsync<ProductDetail>($"https://localhost:7033/api/ProductDetail/GetById/{id}");
            return View(t);
        }

        public async Task<IActionResult> Update(Guid id, UpdateProductDetail updateProductDetail)
        {
            await _httpClient.PutAsJsonAsync($"https://localhost:7033/api/ProductDetail/Update/{id}", updateProductDetail);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Increase(Guid id)
        {
            await _httpClient.PutAsJsonAsync<ProductDetail>($"https://localhost:7033/api/ProductDetail/Increase/{id}", null);
            return RedirectToAction("Index", new { id = id });
        }

        public async Task<IActionResult> Reduce(Guid id)
        {
            await _httpClient.PutAsJsonAsync<ProductDetail>($"https://localhost:7033/api/ProductDetail/Reduce/{id}", null);
            return RedirectToAction("Index", new { id = id });
        }
        public async Task<IActionResult> Detail(Guid id)
        {
            return RedirectToAction("Index", new { id = id });
        }
    }
}
