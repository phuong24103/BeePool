using Datn_Api.IServices;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.ProductImageViewModels;
using Datn_Shared.ViewModels.TipViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Datn_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductImageController : ControllerBase
    {
        private readonly IProductImageService  _iproductImageService;
        public ProductImageController(IProductImageService productImageService)
        {
            _iproductImageService = productImageService;
        }
        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAllProductImage()
        {
            var mate = await _iproductImageService.GetAllProductImage();
            return Ok(mate);
        }
        [HttpGet]
        [Route("GetById/{id:Guid}")]
        public async Task<IActionResult> GetProductImageById([FromRoute] Guid id)
        {
            var mate = await _iproductImageService.GetProductImageById(id);
            return Ok(mate);
        }
        [HttpPost]
        [Route("Create")]
        public async Task<ActionResult<CreateProductImage>> CreateProductImage(CreateProductImage createProductImage)
        {
            await _iproductImageService.CreateProductImage(createProductImage);
            return Ok(createProductImage);
        }
        [HttpPut]
        [Route("Update/{id:Guid}")]
        public async Task<ActionResult<UpdateProductImage>> UpdateProductImage([FromRoute] Guid id, [FromBody] UpdateProductImage updateProductImage)
        {
            await _iproductImageService.UpdateProductImage(id, updateProductImage);
            return Ok(updateProductImage);
        }
        [HttpDelete]
        [Route("Delete/{id:Guid}")]
        public async Task<ActionResult<ProductImage>> DeleteProductImage([FromRoute] Guid id)
        {
            await _iproductImageService.DeleteProductImage(id);
            return Ok();
        }
    }
}
