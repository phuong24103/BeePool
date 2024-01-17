using Datn_Shared.ViewModels.AccountViewModels;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Datn_Client.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RegisterController : Controller
    {
        private readonly HttpClient _httpClient;

        public RegisterController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        [HttpGet]
        public IActionResult Register(string message)
        {
            var userName = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var role = User.FindFirstValue(ClaimTypes.Role);
            if (userName != null && role != null)
            {
                ViewBag.Message = message;
                return View();
            }
            return RedirectToAction("Login", "Login", new { areas = "Admin" });
        }

        [HttpPost]
        public async Task<IActionResult> Register(Register registerEmployee, string role)
        {
            // Add role to queryString
            role = "Nhân viên";
            var queryString = $"?role={role}";
            // Send request POST to register API
            var response = await _httpClient.PostAsJsonAsync($"https://localhost:7033/api/RegisterEmployee{queryString}", registerEmployee);
            if (!response.IsSuccessStatusCode)
            {
                var message = await response.Content.ReadAsStringAsync();
                return RedirectToAction("Register", new { message });
            }
            return RedirectToAction("Index", "Home", new { area = "Admin" });
        }
    }
}
