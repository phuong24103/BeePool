using Datn_Shared.Models;
using Datn_Shared.ViewModels.WeightViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Datn_Client.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class WeightController : Controller
    {
        private readonly HttpClient _httpClient;
        public WeightController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        [HttpGet]
        public async Task<IActionResult> Index(Guid id)
        {
            var userName = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var role = User.FindFirstValue(ClaimTypes.Role);
            if (userName != null && role != null)
            {
                if (id == Guid.Empty)
                {
                    var categories = await _httpClient.GetFromJsonAsync<IEnumerable<Weight>>("https://localhost:7033/api/Weight/GetAll");
                    return View(categories);
                }
                else
                {
                    var categories = await _httpClient.GetFromJsonAsync<IEnumerable<Weight>>("https://localhost:7033/api/Weight/GetAll");
                    var category = await _httpClient.GetFromJsonAsync<Weight>($"https://localhost:7033/api/Weight/GetById/{id}");
                    List<Weight> c = new List<Weight>();
                    c.Add(category);
                    ViewData["w"] = c;
                    return View(categories);
                }
            }
            return RedirectToAction("Login", "Login", new { areas = "Admin" });
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] CreateWeight createWeight)
        {
            await _httpClient.PostAsJsonAsync($"https://localhost:7033/api/Weight/Create", createWeight);
            return RedirectToAction("Index", "Weight");
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            await _httpClient.DeleteAsync($"https://localhost:7033/api/Weight/Delete/{id}");
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Update(Guid id, UpdateWeight updateWeight)
        {
            await _httpClient.PutAsJsonAsync($"https://localhost:7033/api/Weight/Update/{id}", updateWeight);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Detail(Guid id)
        {
            return RedirectToAction("Index", new { id = id });
        }
    }
}
