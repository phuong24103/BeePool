using Datn_Shared.Models;
using Datn_Shared.ViewModels.WishListViewModels;

namespace Datn_Api.IServices
{
    public interface IWishListService
    {
        public Task<bool> Like(CreateWishList wishList);
        public Task<WishList> GetWishListById(Guid id);
        public Task<List<WishList>> GetWishListByUserId(Guid id);
        public Task<List<WishList>> GetAllWishList();
    }
}
