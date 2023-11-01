using Datn_Shared.Models;
using Datn_Shared.ViewModels.ProductViewModels;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace Datn_Client.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly HttpClient _httpClient;

        public ProductController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        [HttpGet]
        public async Task<IActionResult> Index(Guid id)
        {
            var cate = await _httpClient.GetFromJsonAsync<List<Category>>("https://localhost:7033/api/Category/GetAll");
            ViewData["a"] = cate;
            if (id == Guid.Empty)
            {
                var categories = await _httpClient.GetFromJsonAsync<IEnumerable<ProductView>>("https://localhost:7033/api/Product/GetAll");
                return View(categories);
            }
            else
            {
                var categories = await _httpClient.GetFromJsonAsync<IEnumerable<ProductView>>("https://localhost:7033/api/Product/GetAll");
                var category = await _httpClient.GetFromJsonAsync<ProductView>($"https://localhost:7033/api/Product/GetById/{id}");
                List<ProductView> c = new List<ProductView>();

                c.Add(category);
                ViewData["p"] = c;
                return View(categories);
            }
        }

        public async Task<IActionResult> Detail(Guid id)
        {
            return RedirectToAction("Index",new {id = id});
        }

        [HttpGet]
        public async Task<IActionResult> Search(string Name)
        {
            return View("Index", await _httpClient.GetFromJsonAsync<List<ProductView>>($"https://localhost:7033/api/Product/GetByName/{Name}"));
        }
        [HttpPost]
        public async Task<IActionResult> Create( CreateProduct createProduct)
        {
            await _httpClient.PostAsJsonAsync($"https://localhost:7033/api/Product/Create", createProduct);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            await _httpClient.DeleteAsync($"https://localhost:7033/api/Product/Delete/{id}");
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(Guid id, UpdateProduct updateProduct)
        {
            await _httpClient.PutAsJsonAsync($"https://localhost:7033/api/Product/Update/{id}", updateProduct);
            return RedirectToAction("Index");
        }
    }
}
