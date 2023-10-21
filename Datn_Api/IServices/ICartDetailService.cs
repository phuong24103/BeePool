using Datn_Shared.Models;
using Datn_Shared.ViewModels.CartDetailViewModels;

namespace Datn_Api.IServices
{
    public interface ICartDetailService
    {
        public Task<bool> CreateCartDetail(CreateCartDetail cartDetail);
        public Task<bool> IncreaseCartDetail(Guid id);
        public Task<bool> ReduceCartDetail(Guid id);
        public Task<bool> DeleteCartDetail(Guid id);
        public Task<bool> DeleteAllCartDetail(Guid id);
        public Task<CartDetailView> GetCartDetailById(Guid id);
        public Task<List<CartDetailView>> GetCartDetailByCustomerId(Guid id);
        public Task<List<CartDetailView>> GetAllCartDetail();
    }
}
