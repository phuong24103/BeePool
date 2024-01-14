using Datn_Shared.Models;
using Datn_Shared.ViewModels.ShaftViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Datn_Client.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ShaftController : Controller
    {
        private readonly HttpClient _httpClient;
        public ShaftController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        [HttpGet]
        public async Task<IActionResult> Index(Guid id)
        {
            if (id == Guid.Empty)
            {
                var categories = await _httpClient.GetFromJsonAsync<IEnumerable<Shaft>>("https://localhost:7033/api/Shaft/GetAll");
                return View(categories);
            }
            else
            {
                var categories = await _httpClient.GetFromJsonAsync<IEnumerable<Shaft>>("https://localhost:7033/api/Shaft/GetAll");
                var category = await _httpClient.GetFromJsonAsync<Shaft>($"https://localhost:7033/api/Shaft/GetById/{id}");
                List<Shaft> c = new List<Shaft>();
                c.Add(category);
                ViewData["s"] = c;
                return View(categories);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] CreateShaft createShaft)
        {
            await _httpClient.PostAsJsonAsync($"https://localhost:7033/api/Shaft/Create", createShaft);
            return RedirectToAction("Index", "Shaft");
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            await _httpClient.DeleteAsync($"https://localhost:7033/api/Shaft/Delete/{id}");
            return RedirectToAction("Index");
        }
    
    

    public async Task<IActionResult> Update(Guid id, UpdateShaft updateShaft)
    {
        await _httpClient.PutAsJsonAsync($"https://localhost:7033/api/Shaft/Update/{id}", updateShaft);
        return RedirectToAction("Index");
    }
    public async Task<IActionResult> Detail(Guid id)
    {
        return RedirectToAction("Index",new {id = id});
    }

}
}
