using Datn_Shared.Models;
using Datn_Shared.ViewModels.CartDetailViewModels;
using Datn_Shared.ViewModels.CustomerViewModels;
using Microsoft.AspNetCore.Mvc;
using Shopping_Website.Services;
using System.Net.Http;
using System.Security.Claims;

namespace Datn_Client.Controllers
{
    public class CustomerController : Controller
    {
        private readonly HttpClient _httpClient;

        public CustomerController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var userName = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var role = User.FindFirstValue(ClaimTypes.Role);
            if (userName != null && role == null)
            {
                var customer = await _httpClient.GetFromJsonAsync<CustomerView>($"https://localhost:7033/api/Customer/GetByNameWithViewModel/{userName}");
                return View(customer);
            }
            return RedirectToAction("Error", "Home");
        }

        public async Task<IActionResult> UpdateImage(IFormFile imageFile)
        {
            var userName = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var role = User.FindFirstValue(ClaimTypes.Role);
            if (userName != null && role == null)
            {
                if (imageFile != null && imageFile.Length > 0)//Kiểm tra đường dẫn phù hợp
                {
                    string image = Guid.NewGuid().ToString() + "_" + imageFile.FileName;
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "customers", image);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await imageFile.CopyToAsync(stream);
                    }

                    await _httpClient.PutAsJsonAsync<Customer>($"https://localhost:7033/api/Customer/UpdateImage/{userName}/{image}", null);
                }
            }
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> EditProfile()
        {
            return View();
        }
    }
}