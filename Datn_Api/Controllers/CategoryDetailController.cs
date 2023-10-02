using Datn_Api.IServices;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.CategoryDetailViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Datn_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryDetailController : ControllerBase
    {
        private readonly ICategoryDetailService _categoryDetailService;

        public CategoryDetailController(ICategoryDetailService categoryDetailService)
        {
            _categoryDetailService = categoryDetailService;
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAllCategoryDetail()
        {
            var categoriesDetail = await _categoryDetailService.GetAllCategoryDetail();
            return Ok(categoriesDetail);
        }

        [HttpGet]
        [Route("GetById/{id:Guid}")]
        public async Task<IActionResult> GetCategoryDetailById([FromRoute] Guid id)
        {
            var categoryDetail = await _categoryDetailService.GetCategoryDetailById(id);
            return Ok(categoryDetail);
        }

        [HttpGet]
        [Route("GetByCategoryId/{id:Guid}")]
        public async Task<IActionResult> GetCategoryDetailByCategoryId([FromRoute] Guid id)
        {
            var categoriesDetail = await _categoryDetailService.GetCategoryDetailByCategoryId(id);
            return Ok(categoriesDetail);
        }

        [HttpPost]
        [Route("Create")]
        public async Task<ActionResult<CreateCategoryDetail>> CreateCategoryDetail(CreateCategoryDetail categoryDetail)
        {
            await _categoryDetailService.CreateCategoryDetail(categoryDetail);
            return Ok(categoryDetail);
        }

        [HttpPut]
        [Route("Update/{id:Guid}")]
        public async Task<ActionResult<UpdateCategoryDetail>> UpdateCategoryDetail([FromRoute] Guid id, [FromBody] UpdateCategoryDetail categoryDetail)
        {
            await _categoryDetailService.UpdateCategoryDetail(id, categoryDetail);
            return Ok(categoryDetail);
        }

        [HttpDelete]
        [Route("Delete/{id:Guid}")]
        public async Task<ActionResult<CategoryDetail>> DeleteCategory([FromRoute] Guid id)
        {
            await _categoryDetailService.DeleteCategoryDetail(id);
            return Ok();
        }
    }
}
