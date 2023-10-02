using Datn_Shared.Models;

namespace Datn_Api.IServices
{
    public interface ICartDetailService
    {
        public Task<bool> CreateCartDetail(Guid cartId, Guid productId);
        public Task<bool> IncreaseCartDetail(Guid id);
        public Task<bool> ReduceCartDetail(Guid id);
        public Task<bool> DeleteCartDetail(Guid id);
        public Task<CartDetail> GetCartDetailById(Guid id);
        public Task<List<CartDetail>> GetCartDetailByUserId(Guid id);
        public Task<List<CartDetail>> GetAllCartDetail();
    }
}
