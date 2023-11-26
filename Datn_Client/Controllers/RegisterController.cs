using Datn_Shared.ViewModels.AccountViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace Datn_Client.Controllers
{
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
		public async Task<IActionResult> Register(Register registerCustomer)
        {
            // Send request POST to register API
            var response = await _httpClient.PostAsJsonAsync($"https://localhost:7033/api/RegisterCustomer", registerCustomer);
			ViewBag.Message = await response.Content.ReadAsStringAsync();

			return RedirectToAction("Register");
		}
	}
}
