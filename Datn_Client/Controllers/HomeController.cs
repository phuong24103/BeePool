using Datn_Client.Models;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.ProductViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Xml.Linq;

namespace Datn_Client.Controllers
{
    public class HomeController : Controller
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<HomeController> _logger;

        public HomeController(HttpClient httpClient, ILogger<HomeController> logger)
        {
            _httpClient = httpClient;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var lstProductView = await _httpClient.GetFromJsonAsync<List<ProductView>>("https://localhost:7033/api/Product/GetAll");
            var category = lstProductView.Where(p => p.Status == 0).GroupBy(p => p.CategoryName).Select(g => g.First()).Take(4).ToList();

            string queryString1 = "Cơ Truyền Thống";
            var coDanh = await _httpClient.GetFromJsonAsync<List<ProductView>>($"https://localhost:7033/api/Product/GetByCategory/{queryString1}");

            string queryString2 = "Cơ Hiện Đại";
            var coNhay = await _httpClient.GetFromJsonAsync<List<ProductView>>($"https://localhost:7033/api/Product/GetByCategory/{queryString2}");

            ViewData["Category"] = category;
            ViewData["CoDanh"] = coDanh.Take(3).ToList();
            ViewData["CoNhay"] = coNhay.Take(3).ToList();

            return View(lstProductView);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}