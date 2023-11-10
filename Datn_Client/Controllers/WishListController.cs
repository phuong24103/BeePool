using Datn_Shared.Models;
using Datn_Shared.ViewModels.WishListViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;
using System.Security.Claims;
using X.PagedList;

namespace Datn_Client.Controllers
{
    public class WishListController : Controller
    {
        private readonly HttpClient _httpClient;

        public WishListController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IActionResult> Index(int page = 1, int pageSize = 6)
        {
            var userName = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var customer = await _httpClient.GetFromJsonAsync<Customer>($"https://localhost:7033/api/Customer/GetByName/{userName}");
            var wishList = await _httpClient.GetFromJsonAsync<List<WishListView>>($"https://localhost:7033/api/WishList/GetByCustomerId/{customer.Id}");
            var pagedList = new PagedList<WishListView>(wishList, page, pageSize);
            return View("Index", pagedList);
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