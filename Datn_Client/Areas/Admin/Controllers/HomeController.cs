using Datn_Api.Migrations;
using Datn_Client.Models;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.BillViewModels;
using Datn_Shared.ViewModels.ProductViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Datn_Client.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly HttpClient _httpClient;
        public HomeController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IActionResult> Index(string dateSales, string dateRevenue, string dateCustomer, string dateTopSelling, string dateRecentSale)
        {
            ViewBag.Sales = await _httpClient.GetFromJsonAsync<int>($"https://localhost:7033/api/BillDetail/GetSales/{dateSales}");
            ViewBag.Revenue = await _httpClient.GetFromJsonAsync<double>($"https://localhost:7033/api/BillDetail/GetRevenue/{dateRevenue}");
            ViewBag.TotalCustomer = await _httpClient.GetFromJsonAsync<int>($"https://localhost:7033/api/Customer/GetTotalCustomer/{dateCustomer}");
            ViewBag.TopSelling = await _httpClient.GetFromJsonAsync<IEnumerable<ProductAdminView>>($"https://localhost:7033/api/Product/GetProductStatistics/{dateTopSelling}");
            ViewBag.RecentSale = await _httpClient.GetFromJsonAsync<IEnumerable<BillAdminView>>($"https://localhost:7033/api/Bill/GetRecentSales/{dateRecentSale}");

            List<DateTime> dateTimes = new List<DateTime>()
            {
                DateTime.Now.AddHours(-6),
                DateTime.Now.AddHours(-5),
                DateTime.Now.AddHours(-4),
                DateTime.Now.AddHours(-3),
                DateTime.Now.AddHours(-2),
                DateTime.Now.AddHours(-1),
                DateTime.Now,
            };
            ViewBag.DateTimes = dateTimes;

            ViewBag.ReportSales = await _httpClient.GetStringAsync("https://localhost:7033/api/BillDetail/GetReportSales");
            ViewBag.ReportRevenue = await _httpClient.GetStringAsync("https://localhost:7033/api/BillDetail/GetReportRevenue");
            ViewBag.ReportTotalCustomer = await _httpClient.GetStringAsync("https://localhost:7033/api/Customer/GetReportTotalCustomer");

            ViewBag.DateSales = dateSales;
            ViewBag.DateRevenue = dateRevenue;
            ViewBag.DateTotalCustomer = dateCustomer;
            ViewBag.DateTopSelling = dateTopSelling;
            ViewBag.DateRecentSale = dateRecentSale;
            return View();
        }

        public async Task<IActionResult> FilterSales(string date)
        {
            return RedirectToAction("Index", new { dateSales = date });
        }

        public async Task<IActionResult> FilterRevenue(string date)
        {
            return RedirectToAction("Index", new { dateRevenue = date });
        }

        public async Task<IActionResult> FilterCustomer(string date)
        {
            return RedirectToAction("Index", new { dateCustomer = date });
        }

        public async Task<IActionResult> FilterTopSelling(string date)
        {
            return RedirectToAction("Index", new { dateTopSelling = date });
        }

        public async Task<IActionResult> FilterRecentSale(string date)
        {
            return RedirectToAction("Index", new { dateRecentSale = date });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
