using Datn_Api.IServices;
using Datn_Api.Services;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.BillDetailViewModels;
using Datn_Shared.ViewModels.BillStatusViewModels;
using Datn_Shared.ViewModels.BillViewModels;
using Datn_Shared.ViewModels.CartViewModels;
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
        private readonly IUserservice _usersService;
        private readonly IProductService _productService;
        private readonly IBillDetailService _billDetailService;
        private readonly ICartDetailService _cartDetailService;
        public BillController(IBillService billService, IBillStatusService billStatusService, IPaymentService paymentService, IUserservice usersService, IProductService productService, IBillDetailService billDetailService, ICartDetailService cartDetailService)
        {
            _billService = billService;
            _billStatusService = billStatusService;
            _paymentService = paymentService;
            _usersService = usersService;
            _productService = productService;
            _billDetailService = billDetailService;
            _cartDetailService = cartDetailService;
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

        [HttpPost]
        [Route("Create")]
        public async Task<ActionResult<Bill>> CreateBill(List<CartDetail> cartDetails)
        {
            Guid userId = Guid.NewGuid();
            double price = 0;
            foreach(var item in cartDetails)
            {
                var product = _productService.GetProductById(item.ProductId);
                price += (product.Result.Price * item.Quantity);
                userId = item.CartId;
            }

            CreateBill bill = new CreateBill()
            {
                Id = Guid.NewGuid(),
                UserId = userId,
                BillStatusId = Guid.Parse("A51F7C3C-A8E7-4C0A-AEEA-B6FC70492B15"),
                PaymentId = Guid.Parse("A51F7C3C-A8E7-4C0A-AEEA-B6FC70492BF6"),
                Price = price,
                CreateDate = DateTime.Now,
                Address = _usersService.GetUserById(userId).Result.Address,
            };
            await _billService.CreateBill(bill);

            foreach (var item in cartDetails)
            {
                var product = _productService.GetProductById(item.ProductId);
                product.Result.AvailableQuantity -= item.Quantity;
                
                await _productService.UpdateProduct(product.Result.Id,product1);

                CreateBillDetail billDetail = new CreateBillDetail()
                {
                    BillId = bill.Id,
                    ProductId = product.Result.Id,
                    Quantity = item.Quantity,
                    Price = product.Result.Price * item.Quantity,
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
