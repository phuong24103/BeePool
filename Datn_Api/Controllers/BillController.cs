using Datn_Api.IServices;
using Datn_Api.Services;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.BillDetailViewModels;
using Datn_Shared.ViewModels.BillStatusViewModels;
using Datn_Shared.ViewModels.BillViewModels;
using Datn_Shared.ViewModels.CartDetailViewModels;
using Datn_Shared.ViewModels.CartViewModels;
using Datn_Shared.ViewModels.ProductDetailViewModels;
using Datn_Shared.ViewModels.ProductViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Datn_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BillController : ControllerBase
    {
        private readonly IBillService _billService;
        private readonly IBillStatusService _billStatusService;
        private readonly IPaymentService _paymentService;
        private readonly IProductService _productService;
        private readonly IProductDetailService _productDetailService;
        private readonly IBillDetailService _billDetailService;
        private readonly ICartDetailService _cartDetailService;
        private readonly IUserVoucherService _userVoucherService;
        private readonly IVoucherService _voucherService;
        private readonly ICustomerService _customerService;
        public BillController(IBillService billService, IBillStatusService billStatusService, IPaymentService paymentService, IProductService productService, IProductDetailService productDetailService, IBillDetailService billDetailService, ICartDetailService cartDetailService, IUserVoucherService userVoucherService, IVoucherService voucherService, ICustomerService customerService)
        {
            _billService = billService;
            _billStatusService = billStatusService;
            _paymentService = paymentService;
            _productService = productService;
            _productDetailService = productDetailService;
            _billDetailService = billDetailService;
            _cartDetailService = cartDetailService;
            _userVoucherService = userVoucherService;
            _voucherService = voucherService;
            _customerService = customerService;
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAllBill()
        {
            var bill = await _billService.GetAllBills();
            return Ok(bill);
        }

        [HttpGet]
        [Route("GetById/{id:Guid}")]
        public async Task<IActionResult> GetBillById([FromRoute] Guid id)
        {
            var bill = await _billService.GetBillById(id);
            return Ok(bill);
        }

        [HttpGet]
        [Route("GetByCustomerId/{id:Guid}")]
        public async Task<IActionResult> GetBillByCustomerId([FromRoute] Guid id)
        {
            var bill = await _billService.GetBillByCustomerId(id);
            return Ok(bill);
        }


        [HttpPost]
        [Route("CreateBillBT")]
        public async Task<ActionResult<CreateBill>> CreateBillBT(CreateBill bill)
        {
            await _billService.CreateBill(bill);
            return Ok(bill);
        }

        [HttpPost]
        [Route("Create")]
        public async Task<ActionResult<Bill>> CreateBill(List<CartDetail> cartDetails)
        {
            double price = 0;
            foreach (var item in cartDetails)
            {
                var productdetail = _productDetailService.GetProductDetailById(item.ProductDetailId);
                price += (productdetail.Result.Price * item.Quantity);
            }

            var customer = _customerService.GetCustomerbyId(cartDetails.First().CustomerId).Result;

            CreateBill bill = new CreateBill()
            {
                Id = Guid.NewGuid(),
                CustomerId = customer.Id,
                BillStatusId = Guid.Parse("a51f7c3c-a8e7-4c0a-aeea-b6fc70492b15"),
                PaymentId = Guid.Parse("a51f7c3c-a8e7-4c0a-aeea-b6fc70492bf6"),
                Price = price,
                CreateDate = DateTime.Now,
                Address = customer.Address,
                CustomerName = customer.UserName,
                CustomerPhone = customer.PhoneNumber,
            };
            await _billService.CreateBill(bill);

            foreach (var item in cartDetails)
            {
                var productdetail = _productDetailService.GetProductDetailById(item.ProductDetailId);


                var product = _productService.GetProductById(productdetail.Result.ProductID);
                UpdateProduct updateProduct = new UpdateProduct()
                {
                    CategoryID = product.Result.CategoryID,
                    Name = product.Result.Name,
                    Pin = product.Result.Pin,
                    Wrap = product.Result.Wrap,
                    Rings = product.Result.Rings,
                    AvailableQuantity = product.Result.AvailableQuantity - item.Quantity,
                    Sold = product.Result.Sold,
                    Likes = product.Result.Likes,
                    CreateDate = product.Result.CreateDate,
                    Producer = product.Result.Producer,
                    Status = product.Result.Status,
                    Description = product.Result.Description,
                };

                await _productService.UpdateProduct(product.Result.Id, updateProduct);

                CreateBillDetail billDetail = new CreateBillDetail()
                {
                    BillId = bill.Id,
                    ProductDetailId = productdetail.Result.Id,
                    Quantity = item.Quantity,
                    Price = productdetail.Result.Price * item.Quantity,
                };

                await _billDetailService.CreateBillDetails(billDetail);
                await _cartDetailService.DeleteCartDetail(item.Id);
            }


            return Ok(bill);
        }

        [HttpPost]
        [Route("CreateBillVoucher/{codevoucher}")]
        public async Task<ActionResult<Bill>> CreateBillVoucher(List<CartDetail> cartDetails,string codevoucher)
        {
            double price = 0;
            foreach (var item in cartDetails)
            {
                var productdetail = _productDetailService.GetProductDetailById(item.ProductDetailId);
                price += (productdetail.Result.Price * item.Quantity);
            }

            var customer = _customerService.GetCustomerbyId(cartDetails.First().CustomerId).Result;

            var allvoucher = _voucherService.GetAllVoucher();
            var voucher = allvoucher.Result.FirstOrDefault(p => p.Code == codevoucher);
            if (voucher != null && voucher.Status == 0 && DateTime.Now <= voucher.TimeEnd && DateTime.Now >= voucher.TimeStart)
            {
                price -= voucher.Value;
            }
            else
            {
                price -= 0;
            }


            CreateBill bill = new CreateBill()
            {
                Id = Guid.NewGuid(),
                CustomerId = customer.Id,
                BillStatusId = Guid.Parse("a51f7c3c-a8e7-4c0a-aeea-b6fc70492b15"),
                PaymentId = Guid.Parse("a51f7c3c-a8e7-4c0a-aeea-b6fc70492bf6"),
                Price = price,
                CreateDate = DateTime.Now,
                Address = customer.Address,
                CustomerName = customer.UserName,
                CustomerPhone = customer.PhoneNumber,
            };
            await _billService.CreateBill(bill);


            if(voucher != null)
            {
                UsedVoucher uv = new UsedVoucher()
                {
                    BillId = bill.Id,
                    VoucherId = voucher.Id,
                };
                await _userVoucherService.CreateUserVoucher(uv);
            }
            


            foreach (var item in cartDetails)
            {
                var productdetail = _productDetailService.GetProductDetailById(item.ProductDetailId);


                var product = _productService.GetProductById(productdetail.Result.ProductID);
                UpdateProduct updateProduct = new UpdateProduct()
                {
                    CategoryID = product.Result.CategoryID,
                    Name = product.Result.Name,
                    Pin = product.Result.Pin,
                    Wrap = product.Result.Wrap,
                    Rings = product.Result.Rings,
                    AvailableQuantity = product.Result.AvailableQuantity - item.Quantity,
                    Sold = product.Result.Sold,
                    Likes = product.Result.Likes,
                    CreateDate = product.Result.CreateDate,
                    Producer = product.Result.Producer,
                    Status = product.Result.Status,
                    Description = product.Result.Description,
                };

                await _productService.UpdateProduct(product.Result.Id, updateProduct);

                CreateBillDetail billDetail = new CreateBillDetail()
                {
                    BillId = bill.Id,
                    ProductDetailId = productdetail.Result.Id,
                    Quantity = item.Quantity,
                    Price = productdetail.Result.Price * item.Quantity,
                };

                await _billDetailService.CreateBillDetails(billDetail);
                await _cartDetailService.DeleteCartDetail(item.Id);
            }

            return Ok(bill);
        }


        [HttpPut]
        [Route("Update/{id:Guid}")]
        public async Task<ActionResult<UpdateBill>> UpdateBill([FromRoute] Guid id, [FromBody] UpdateBill bill)
        {
            await _billService.UpdateBill(id, bill);
            return Ok(bill);
        }

        [HttpDelete]
        [Route("Delete/{id:Guid}")]
        public async Task<ActionResult<Bill>> DeleteBill([FromRoute] Guid id)
        {
            await _billService.DeleteBill(id);
            return Ok();
        }
    }
}
