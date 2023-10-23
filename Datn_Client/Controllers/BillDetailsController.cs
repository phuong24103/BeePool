using Datn_Shared.Models;
using Datn_Shared.ViewModels.BillDetailViewModels;
using Datn_Shared.ViewModels.BillViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

namespace Datn_Client.Controllers
{
    public class BillDetailsController : Controller
    {
        private readonly HttpClient _httpClient;
        public BillDetailsController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> BillDetails(Guid id)
        {
            var result = await _httpClient.GetFromJsonAsync<List<BillDetailView>>($"https://localhost:7033/api/BillDetail/GetByBillId/{id}");
            return View(result);
        }
    }
}