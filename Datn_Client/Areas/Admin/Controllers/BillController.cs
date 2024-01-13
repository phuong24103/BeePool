using Datn_Shared.Models;
using Datn_Shared.ViewModels.BillDetailViewModels;
using Datn_Shared.ViewModels.BillViewModels;
using Datn_Shared.ViewModels.ProductDetailViewModels;
using Datn_Shared.ViewModels.ProductViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Datn_Client.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BillController : Controller
    {
        private readonly HttpClient _httpClient;
        public BillController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IActionResult> Bill()
        {
            var result = await _httpClient.GetFromJsonAsync<List<BillView>>($"https://localhost:7033/api/Bill/GetAll");
            return View(result);
        }
        public async Task<IActionResult> BillStatus1()
        {
            var idbillstatus = Guid.Parse("a51f7c3c-a8e7-4c0a-aeea-b6fc70492b15");
            var result = await _httpClient.GetFromJsonAsync<List<BillView>>($"https://localhost:7033/api/Bill/GetBillByBillStatusId/{idbillstatus}");
            return View(result);
        }
        public async Task<IActionResult> BillStatus2()
        {
            var idbillstatus = Guid.Parse("a51f7c3c-a8e7-4c0a-aeea-b6fc70492bf5");
            var result = await _httpClient.GetFromJsonAsync<List<BillView>>($"https://localhost:7033/api/Bill/GetBillByBillStatusId/{idbillstatus}");
            return View(result);
        }
        public async Task<IActionResult> BillStatus3()
        {
            var idbillstatus = Guid.Parse("b392b872-712a-41a7-8542-83fb58249c23");
            var result = await _httpClient.GetFromJsonAsync<List<BillView>>($"https://localhost:7033/api/Bill/GetBillByBillStatusId/{idbillstatus}");
            return View(result);
        }
        public async Task<IActionResult> BillStatus4()
        {
            var idbillstatus = Guid.Parse("00357f21-9356-468b-8c0c-b590e3d1bc0a");
            var result = await _httpClient.GetFromJsonAsync<List<BillView>>($"https://localhost:7033/api/Bill/GetBillByBillStatusId/{idbillstatus}");
            return View(result);
        }
        public async Task<IActionResult> BillStatus5()
        {
            var idbillstatus = Guid.Parse("33c0bdd2-85ca-4f05-9360-22be333895fe");
            var result = await _httpClient.GetFromJsonAsync<List<BillView>>($"https://localhost:7033/api/Bill/GetBillByBillStatusId/{idbillstatus}");
            return View(result);
        }


        public async Task<IActionResult> UpdateBillStatus(Guid id)
        {
            var b = await _httpClient.GetFromJsonAsync<Bill>($"https://localhost:7033/api/Bill/GetById/{id}");
            b.BillStatusId = Guid.Parse("a51f7c3c-a8e7-4c0a-aeea-b6fc70492bf5");
            await _httpClient.PutAsJsonAsync($"https://localhost:7033/api/Bill/Update/{id}", b);
            //Giam so luong ton
            var listBillDetail = await _httpClient.GetFromJsonAsync<List<BillDetailView>>($"https://localhost:7033/api/BillDetail/GetByBillId/{id}");
            foreach(var item in listBillDetail)
            {
                var productdetail = await _httpClient.GetFromJsonAsync<ViewProductDetail>($"https://localhost:7033/api/ProductDetail/GetById/{item.ProductDetailId}");

                var product = await _httpClient.GetFromJsonAsync<ProductView>($"https://localhost:7033/api/Product/GetById/{productdetail.ProductID}");
                UpdateProduct updateProduct = new UpdateProduct()
                {
                    CategoryID = product.CategoryID,
                    BrandID = product.BrandID,
                    Name = product.Name,
                    Pin = product.Pin,
                    Wrap = product.Wrap,
                    Rings = product.Rings,
                    AvailableQuantity = product.AvailableQuantity - item.Quantity,
                    Sold = product.Sold,
                    Likes = product.Likes,
                    CreateDate = product.CreateDate,
                    Status = product.Status,
                    Description = product.Description,
                };

                await _httpClient.PutAsJsonAsync($"https://localhost:7033/api/Product/Update/{product.Id}", updateProduct);
            }
            return RedirectToAction("Bill");
        }
        public async Task<IActionResult> UpdateBillStatus2(Guid id)
        {
            var b = await _httpClient.GetFromJsonAsync<Bill>($"https://localhost:7033/api/Bill/GetById/{id}");
            b.BillStatusId = Guid.Parse("b392b872-712a-41a7-8542-83fb58249c23");
            await _httpClient.PutAsJsonAsync($"https://localhost:7033/api/Bill/Update/{id}", b);
            return RedirectToAction("Bill");
        }
        public async Task<IActionResult> UpdateBillStatus3(Guid id)
        {
            var b = await _httpClient.GetFromJsonAsync<Bill>($"https://localhost:7033/api/Bill/GetById/{id}");
            b.BillStatusId = Guid.Parse("00357f21-9356-468b-8c0c-b590e3d1bc0a");
            await _httpClient.PutAsJsonAsync($"https://localhost:7033/api/Bill/Update/{id}", b);
            return RedirectToAction("Bill");
        }
        public async Task<IActionResult> UpdateBillStatus4(Guid id)
        {
            var b = await _httpClient.GetFromJsonAsync<Bill>($"https://localhost:7033/api/Bill/GetById/{id}");
            b.BillStatusId = Guid.Parse("33c0bdd2-85ca-4f05-9360-22be333895fe");
            await _httpClient.PutAsJsonAsync($"https://localhost:7033/api/Bill/Update/{id}", b);
            return RedirectToAction("Bill");
        }
        public async Task<IActionResult> Delete(Guid id)
        {
            await _httpClient.DeleteAsync($"https://localhost:7033/api/Bill/Delete/{id}");
            return RedirectToAction("Bill");
        }
    }
}
