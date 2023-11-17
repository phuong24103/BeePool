using Datn_Api.IServices;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.WishListViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

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
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects
            };
            string json = JsonConvert.SerializeObject(wishLists, settings);
            JToken parsedJson = JToken.Parse(json);
            string formattedJson = parsedJson.ToString(Newtonsoft.Json.Formatting.Indented);
            return Ok(formattedJson);
        }

        [HttpGet]
        [Route("GetById/{id:Guid}")]
        public async Task<IActionResult> GetWishListById([FromRoute] Guid id)
        {
            var wishList = await _wishListService.GetWishListById(id);
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects
            };
            string json = JsonConvert.SerializeObject(wishList, settings);
            JToken parsedJson = JToken.Parse(json);
            string formattedJson = parsedJson.ToString(Newtonsoft.Json.Formatting.Indented);
            return Ok(wishList);
        }

        [HttpGet]
        [Route("GetByCustomerId/{id:Guid}")]
        public async Task<IActionResult> GetWishListByCustomerId([FromRoute] Guid id)
        {
            var wishLists = await _wishListService.GetWishListByCustomerId(id);
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects
            };
            string json = JsonConvert.SerializeObject(wishLists, settings);
            JToken parsedJson = JToken.Parse(json);
            string formattedJson = parsedJson.ToString(Newtonsoft.Json.Formatting.Indented);
            return Ok(formattedJson);
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
