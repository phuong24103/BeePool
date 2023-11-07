using Datn_Client.Models.Payment;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.BillDetailViewModels;
using Datn_Shared.ViewModels.BillViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Http;
using System.Xml.Linq;

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

        public IActionResult VnpayReturn()
        {
            ViewBag.InnerText = "Giao dịch được thực hiện thành công. Cảm ơn quý khách đã sử dụng dịch vụ";
            return View();
        }

        public async Task<IActionResult> ThanhToan(Guid id)
        {
            var urlPayment = "";
            var bill = await _httpClient.GetFromJsonAsync<BillView>($"https://localhost:7033/api/Bill/GetById/{id}");


            string vnp_Returnurl = "https://localhost:7162/BillDetails/VnpayReturn"; //URL nhan ket qua tra ve
            string vnp_Url = "https://sandbox.vnpayment.vn/paymentv2/vpcpay.html"; //URL thanh toan cua VNPAY 
            string vnp_TmnCode = "M5D7W272"; //Ma định danh merchant kết nối (Terminal Id)
            string vnp_HashSecret = "DGGZJILFSRTUPWIOIBRQXDXJXQPLAOZY"; //Secret Key

            VnPayLibrary vnpay = new VnPayLibrary();

            var price = (long)bill.Price * 100;
            vnpay.AddRequestData("vnp_Version", VnPayLibrary.VERSION);
            vnpay.AddRequestData("vnp_Command", "pay");
            vnpay.AddRequestData("vnp_TmnCode", vnp_TmnCode);
            vnpay.AddRequestData("vnp_Amount", price.ToString());


            vnpay.AddRequestData("vnp_CreateDate", bill.CreateDate.ToString("yyyyMMddHHmmss"));
            vnpay.AddRequestData("vnp_CurrCode", "VND");
            //Lấy địa chỉ ip máy tính
            vnpay.AddRequestData("vnp_IpAddr", "13.160.92.202");
            vnpay.AddRequestData("vnp_Locale", "vn");
            vnpay.AddRequestData("vnp_OrderInfo", "Thanh toan don hang:" + bill.Id);
            vnpay.AddRequestData("vnp_OrderType", "other"); //default value: other

            vnpay.AddRequestData("vnp_ReturnUrl", vnp_Returnurl);
            vnpay.AddRequestData("vnp_TxnRef", bill.Id.ToString());

            //Add Params of 2.1.0 Version
            //Billing
            urlPayment = vnpay.CreateRequestUrl(vnp_Url, vnp_HashSecret);

            //var url = UrlPayment(0, idbill);
            return Redirect(urlPayment);
        }

        

    }
}