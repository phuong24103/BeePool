using Datn_Shared.Models;
using Datn_Shared.ViewModels.CartDetailViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Datn_Client.Controllers
{
    public class CartController : Controller
    {
        HttpClient _httpClient;
        public CartController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var result = await _httpClient.GetFromJsonAsync<List<CartDetailView>>("https://localhost:7033/api/CartDetail");
            return View(result);
        }

        public IActionResult Cart()
        {
            return View();
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] CreateCartDetail cartDetail)
        {
            await _httpClient.PostAsJsonAsync($"https://localhost:7033/api/CartDetail", cartDetail);
            return RedirectToAction("Index", "CartDetails");
        }

        [Route("[action]/{id:Guid}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _httpClient.DeleteAsync($"https://localhost:7033/api/CartDetail/{id}");
            return RedirectToAction("Index");
        }

        [Route("[action]/{id:Guid}")]
        public async Task<IActionResult> Increase(Guid id)
        {
            await _httpClient.PutAsJsonAsync<CartDetailView>($"https://localhost:7033/api/CartDetail/Increase/{id}", null);
            return RedirectToAction("Index");
        }

        [Route("[action]/{id:Guid}")]
        public async Task<IActionResult> Reduce(Guid id)
        {
            await _httpClient.PutAsJsonAsync<CartDetailView>($"https://localhost:7033/api/CartDetail/Reduce/{id}", null);
            return RedirectToAction("Index");
        }
    }
}