using Datn_Shared.Models;
using Datn_Shared.ViewModels.EmployeeViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Datn_Client.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EmployeeController : Controller
    {
        private readonly HttpClient _httpClient;

        public EmployeeController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IActionResult> Index(string message)
        {
            var userName = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var role = User.FindFirstValue(ClaimTypes.Role);
            if (userName != null && role != null)
            {
                ViewBag.Message = message;
                var employee = await _httpClient.GetFromJsonAsync<EmployeeView>($"https://localhost:7033/api/Employee/GetByName/{userName}");
                ViewData["Role"] = role;
                return View(employee);
            }
            return RedirectToAction("Error", "Home");
        }

        public async Task<IActionResult> UpdatePassword(UpdatePasswordEmployee updatePasswordEmployee)
        {
            var userName = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var role = User.FindFirstValue(ClaimTypes.Role);
            if (userName != null && role != null)
            {
                var response = await _httpClient.PutAsJsonAsync($"https://localhost:7033/api/Employee/UpdatePassword/{userName}", updatePasswordEmployee);
                var message = await response.Content.ReadAsStringAsync();
                return RedirectToAction("Index", new { message });
            }
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> UpdateProfile(UpdateProfileEmployee updateProfileEmployee)
        {
            var userName = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var role = User.FindFirstValue(ClaimTypes.Role);
            if (userName != null && role != null)
            {
                await _httpClient.PutAsJsonAsync($"https://localhost:7033/api/Employee/UpdateProfile/{userName}", updateProfileEmployee);
            }
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> UpdateImage(IFormFile imageFile)
        {
            var userName = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var role = User.FindFirstValue(ClaimTypes.Role);
            if (userName != null && role != null)
            {
                if (imageFile != null && imageFile.Length > 0)//Kiểm tra đường dẫn phù hợp
                {
                    string image = Guid.NewGuid().ToString() + "_" + imageFile.FileName;
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "employees", image);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await imageFile.CopyToAsync(stream);
                    }

                    await _httpClient.PutAsJsonAsync<Employee>($"https://localhost:7033/api/Employee/UpdateImage/{userName}/{image}", null);
                }
            }
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteImage()
        {
            var userName = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var role = User.FindFirstValue(ClaimTypes.Role);
            if (userName != null && role != null)
            {
                await _httpClient.PutAsJsonAsync<Employee>($"https://localhost:7033/api/Employee/UpdateImage/{userName}/default.png", null);
            }
            return RedirectToAction("Index");
        }
    }
}
