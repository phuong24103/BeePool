using Datn_Api.IServices;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.CartDetailViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Datn_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartDetailController : ControllerBase
    {
        private readonly ICartDetailService _cartDetailService;

        public CartDetailController(ICartDetailService cartDetailService)
        {
            _cartDetailService = cartDetailService;
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAllCartDetail()
        {
            var cartDetails = await _cartDetailService.GetAllCartDetail();
            return Ok(cartDetails);
        }

        [HttpGet]
        [Route("GetById/{id:Guid}")]
        public async Task<IActionResult> GetCartDetailById([FromRoute] Guid id)
        {
            var cartDetail = await _cartDetailService.GetCartDetailById(id);
            return Ok(cartDetail);
        }

        [HttpGet]
        [Route("GetByCustomerId/{id:Guid}")]
        public async Task<IActionResult> GetCartDetailByCustomerId([FromRoute] Guid id)
        {
            var cartDetails = await _cartDetailService.GetCartDetailByCustomerId(id);
            return Ok(cartDetails);
        }

        [HttpPost]
        [Route("Create")]
        public async Task<ActionResult<CreateCartDetail>> CreateCartDetail(CreateCartDetail cartDetail)
        {
            await _cartDetailService.CreateCartDetail(cartDetail);
            return Ok();
        }

        [HttpPut]
        [Route("Increase/{id:Guid}")]
        public async Task<ActionResult<CartDetail>> IncreaseCartDetail([FromRoute] Guid id)
        {
            await _cartDetailService.IncreaseCartDetail(id);
            return Ok();
        }

        [HttpPut]
        [Route("Reduce/{id:Guid}")]
        public async Task<ActionResult<CartDetail>> ReduceCartDetail([FromRoute] Guid id)
        {
            await _cartDetailService.ReduceCartDetail(id);
            return Ok();
        }

        [HttpDelete]
        [Route("Delete/{id:Guid}")]
        public async Task<ActionResult<CartDetailView>> DeleteCartDetail([FromRoute] Guid id)
        {
            await _cartDetailService.DeleteCartDetail(id);
            return Ok();
        }

        [HttpDelete]
        [Route("DeleteAll/{id:Guid}")]
        public async Task<ActionResult<CartDetailView>> DeleteAllCartDetail([FromRoute] Guid id)
        {
            await _cartDetailService.DeleteAllCartDetail(id);
            return Ok();
        }
    }
}
