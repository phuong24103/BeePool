using Datn_Shared.Models;

namespace Datn_Api.IServices
{
    public interface IWishListService
    {
        public Task<bool> Like(Guid accountId, Guid productId);
        public Task<WishList> GetWishListById(Guid id);
        public Task<List<WishList>> GetWishListByUserId(Guid id);
        public Task<List<WishList>> GetAllWishList();
    }
}
