using Datn_Api.IServices;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.TipViewModels;
using Datn_Shared.ViewModels.WeightViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Datn_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeightController : ControllerBase
    {
        private readonly IWeightService _iweightService;
        public WeightController(IWeightService weightService)
        {
             _iweightService = weightService;
        }
        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAllWeight()
        {
            var mate = await _iweightService.GetAllWeight();
            return Ok(mate);
        }
        [HttpGet]
        [Route("GetById/{id:Guid}")]
        public async Task<IActionResult> GetWeightById([FromRoute] Guid id)
        {
            var mate = await _iweightService.GetWeightById(id);
            return Ok(mate);
        }
        [HttpPost]
        [Route("Create")]
        public async Task<ActionResult<CreateWeight>> CreateWeight(CreateWeight createWeight)
        {
            await _iweightService.CreateWeight(createWeight);
            return Ok(createWeight);
        }
        [HttpPut]
        [Route("Update/{id:Guid}")]
        public async Task<ActionResult<UpdateWeight>> UpdateWeight([FromRoute] Guid id, [FromBody] UpdateWeight updateWeight)
        {
            await _iweightService.UpdateWeight(id, updateWeight);
            return Ok(updateWeight);
        }
        [HttpDelete]
        [Route("Delete/{id:Guid}")]
        public async Task<ActionResult<Weight>> DeleteWeight([FromRoute] Guid id)
        {
            await _iweightService.DeleteWeight(id);
            return Ok();
        }
        [HttpGet]
        [Route("GetByAllId/{id:Guid}")]

        public async Task<IActionResult> GetAllWeightById([FromRoute] Guid id)
        {
            var mate = await _iweightService.GetAllWeightById(id);
            return Ok(mate);
        }
    }
}
