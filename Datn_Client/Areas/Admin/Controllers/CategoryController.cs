using Datn_Shared.Models;
using Datn_Shared.ViewModels.CategoryViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Datn_Client.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly HttpClient _httpClient;
        public CategoryController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IActionResult> Index(Guid id)
        {
            if(id == Guid.Empty)
            {
                var categories = await _httpClient.GetFromJsonAsync<IEnumerable<Category>>("https://localhost:7033/api/Category/GetAll");
                return View(categories);
            }
            else
            {
                var categories = await _httpClient.GetFromJsonAsync<IEnumerable<Category>>("https://localhost:7033/api/Category/GetAll");
                var category = await _httpClient.GetFromJsonAsync<Category>($"https://localhost:7033/api/Category/GetById/{id}");
                List<Category> c = new List<Category>();
                c.Add(category);
                ViewData["Category"] = c;
                return View(categories);
            }
        }
        public async Task<IActionResult> Detail(Guid id)
        {
            return RedirectToAction("Index", new { id = id });
        }
        public async Task<IActionResult> Create(CreateCategory category)
        {
            await _httpClient.PostAsJsonAsync($"https://localhost:7033/api/Category/Create", category);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Update(Guid id, UpdateCategory category)
        {
            await _httpClient.PutAsJsonAsync($"https://localhost:7033/api/Category/Update/{id}", category);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Delete(Guid id)
        {
            await _httpClient.DeleteAsync($"https://localhost:7033/api/Category/Delete/{id}");
            return RedirectToAction("Index");
        }
    }
}