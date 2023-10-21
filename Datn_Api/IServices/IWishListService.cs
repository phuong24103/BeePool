using Datn_Shared.Models;
using Datn_Shared.ViewModels.WishListViewModels;

namespace Datn_Api.IServices
{
    public interface IWishListService
    {
        public Task<bool> Like(Guid customerId, Guid productId);
        public Task<bool> CheckExistLike(Guid customerId, Guid productId);
        public Task<WishListView> GetWishListById(Guid id);
        public Task<List<WishListView>> GetWishListByCustomerId(Guid id);
        public Task<List<WishListView>> GetAllWishList();
    }
}
