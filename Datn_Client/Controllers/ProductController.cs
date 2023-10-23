using Datn_Api.Data;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.ProductDetailViewModels;
using Datn_Shared.ViewModels.ProductViewModels;
using Datn_Shared.ViewModels.TipViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Datn_Client.Controllers
{
    public class ProductController : Controller
    {
        private readonly HttpClient _httpClient;

        public ProductController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _httpClient.GetFromJsonAsync<List<ProductView>>("https://localhost:7033/api/Product/GetAll"));
        }

        [HttpGet]
        public async Task<IActionResult> Search(string Name)
        {
            return View("Index", await _httpClient.GetFromJsonAsync<List<ProductView>>($"https://localhost:7033/api/Product/GetByName/{Name}"));
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] CreateProduct createProduct)
        {
            await _httpClient.PostAsJsonAsync($"https://localhost:7033/api/Product/Create", createProduct);
            return RedirectToAction("Index", "Product");
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            await _httpClient.DeleteAsync($"https://localhost:7033/api/Product/Delete/{id}");
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Update(Guid id)
        {
            var t = await _httpClient.GetFromJsonAsync<Product>($"https://localhost:7033/api/Product/GetById/{id}");
            return View(t);
        }

        public async Task<IActionResult> Update(Guid id, UpdateProduct updateProduct)
        {
            await _httpClient.PutAsJsonAsync($"https://localhost:7033/api/Product/Update/{id}", updateProduct);
            return RedirectToAction("Index");
        }
    }
}