using Datn_Shared.Models;
using Datn_Shared.ViewModels.TipViewModels;
using Datn_Shared.ViewModels.WeightViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Datn_Client.Controllers
{
    public class WeightController : Controller
    {
        private readonly HttpClient _httpClient;
        public WeightController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
       
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _httpClient.GetFromJsonAsync<List<Weight>>("https://localhost:7033/api/Weight/GetAll"));
        }
        public async Task<IActionResult> Create()
        {
            return View();
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
        [HttpGet]
        public async Task<IActionResult> Update(Guid id)
        {
            var t = await _httpClient.GetFromJsonAsync<Weight>($"https://localhost:7033/api/Weight/GetById/{id}");
            return View(t);
        }

        public async Task<IActionResult> Update(Guid id, UpdateWeight updateWeight)
        {
            await _httpClient.PutAsJsonAsync($"https://localhost:7033/api/Weight/Update/{id}", updateWeight);
            return RedirectToAction("Index");
        }
    }
}
