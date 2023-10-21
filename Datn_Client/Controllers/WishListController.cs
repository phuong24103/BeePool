using Datn_Shared.Models;
using Datn_Shared.ViewModels.WishListViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;
using System.Security.Claims;

namespace Datn_Client.Controllers
{
    public class WishListController : Controller
    {
        private readonly HttpClient _httpClient;

        public WishListController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IActionResult> Index()
        {
            var userName = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var customer = await _httpClient.GetFromJsonAsync<Customer>($"https://localhost:7033/api/Customer/GetByName/{userName}");
            var wishList = await _httpClient.GetFromJsonAsync<List<WishListView>>($"https://localhost:7033/api/WishList/GetByCustomerId/{customer.Id}");
            return View(wishList);
        }

        public async Task<IActionResult> Like(Guid id)
        {
            var userName = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var customer = await _httpClient.GetFromJsonAsync<Customer>($"https://localhost:7033/api/Customer/GetByName/{userName}");
            var request = new HttpRequestMessage(HttpMethod.Options, $"https://localhost:7033/api/WishList/Like/{customer.Id}/{id}");
            await _httpClient.SendAsync(request);
            return RedirectToAction("Index");
        }
    }
}
