using Datn_Api.IServices;
using Datn_Api.Services;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.BillDetailViewModels;
using Datn_Shared.ViewModels.BillViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Datn_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BillDetailController : ControllerBase
    {
        private readonly IBillDetailService _billDetailService;
        public BillDetailController(IBillDetailService billDetailService)
        {
            _billDetailService = billDetailService;
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAllBillDetail()
        {
            var billDetail = await _billDetailService.GetAllBillDetails();
            return Ok(billDetail);
        }

        [HttpGet]
        [Route("GetById/{id:Guid}")]
        public async Task<IActionResult> GetBillDetailById([FromRoute] Guid id)
        {
            var billDetail = await _billDetailService.GetBillDetailsById(id);
            return Ok(billDetail);
        }

        [HttpGet]
        [Route("GetByBillId/{id:Guid}")]
        public async Task<IActionResult> GetBillDetailByBillId([FromRoute] Guid id)
        {
            var billDetail = await _billDetailService.GetBillDetailsByIdBill(id);
            return Ok(billDetail);
        }

        [HttpPost]
        [Route("Create")]
        public async Task<ActionResult<CreateBillDetail>> CreateBillDetail(CreateBillDetail billDetail)
        {
            await _billDetailService.CreateBillDetails(billDetail);
            return Ok(billDetail);
        }

        [HttpPut]
        [Route("Update/{id:Guid}")]
        public async Task<ActionResult<UpdateBillDetail>> UpdateBillDetail([FromRoute] Guid id, [FromBody] UpdateBillDetail billDetail)
        {
            await _billDetailService.UpdateBillDetails(id, billDetail);
            return Ok(billDetail);
        }

        [HttpDelete]
        [Route("Delete/{id:Guid}")]
        public async Task<ActionResult<BillDetail>> DeleteBillDetail([FromRoute] Guid id)
        {
            await _billDetailService.DeleteBillDetails(id);
            return Ok();
        }
    }
}
