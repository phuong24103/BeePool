using Datn_Shared.Models;
using Datn_Shared.ViewModels.ShaftViewModels;
using Datn_Shared.ViewModels.TipViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Datn_Client.Controllers
{
    public class ShaftController : Controller
    {
        private readonly HttpClient _httpClient;
        public ShaftController(HttpClient httpClient)
        {
                _httpClient = httpClient;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _httpClient.GetFromJsonAsync<List<Shaft>>("https://localhost:7033/api/Shaft/GetAll"));
        }
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromForm] CreateShaft createShaft)
        {
            await _httpClient.PostAsJsonAsync($"https://localhost:7033/api/Shaft/Create", createShaft);
            return RedirectToAction("Index", "Tip");
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            await _httpClient.DeleteAsync($"https://localhost:7033/api/Shaft/Delete/{id}");
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Update(Guid id)
        {
            var t = await _httpClient.GetFromJsonAsync<Tip>($"https://localhost:7033/api/Shaft/GetById/{id}");
            return View(t);
        }

        public async Task<IActionResult> Update(Guid id, UpdateShaft  updateShaft)
        {
            await _httpClient.PutAsJsonAsync($"https://localhost:7033/api/Shaft/Update/{id}", updateShaft);
            return RedirectToAction("Index");
        }
    }
}
