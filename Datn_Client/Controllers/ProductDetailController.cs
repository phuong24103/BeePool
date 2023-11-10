using Datn_Shared.Models;
using Datn_Shared.ViewModels.ProductDetailViewModels;
using Datn_Shared.ViewModels.WeightViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Datn_Client.Controllers
{
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
            var t = await _httpClient.GetFromJsonAsync<ViewProductDetail>($"https://localhost:7033/api/ProductDetail/GetById/{id}");
            var tip = await _httpClient.GetFromJsonAsync<List<Tip>>($"https://localhost:7033/api/Tip/GetByProductDetailId/{id}");
            var w = await _httpClient.GetFromJsonAsync<List<Weight>>($"https://localhost:7033/api/Weight/GetByProductDetailId/{id}");
            var s = await _httpClient.GetFromJsonAsync<List<Shaft>>($"https://localhost:7033/api/Shaft/GetByProductDetailId/{id}");
            var image = await _httpClient.GetFromJsonAsync<List<ProductImage>>($"https://localhost:7033/api/ProductImage/GetByProductDetailId/{id}");

            ViewData["Tip"] = tip;
            ViewData["Weight"] = w;
            ViewData["Shaft"] = s;
            ViewData["Image"] = image;

            var userName = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var role = User.FindFirstValue(ClaimTypes.Role);
            if (userName != null && role == null)
            {
                var customer = await _httpClient.GetFromJsonAsync<Customer>($"https://localhost:7033/api/Customer/GetByName/{userName}");
                var isProductLiked = await _httpClient.GetFromJsonAsync<bool>($"https://localhost:7033/api/WishList/CheckExistLike/{customer.Id}/{t.ProductID}");
                ViewData["CheckExistLike"] = isProductLiked.ToString();
            }
            else
            {
                ViewData["CheckExistLike"] = null;
            }
            return View(t);
        }
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromForm] CreateProductDetail create)
        {
            await _httpClient.PostAsJsonAsync($"https://localhost:7033/api/Weight/Create", create);
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
    }
}