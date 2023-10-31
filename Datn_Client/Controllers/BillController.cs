using Datn_Shared.Models;
using Datn_Shared.ViewModels.BillViewModels;
using Datn_Shared.ViewModels.CartDetailViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Json;
using System.Security.Claims;

namespace Datn_Client.Controllers
{
    public class BillController : Controller
    {
        private readonly HttpClient _httpClient;
        public BillController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Bill()
        {
            var userName = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var customer = await _httpClient.GetFromJsonAsync<Customer>($"https://localhost:7033/api/Customer/GetByName/{userName}");
            var result = await _httpClient.GetFromJsonAsync<List<BillView>>($"https://localhost:7033/api/Bill/GetByCustomerId/{customer.Id}");
            return View(result);
        }


        
        public async Task<IActionResult> Create()
        {
            var userName = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var customer = await _httpClient.GetFromJsonAsync<Customer>($"https://localhost:7033/api/Customer/GetByName/{userName}");
            var result = await _httpClient.GetFromJsonAsync<List<CartDetailView>>($"https://localhost:7033/api/CartDetail/GetByCustomerId/{customer.Id}");
            List<CartDetail> cartDetails = new List<CartDetail>();
            foreach(var item in result)
            {
                CartDetail detail = new CartDetail();
                detail.Id = item.Id;
                detail.CustomerId = item.CustomerId;
                detail.ProductDetailId = item.ProductDetailId;
                detail.Quantity = item.Quantity;
                detail.Price = item.Price;
                cartDetails.Add(detail);
            }
            await _httpClient.PostAsJsonAsync($"https://localhost:7033/api/Bill/Create", cartDetails);
            return RedirectToAction("Bill");
        }




        [HttpPost]
        public async Task<IActionResult> CreateVoucher(string code)
        {
            var userName = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var customer = await _httpClient.GetFromJsonAsync<Customer>($"https://localhost:7033/api/Customer/GetByName/{userName}");
            var result = await _httpClient.GetFromJsonAsync<List<CartDetailView>>($"https://localhost:7033/api/CartDetail/GetByCustomerId/{customer.Id}");
            List<CartDetail> cartDetails = new List<CartDetail>();
            foreach (var item in result)
            {
                CartDetail detail = new CartDetail();
                detail.Id = item.Id;
                detail.CustomerId = item.CustomerId;
                detail.ProductDetailId = item.ProductDetailId;
                detail.Quantity = item.Quantity;
                detail.Price = item.Price;
                cartDetails.Add(detail);
            }


            if (code == null)
            {
                await _httpClient.PostAsJsonAsync($"https://localhost:7033/api/Bill/Create", cartDetails);
                return RedirectToAction("Bill");
            }
            else
            {
                string message = string.Empty;
                var allvoucher = await _httpClient.GetFromJsonAsync<List<Voucher>>($"https://localhost:7033/api/Voucher/GetAll");
                var voucher = allvoucher.FirstOrDefault(p => p.Code == code);

                if (voucher == null)
                {
                    message = "Voucher này không tồn tại";
                    TempData["Message"] = message;
                }
                else if (voucher.Status == 1)
                {
                    message = "Voucher này đang khóa";
                    TempData["Message"] = message;

                }
                else if (DateTime.Now < voucher.TimeStart)
                {
                    message = "Voucher này chưa bắt đầu";
                    TempData["Message"] = message;

                }
                else if (DateTime.Now > voucher.TimeEnd)
                {
                    message = "Voucher này đã hết hạn";
                    TempData["Message"] = message;

                }
                else
                {
                    await _httpClient.PostAsJsonAsync($"https://localhost:7033/api/Bill/CreateBillVoucher/{code}", cartDetails);
                    return RedirectToAction("Bill");
                }
                return RedirectToAction("Index", "Cart");
            }

            
        }

    }
}