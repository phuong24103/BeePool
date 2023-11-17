using Datn_Shared.Models;
using Datn_Shared.ViewModels.EmployeeViewModels;
using Datn_Shared.ViewModels.ProductViewModels;
using Datn_Shared.ViewModels.VoucherViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Datn_Client.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class VoucherController : Controller
    {
        private readonly HttpClient _httpClient;
        public VoucherController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        [HttpGet]
        public async Task<IActionResult> Index(Guid id)
        {
            var userName = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var role = User.FindFirstValue(ClaimTypes.Role);
            if (userName != null && role != null)
            {
                var employee = await _httpClient.GetFromJsonAsync<EmployeeView>($"https://localhost:7033/api/Employee/GetByName/{userName}");
                ViewData["employee"] = employee;
                if (id == Guid.Empty)
                {
                    var voucher = await _httpClient.GetFromJsonAsync<IEnumerable<Voucher>>("https://localhost:7033/api/Voucher/GetAll");
                    return View(voucher);
                }
                else
                {
                    var vouchers = await _httpClient.GetFromJsonAsync<IEnumerable<Voucher>>("https://localhost:7033/api/Voucher/GetAll");
                    var voucher = await _httpClient.GetFromJsonAsync<Voucher>($"https://localhost:7033/api/Voucher/GetById/{id}");
                    List<Voucher> c = new List<Voucher>();

                    c.Add(voucher);
                    ViewData["voucherbyid"] = c;
                    return View(vouchers);
                }
            }
            return RedirectToAction("Error", "Home");
        }

        public async Task<IActionResult> Detail(Guid id)
        {
            return RedirectToAction("Index", new { id = id });
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateVoucher createVoucher)
        {
            await _httpClient.PostAsJsonAsync($"https://localhost:7033/api/Voucher/Create", createVoucher);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            await _httpClient.DeleteAsync($"https://localhost:7033/api/Voucher/Delete/{id}");
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Update(Guid id)
        {
            var t = await _httpClient.GetFromJsonAsync<Voucher>($"https://localhost:7033/api/Voucher/GetById/{id}");
            return View(t);
        }
        public async Task<IActionResult> Update(Guid id, UpdateVoucher updateVoucher)
        {
            await _httpClient.PutAsJsonAsync($"https://localhost:7033/api/Voucher/Update/{id}", updateVoucher);
            return RedirectToAction("Index");
        }


    }
}
