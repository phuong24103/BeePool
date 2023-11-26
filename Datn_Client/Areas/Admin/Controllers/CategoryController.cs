using Datn_Shared.Models;
using Datn_Shared.ViewModels.CategoryViewModels;
using Humanizer;
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

        public async Task<IActionResult> Index(Guid id, string date)
        {
            if (id == Guid.Empty)
            {
                if (date == "today")
                {
                    var categories = await _httpClient.GetFromJsonAsync<IEnumerable<Category>>("https://localhost:7033/api/Category/GetAll");
                    IEnumerable<Category> c = categories.Where(p => (p.CreatedDate.DayOfYear == DateTime.Now.DayOfYear) || (p.UpdatedDate.DayOfYear == DateTime.Now.DayOfYear));
                    ViewBag.DateCategory = date;
                    return View(c);
                }
                else if (date == "thisMonth")
                {
                    var categories = await _httpClient.GetFromJsonAsync<IEnumerable<Category>>("https://localhost:7033/api/Category/GetAll");
                    IEnumerable<Category> c = categories.Where(p => (p.CreatedDate.Month == DateTime.Now.Month && p.CreatedDate.Year == DateTime.Now.Year) || (p.UpdatedDate.Month == DateTime.Now.Month && p.UpdatedDate.Year == DateTime.Now.Year));
                    ViewBag.DateCategory = date;
                    return View(c);
                }
                else if (date == "thisYear")
                {
                    var categories = await _httpClient.GetFromJsonAsync<IEnumerable<Category>>("https://localhost:7033/api/Category/GetAll");
                    IEnumerable<Category> c = categories.Where(p => (p.CreatedDate.Year == DateTime.Now.Year) || (p.UpdatedDate.Year == DateTime.Now.Year));
                    ViewBag.DateCategory = date;
                    return View(c);
                }
                else
                {
                    var categories = await _httpClient.GetFromJsonAsync<IEnumerable<Category>>("https://localhost:7033/api/Category/GetAll");
                    return View(categories);
                }
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
        public async Task<IActionResult> Filter(string date)
        {
            return RedirectToAction("Index", new { date = date });
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