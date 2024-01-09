using Datn_Api.IServices;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.BrandViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Datn_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly IBrandServices _brandServices;
        public BrandController(IBrandServices brandServices)
        {
            _brandServices = brandServices;
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAllBrand()
        {
            var brand = await _brandServices.GetAllBrand();
            return Ok(brand);
        }

        [HttpGet]
        [Route("GetById/{id:Guid}")]
        public async Task<IActionResult> GetBrandById([FromRoute] Guid id)
        {
            var brand = await _brandServices.GetBrandById(id);
            return Ok(brand);
        }

        [HttpGet]
        [Route("GetByName/{name}")]
        public async Task<IActionResult> GetBrandByName([FromRoute] string name)
        {
            var brand = await _brandServices.GetBrandByName(name);
            return Ok(brand);
        }

        [HttpPost]
        [Route("Create")]
        public async Task<ActionResult<CreateBrand>> CreateBrand(CreateBrand brand)
        {
            await _brandServices.CreateBrand(brand);
            return Ok(brand);
        }

        [HttpPut]
        [Route("Update/{id:Guid}")]
        public async Task<ActionResult<UpdateBrand>> UpdateCategory([FromRoute] Guid id, [FromBody] UpdateBrand brand)
        {
            await _brandServices.UpdateBrand(id, brand);
            return Ok(brand);
        }

        [HttpDelete]
        [Route("Delete/{id:Guid}")]
        public async Task<ActionResult<Brand>> DeleteBrand([FromRoute] Guid id)
        {
            await _brandServices.DeleteBrand(id);
            return Ok();
        }
    }
}
