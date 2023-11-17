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
		public async Task<IActionResult> Register(Register registerCustomer, IFormFile imageFile)
        {
            if (imageFile != null && imageFile.Length > 0)//Kiểm tra đường dẫn phù hợp
            {
				string image = Guid.NewGuid().ToString() + "_" + imageFile.FileName;
                //thực hiện sao chép ảnh đó vào wwwroot
                //Tạo đường dẫn tới thư mục sao chép (nằm trong root)
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "customers", image);
                var stream = new FileStream(path, FileMode.Create);//Tạo 1 filestream để tạo mới
                await imageFile.CopyToAsync(stream);//copy ảnh vừa được chọn vào đúng cái stream đó
                                                    //gán lại giá trị link ảnh (lúc này đã nằm trong root cho thuộc tính ImageUrl)
                registerCustomer.Image = image;
            }
            // Send request POST to register API
            var response = await _httpClient.PostAsJsonAsync($"https://localhost:7033/api/RegisterCustomer", registerCustomer);
			ViewBag.Message = await response.Content.ReadAsStringAsync();

			return RedirectToAction("Register");
		}
	}
}
