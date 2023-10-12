using Datn_Api.IServices;
using Datn_Api.Services;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.VoucherViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Datn_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoucherController : ControllerBase
    {
        private readonly IVoucherService _voucherService;
        public VoucherController(IVoucherService voucherService)
        {
            _voucherService = voucherService;
        }


        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAllVoucher()
        {
            var voucher = await _voucherService.GetAllVoucher();
            return Ok(voucher);
        }

        [HttpGet]
        [Route("GetById/{id:Guid}")]
        public async Task<IActionResult> GetVoucherById([FromRoute] Guid id)
        {
            var voucher = await _voucherService.GetVoucherById(id);
            return Ok(voucher);
        }


        [HttpPost]
        [Route("Create")]
        public async Task<ActionResult<CreateVoucher>> CreateVoucher(CreateVoucher voucher)
        {
            await _voucherService.CreateVoucher(voucher);
            return Ok(voucher);
        }

        [HttpPut]
        [Route("Update/{id:Guid}")]
        public async Task<ActionResult<UpdateVoucher>> UpdateVoucher([FromRoute] Guid id, [FromBody] UpdateVoucher voucher)
        {
            await _voucherService.UpdateVoucher(id, voucher);
            return Ok(voucher);
        }

        [HttpDelete]
        [Route("Delete/{id:Guid}")]
        public async Task<ActionResult<Voucher>> DeleteVoucher([FromRoute] Guid id)
        {
            await _voucherService.DeleteVoucher(id);
            return Ok();
        }
    }
}
