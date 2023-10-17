using Datn_Shared.Models;
using Datn_Shared.ViewModels.CartDetailViewModels;
using Datn_Shared.ViewModels.ProductDetailViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Json;
using System.Security.Claims;

namespace Datn_Client.Controllers
{
    public class CartController : Controller
    {
        HttpClient _httpClient;
        public CartController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IActionResult> Index()
        {
            var userName = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var customer = await _httpClient.GetFromJsonAsync<Customer>($"https://localhost:7033/api/Customer/GetByName/{userName}");
            var result = await _httpClient.GetFromJsonAsync<List<CartDetailView>>($"https://localhost:7033/api/CartDetail/GetByCustomerId/{customer.Id}");
            return View(result);
        }

        /*[HttpPost]
        [Route("[action]")]*/
        public async Task<IActionResult> Create(Guid id)
        {
            var userName = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userName != null)
            {
                var customer = await _httpClient.GetFromJsonAsync<Customer>($"https://localhost:7033/api/Customer/GetByName/{userName}");
                var productDetail = await _httpClient.GetFromJsonAsync<ProductDetail>($"https://localhost:7033/api/ProductDetail/GetById/{id}");
                CreateCartDetail cartDetail = new CreateCartDetail()
                {
                    CustomerId = customer.Id,
                    ProductDetailId = productDetail.Id,
                    Quantity = 1,
                };
                await _httpClient.PostAsJsonAsync($"https://localhost:7033/api/CartDetail/Create", cartDetail);
                return RedirectToAction("Index", "Cart");
            }
            return RedirectToAction("Login", "Login");
        }

        [Route("[action]/{id:Guid}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _httpClient.DeleteAsync($"https://localhost:7033/api/CartDetail/Delete/{id}");
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