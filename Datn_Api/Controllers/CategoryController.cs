using Datn_Api.IServices;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.CategoryViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Datn_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAllCategory()
        {
            var categories = await _categoryService.GetAllCategory();
            return Ok(categories);
        }

        [HttpGet]
        [Route("GetById/{id:Guid}")]
        public async Task<IActionResult> GetCategoryById([FromRoute] Guid id)
        {
            var category = await _categoryService.GetCategoryById(id);
            return Ok(category);
        }

        [HttpGet]
        [Route("GetByName/{name}")]
        public async Task<IActionResult> GetCategoryByName([FromRoute] string name)
        {
            var categories = await _categoryService.GetCategoryByName(name);
            return Ok(categories);
        }

        [HttpPost]
        [Route("Create")]
        public async Task<ActionResult<CreateCategory>> CreateCategory(CreateCategory category)
        {
            await _categoryService.CreateCategory(category);
            return Ok(category);
        }

        [HttpPut]
        [Route("Update/{id:Guid}")]
        public async Task<ActionResult<UpdateCategory>> UpdateCategory([FromRoute] Guid id, [FromBody] UpdateCategory category)
        {
            await _categoryService.UpdateCategory(id, category);
            return Ok(category);
        }

        [HttpDelete]
        [Route("Delete/{id:Guid}")]
        public async Task<ActionResult<Category>> DeleteCategory([FromRoute] Guid id)
        {
            await _categoryService.DeleteCategory(id);
            return Ok();
        }
    }
}
