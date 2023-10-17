using Datn_Shared.ViewModels.AccountViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
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
		public IActionResult Register()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Register(Register registerEmployee, string role)
        {
            // Add role to queryString
            role = "Nhân viên";
            var queryString = $"?role={role}";
            // Send request POST to register API
            var response = await _httpClient.PostAsJsonAsync($"https://localhost:7033/api/RegisterEmployee{queryString}", registerEmployee);
			ViewBag.Message = await response.Content.ReadAsStringAsync();

			return RedirectToAction("Index", "Home", new { area = "Admin" });
		}
	}
}
