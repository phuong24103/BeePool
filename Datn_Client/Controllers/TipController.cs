using Datn_Shared.Models;
using Datn_Shared.ViewModels.CartDetailViewModels;
using Datn_Shared.ViewModels.TipViewModels;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;

namespace Datn_Client.Controllers
{
    public class TipController : Controller
    {
        private readonly HttpClient _httpClient;
        public TipController(HttpClient httpClient)
        {
            _httpClient = httpClient;
                
        }
        [HttpGet]
        public async Task < IActionResult> Index()
        {
           return View(await _httpClient.GetFromJsonAsync<List<Tip>>("https://localhost:7033/api/Tip/GetAll"));
        }
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromForm] CreateTip createTip)
        {
            await _httpClient.PostAsJsonAsync($"https://localhost:7033/api/Tip/Create",createTip);
            return RedirectToAction("Index","Tip");
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            await _httpClient.DeleteAsync($"https://localhost:7033/api/Tip/Delete/{id}");
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Update(Guid id)
        {
            var t = await _httpClient.GetFromJsonAsync<Tip>($"https://localhost:7033/api/Tip/GetById/{id}");
            return View(t);
        }

        public async Task<IActionResult> Update(Guid id,UpdateTip updateTip)
        {
            await _httpClient.PutAsJsonAsync($"https://localhost:7033/api/Tip/Update/{id}", updateTip);
            return RedirectToAction("Index");
        }

      
    }
}
