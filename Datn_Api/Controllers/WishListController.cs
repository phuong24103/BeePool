using Datn_Api.IServices;
using Datn_Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace Datn_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WishListController : ControllerBase
    {
        private readonly IWishListService _wishListService;

        public WishListController(IWishListService wishListService)
        {
            _wishListService = wishListService;
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAllWishList()
        {
            var wishLists = await _wishListService.GetAllWishList();
            return Ok(wishLists);
        }

        [HttpGet]
        [Route("GetById/{id:Guid}")]
        public async Task<IActionResult> GetWishListById([FromRoute] Guid id)
        {
            var wishList = await _wishListService.GetWishListById(id);
            return Ok(wishList);
        }

        [HttpGet]
        [Route("GetByUserId/{id:Guid}")]
        public async Task<IActionResult> GetWishListByUserId([FromRoute] Guid id)
        {
            var wishLists = await _wishListService.GetWishListByUserId(id);
            return Ok(wishLists);
        }

        [HttpOptions("{userId}/{productId}")]
        public async Task<ActionResult<WishList>> Like(Guid userId, Guid productId)
        {
            await _wishListService.Like(userId, productId);
            return Ok();
        }
    }
}
