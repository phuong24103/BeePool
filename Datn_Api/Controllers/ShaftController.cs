using Datn_Api.IServices;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.ShaftViewModels;
using Datn_Shared.ViewModels.TipViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace Datn_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShaftController : ControllerBase
    {
        private readonly IShaftService _ishaftService;
        public ShaftController(IShaftService shaftService)
        {
            _ishaftService = shaftService;
        }
        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAllShaft()
        {
            var mate = await _ishaftService.GetAllShaft();
            return Ok(mate);
        }
        [HttpGet]
        [Route("GetById/{id:Guid}")]
        public async Task<IActionResult> GetShaftById([FromRoute] Guid id)
        {
            var mate = await _ishaftService.GetShaftById(id);
            return Ok(mate);
        }
        [HttpGet]
        [Route("GetByProductDetailId/{id:Guid}")]
        public async Task<IActionResult> GetAllShaftByProductDetailId([FromRoute] Guid id)
        {
            var mate = await _ishaftService.GetAllShaftByProductDetailId(id);
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects
            };
            string json = JsonConvert.SerializeObject(mate, settings);
            JToken parsedJson = JToken.Parse(json);
            string formattedJson = parsedJson.ToString(Newtonsoft.Json.Formatting.Indented);
            return Ok(formattedJson);
        }
        [HttpPost]
        [Route("Create")]
        public async Task<ActionResult<CreateShaft>> CreateShaft(CreateShaft createShaft)
        {
            await _ishaftService.CreateShaft(createShaft);
            return Ok(createShaft);
        }
        [HttpPut]
        [Route("Update/{id:Guid}")]
        public async Task<ActionResult<UpdateShaft>> UpdateShaft([FromRoute] Guid id, [FromBody] UpdateShaft updateShaft)
        {
            await _ishaftService.UpdateShaft(id, updateShaft);
            return Ok(updateShaft);
        }
        [HttpDelete]
        [Route("Delete/{id:Guid}")]
        public async Task<ActionResult<Shaft>> DeleteShaft([FromRoute] Guid id)
        {
            await _ishaftService.DeleteShaft(id);
            return Ok();
        }
        [HttpGet]
        [Route("GetByAllId/{id:Guid}")]

        public async Task<IActionResult> GetAllShaftById([FromRoute] Guid id)
        {
            var mate = await _ishaftService.GetAllShaftById(id);
            return Ok(mate);
        }
    }
}
