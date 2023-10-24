using Datn_Api.IServices;
using Datn_Api.Services;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.ProductViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Xml;

namespace Datn_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _iprosv;

        public ProductController(IProductService productService)
        {
            _iprosv = productService;
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAllProduct()
        {
            var mate = await _iprosv.GetAllProduct();
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
        [Route("GetById/{id:Guid}")]
        public async Task<IActionResult> GetProductById([FromRoute] Guid id)
        {
            var mate = await _iprosv.GetProductById(id);
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects
            };
            string json = JsonConvert.SerializeObject(mate, settings);
            JToken parsedJson = JToken.Parse(json);
            string formattedJson = parsedJson.ToString(Newtonsoft.Json.Formatting.Indented);
            return Ok(formattedJson);
        }

        [HttpGet("GetByName/{name}")]
        public async Task<IActionResult> GetProductByName([FromRoute] string name)
        {
            var product = await _iprosv.GetProductByName(name);
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects
            };
            string json = JsonConvert.SerializeObject(product, settings);
            JToken parsedJson = JToken.Parse(json);
            string formattedJson = parsedJson.ToString(Newtonsoft.Json.Formatting.Indented);
            return Ok(formattedJson);
        }

        [HttpGet]
        [Route("GetByNameAZ")]
        public async Task<IActionResult> GetProductByNameAZ()
        {
            var mate = await _iprosv.GetProductByNameAZ();
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
        [Route("GetByNameZA")]
        public async Task<IActionResult> GetProductByNameZA()
        {
            var mate = await _iprosv.GetProductByNameZA();
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
        [Route("GetByCreateDateOld")]
        public async Task<IActionResult> GetProductByCreateDateOld()
        {
            var mate = await _iprosv.GetProductByCreateDateOld();
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
        [Route("GetByCreateDateNew")]
        public async Task<IActionResult> GetProductByCreateDateNew()
        {
            var mate = await _iprosv.GetProductByCreateDateNew();
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
        [Route("GetByPriceMin")]
        public async Task<IActionResult> GetProductByPriceMin()
        {
            var mate = await _iprosv.GetProductByPriceMin();
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
        [Route("GetByPriceMax")]
        public async Task<IActionResult> GetProductByPriceMax()
        {
            var mate = await _iprosv.GetProductByPriceMax();
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
        [Route("GetByPrice2")]
        public async Task<IActionResult> GetProductByPrice2()
        {
            var mate = await _iprosv.GetProductByPrice2();
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
        public async Task<ActionResult<CreateProduct>> CreateProduct(CreateProduct createProduct)
        {
            await _iprosv.CreateProduct(createProduct);
            return Ok(createProduct);
        }

        [HttpPut]
        [Route("Update/{id:Guid}")]
        public async Task<ActionResult<UpdateProduct>> UpdateProduct([FromRoute] Guid id, [FromBody] UpdateProduct updateProduct)
        {
            await _iprosv.UpdateProduct(id, updateProduct);
            return Ok(updateProduct);
        }

        [HttpDelete]
        [Route("Delete/{id:Guid}")]
        public async Task<ActionResult<Product>> DeleteProduct([FromRoute] Guid id)
        {
            await _iprosv.DeleteProduct(id);
            return Ok();
        }
    }
}