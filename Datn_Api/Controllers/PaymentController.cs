using Datn_Api.IServices;
using Datn_Api.Services;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.PaymentViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Datn_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentService _paymentService;
        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAllPayment()
        {
            var payment = await _paymentService.GetAllPayment();
            return Ok(payment);
        }

        [HttpGet]
        [Route("GetById/{id:Guid}")]
        public async Task<IActionResult> GetPaymentById([FromRoute] Guid id)
        {
            var payment = await _paymentService.GetPaymentById(id);
            return Ok(payment);
        }


        [HttpPost]
        [Route("Create")]
        public async Task<ActionResult<CreatePayment>> CreatePayment(CreatePayment payment)
        {
            await _paymentService.CreatePayment(payment);
            return Ok(payment);
        }

        [HttpPut]
        [Route("Update/{id:Guid}")]
        public async Task<ActionResult<UpdatePayment>> UpdatePayment([FromRoute] Guid id, [FromBody] UpdatePayment payment)
        {
            await _paymentService.UpdatePayment(id, payment);
            return Ok(payment);
        }

        [HttpDelete]
        [Route("Delete/{id:Guid}")]
        public async Task<ActionResult<Payment>> DeletePayment([FromRoute] Guid id)
        {
            await _paymentService.DeletePayment(id);
            return Ok();
        }
    }
}
