using Datn_Shared.Models;
using Datn_Shared.ViewModels.BillDetailViewModels;
using Datn_Shared.ViewModels.BillViewModels;
using Datn_Shared.ViewModels.ProductDetailViewModels;
using Datn_Shared.ViewModels.ProductViewModels;
using Datn_Shared.ViewModels.VoucherViewModels;
using Datn_Shared.ViewModels.WeightViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Datn_Client.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BillDetailController : Controller
    {
        private readonly HttpClient _httpClient;
        public BillDetailController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> BillDetail(Guid id)
        {
            var result = await _httpClient.GetFromJsonAsync<List<BillDetailView>>($"https://localhost:7033/api/BillDetail/GetByBillId/{id}");
            if(result.Count == 0)
            {
                await _httpClient.DeleteAsync($"https://localhost:7033/api/Bill/Delete/{id}");
                return RedirectToAction("Bill", "Bill");
            }
            else
            {
                return View(result);
            }
            
        }
        public async Task<IActionResult> Update(Guid id)
        {
            var allproduct = await _httpClient.GetFromJsonAsync<List<ProductView>>("https://localhost:7033/api/Product/GetAll");
            ViewData["a"] = allproduct;
            var billdetail = await _httpClient.GetFromJsonAsync<BillDetailView>($"https://localhost:7033/api/BillDetail/GetById/{id}");
            return View(billdetail);
        }
        public async Task<IActionResult> UpdateB(UpdateBillDetail updateBillDetail)
        {
            //Cập nhật giá của billdetail
            var productdt = await _httpClient.GetFromJsonAsync<ViewProductDetail>($"https://localhost:7033/api/ProductDetail/GetById/{updateBillDetail.ProductDetailId}");
            updateBillDetail.Price = productdt.Price * updateBillDetail.Quantity;

            await _httpClient.PutAsJsonAsync($"https://localhost:7033/api/BillDetail/Update/{updateBillDetail.Id}", updateBillDetail);

            //Tìm bill detail theo bill để thay đổi price
            var result = await _httpClient.GetFromJsonAsync<List<BillDetailView>>($"https://localhost:7033/api/BillDetail/GetByBillId/{updateBillDetail.BillId}");
            double price = 0;
            foreach (var item in result)
            {
                var productdetail = await _httpClient.GetFromJsonAsync<ViewProductDetail>($"https://localhost:7033/api/ProductDetail/GetById/{item.ProductDetailId}");
                price += (productdetail.Price * item.Quantity);
            }
            var b = await _httpClient.GetFromJsonAsync<Bill>($"https://localhost:7033/api/Bill/GetById/{updateBillDetail.BillId}");
            b.Price = price;
            await _httpClient.PutAsJsonAsync($"https://localhost:7033/api/Bill/Update/{updateBillDetail.BillId}", b);


            return RedirectToAction("BillDetail", new { id = updateBillDetail.BillId });
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            var billdetail = await _httpClient.GetFromJsonAsync<BillDetailView>($"https://localhost:7033/api/BillDetail/GetById/{id}");

            await _httpClient.DeleteAsync($"https://localhost:7033/api/BillDetail/Delete/{id}");

            //Tìm bill detail theo bill để thay đổi price
            var result = await _httpClient.GetFromJsonAsync<List<BillDetailView>>($"https://localhost:7033/api/BillDetail/GetByBillId/{billdetail.BillId}");
            double price = 0;
            foreach (var item in result)
            {
                var productdetail = await _httpClient.GetFromJsonAsync<ViewProductDetail>($"https://localhost:7033/api/ProductDetail/GetById/{item.ProductDetailId}");
                price += (productdetail.Price * item.Quantity);
            }
            var b = await _httpClient.GetFromJsonAsync<Bill>($"https://localhost:7033/api/Bill/GetById/{billdetail.BillId}");
            b.Price = price;
            await _httpClient.PutAsJsonAsync($"https://localhost:7033/api/Bill/Update/{billdetail.BillId}", b);

            return RedirectToAction("BillDetail", new { id = billdetail.BillId });
        }
        public async Task<IActionResult> Add(Guid id)
        {
            var bill = await _httpClient.GetFromJsonAsync<BillView>($"https://localhost:7033/api/Bill/GetById/{id}");
            ViewData["b"] = bill;
            var allproduct = await _httpClient.GetFromJsonAsync<List<ProductView>>("https://localhost:7033/api/Product/GetAll");
            ViewData["a"] = allproduct;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(CreateBillDetail createBillDetail)
        {
            //Cập nhật giá của billdetail
            var productdt = await _httpClient.GetFromJsonAsync<ViewProductDetail>($"https://localhost:7033/api/ProductDetail/GetById/{createBillDetail.ProductDetailId}");
            createBillDetail.Price = productdt.Price * createBillDetail.Quantity;

            await _httpClient.PostAsJsonAsync($"https://localhost:7033/api/BillDetail/Create", createBillDetail);

            //Tìm bill detail theo bill để thay đổi price
            var result = await _httpClient.GetFromJsonAsync<List<BillDetailView>>($"https://localhost:7033/api/BillDetail/GetByBillId/{createBillDetail.BillId}");
            double price = 0;
            foreach (var item in result)
            {
                var productdetail = await _httpClient.GetFromJsonAsync<ViewProductDetail>($"https://localhost:7033/api/ProductDetail/GetById/{item.ProductDetailId}");
                price += (productdetail.Price * item.Quantity);
            }
            var b = await _httpClient.GetFromJsonAsync<Bill>($"https://localhost:7033/api/Bill/GetById/{createBillDetail.BillId}");
            b.Price = price;
            await _httpClient.PutAsJsonAsync($"https://localhost:7033/api/Bill/Update/{createBillDetail.BillId}", b);

            return RedirectToAction("BillDetail", new { id = createBillDetail.BillId });
        }

    }
}
