using Datn_Api.IServices;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.WishListViewModels;
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
        [Route("GetByCustomerId/{id:Guid}")]
        public async Task<IActionResult> GetWishListByCustomerId([FromRoute] Guid id)
        {
            var wishLists = await _wishListService.GetWishListByCustomerId(id);
            return Ok(wishLists);
        }

        [HttpGet]
        [Route("CheckExistLike/{customerId:Guid}/{productId:Guid}")]
        public async Task<IActionResult> CheckExistLike(Guid customerId, Guid productId)
        {
            var wishList = await _wishListService.CheckExistLike(customerId, productId);
            return Ok(wishList);
        }

        [HttpOptions("Like/{customerId:Guid}/{productId:Guid}")]
        public async Task<ActionResult<WishList>> Like(Guid customerId, Guid productId)
        {
            await _wishListService.Like(customerId, productId);
            return Ok();
        }
    }
}
