﻿using Datn_Api.IServices;
using Datn_Api.Services;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.TipViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace Datn_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipController : ControllerBase
    {
        private readonly ITipService _itisv;
        public TipController(ITipService tipService)
        {
            _itisv = tipService;
        }
        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAllTip()
        {
            var mate = await _itisv.GetAllTip();
            return Ok(mate);
        }
        [HttpGet]
        [Route("GetById/{id:Guid}")]
        public async Task<IActionResult> GetTipById([FromRoute] Guid id)
        {
            var mate = await _itisv.GetTipById(id);
            return Ok(mate);
        }
        [HttpPost]
        [Route("Create")]
        public async Task<ActionResult<CreateTip>> CreateTip(CreateTip createTip)
        {
            await _itisv.CreateTip(createTip);
            return Ok(createTip);
        }
        [HttpPut]
        [Route("Update/{id:Guid}")]
        public async Task<ActionResult<UpdateTip>> UpdateTip([FromRoute] Guid id, [FromBody] UpdateTip updateTip)
        {
            await _itisv.UpdateTip(id, updateTip);      
            return Ok(updateTip);
        }
        [HttpDelete]
        [Route("Delete/{id:Guid}")]
        public async Task<ActionResult<Tip>> DeleteTip([FromRoute] Guid id)
        {
            await _itisv.DeleteTip(id);
            return Ok();
        }
        [HttpGet]
        [Route("GetByAllId/{id:Guid}")]

        public async Task<IActionResult> GetAllTipById([FromRoute] Guid id)
        {
            var mate = await _itisv.GetAllTipById(id);
            return Ok(mate);
        }
        [HttpGet]
        [Route("GetByProductDetailId/{id:Guid}")]
        public async Task<IActionResult> GetAllTipByProductDetailId([FromRoute] Guid id)
        {
            var mate = await _itisv.GetAllTipByProductDetailId(id);
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects
            };
            string json = JsonConvert.SerializeObject(mate, settings);
            JToken parsedJson = JToken.Parse(json);
            string formattedJson = parsedJson.ToString(Newtonsoft.Json.Formatting.Indented);
            return Ok(formattedJson);
        }
    }
}
