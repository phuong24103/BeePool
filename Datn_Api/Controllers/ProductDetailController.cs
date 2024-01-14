using Datn_Api.IServices;
using Datn_Api.Services;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.CartDetailViewModels;
using Datn_Shared.ViewModels.ProductDetailViewModels;
using Datn_Shared.ViewModels.TipViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace Datn_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductDetailController : ControllerBase
    {
        private readonly IProductDetailService _iprodtsv;
        public ProductDetailController(IProductDetailService productDetailService)
        {
            _iprodtsv = productDetailService;
        }
        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAllProductDetail()
        {
            var mate = await _iprodtsv.GetAllProductDetail();
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects
            };
            string json = JsonConvert.SerializeObject(mate, settings);
            JToken parsedJson = JToken.Parse(json);
            string formattedJson = parsedJson.ToString(Newtonsoft.Json.Formatting.Indented);
            return Ok(formattedJson);
        }
        [HttpGet]
        [Route("GetTip/{id:Guid}/{tipid:Guid}")]
        public async Task<IActionResult> GetProductdtByTip(Guid id, Guid tipid)
        {
            var tip = await _iprodtsv.GetProductdtByTip(id,tipid);
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects
            };
            string json = JsonConvert.SerializeObject(tip, settings);
            JToken parsedJson = JToken.Parse(json);
            string formattedJson = parsedJson.ToString(Newtonsoft.Json.Formatting.Indented);
            return Ok(formattedJson);
           
        }  
        [HttpGet]
        [Route("GetShaft/{id:Guid}/{shaftid:Guid}")]
        public async Task<IActionResult> GetProductdtByShaft(Guid id, Guid shaftid)
        {
            var shaft = await _iprodtsv.GetProductdtByShaft(id,shaftid);

            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects
            };
            string json = JsonConvert.SerializeObject(shaft, settings);
            JToken parsedJson = JToken.Parse(json);
            string formattedJson = parsedJson.ToString(Newtonsoft.Json.Formatting.Indented);
            return Ok(formattedJson);
        }
        [HttpGet]
        [Route("GetWeight/{id:Guid}/{weightid:Guid}")]
        public async Task<IActionResult> GetProductdtByWeight(Guid id, Guid weightid)
        {
            var weight = await _iprodtsv.GetProductdtByWeight(id,weightid);
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects
            };
            string json = JsonConvert.SerializeObject(weight, settings);
            JToken parsedJson = JToken.Parse(json);
            string formattedJson = parsedJson.ToString(Newtonsoft.Json.Formatting.Indented);
            return Ok(formattedJson);
        }
        [HttpGet]
        [Route("GetById/{id:Guid}")]
        public async Task<IActionResult> GetProductDetailById([FromRoute] Guid id)
        {
            var mate = await _iprodtsv.GetProductDetailById(id);
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
        public async Task<ActionResult<CreateProductDetail>> CreateProductDetail(CreateProductDetail createProductDetail)
        {
            await _iprodtsv.CreateProductDetail(createProductDetail);
            return Ok(createProductDetail);
        }
        [HttpPut]
        [Route("Update/{id:Guid}")]
        public async Task<ActionResult<UpdateProductDetail>> UpdateProductDetail([FromRoute] Guid id, [FromBody] UpdateProductDetail updateProductDetail)
        {
            await _iprodtsv.UpdateProductDetail(id, updateProductDetail);
            return Ok(updateProductDetail);
        }

        [HttpPut]
        [Route("Increase/{id:Guid}")]
        public async Task<ActionResult<ProductDetail>> IncreaseProductDetail([FromRoute] Guid id)
        {
            await _iprodtsv.IncreaseProductDetail(id);
            return Ok();
        }

        [HttpPut]
        [Route("Reduce/{id:Guid}")]
        public async Task<ActionResult<ProductDetail>> ReduceProductDetail([FromRoute] Guid id)
        {
            await _iprodtsv.ReduceProductDetail(id);
            return Ok();
        }

        [HttpPut]
        [Route("ResetQuantity/{id:Guid}")]
        public async Task<ActionResult<ProductDetail>> ResetQuantityProductDetail([FromRoute] Guid id)
        {
            await _iprodtsv.ResetQuantityProductDetail(id);
            return Ok();
        }

        [HttpDelete]
        [Route("Delete/{id:Guid}")]
        public async Task<ActionResult<ProductDetail>> DeleteProductDetail([FromRoute] Guid id)
        {
            await _iprodtsv.DeleteProductDetail(id);
            return Ok();
        }
    }
}
