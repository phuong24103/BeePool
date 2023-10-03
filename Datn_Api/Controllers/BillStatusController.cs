using Datn_Api.IServices;
using Datn_Api.Services;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.BillStatusViewModels;
using Datn_Shared.ViewModels.RankViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Datn_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BillStatusController : ControllerBase
    {
        private readonly IBillStatusService _billStatusService;

        public BillStatusController(IBillStatusService billStatusService)
        {
            _billStatusService = billStatusService;
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAllBillStatus()
        {
            var billStatus = await _billStatusService.GetAllBillStatus();
            return Ok(billStatus);
        }

        [HttpGet]
        [Route("GetById/{id:Guid}")]
        public async Task<IActionResult> GetBillStatusById([FromRoute] Guid id)
        {
            var billStatus = await _billStatusService.GetBillStatusById(id);
            return Ok(billStatus);
        }

        [HttpPost]
        [Route("Create")]
        public async Task<ActionResult<CreateBillStatus>> CreateBillStatus(CreateBillStatus billStatus)
        {
            await _billStatusService.CreateBillStatus(billStatus);
            return Ok(billStatus);
        }

        [HttpPut]
        [Route("Update/{id:Guid}")]
        public async Task<ActionResult<UpdateBillStatus>> UpdateBillStatus([FromRoute] Guid id, [FromBody] UpdateBillStatus billStatus)
        {
            await _billStatusService.UpdateBillStatus(id, billStatus);
            return Ok(billStatus);
        }

        [HttpDelete]
        [Route("Delete/{id:Guid}")]
        public async Task<ActionResult<BillStatus>> DeleteBillStatus([FromRoute] Guid id)
        {
            await _billStatusService.DeleteBillStatus(id);
            return Ok();
        }
    }
}
