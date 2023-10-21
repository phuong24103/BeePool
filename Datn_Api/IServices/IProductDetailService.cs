using Datn_Shared.ViewModels.ProductDetailViewModels;
using Datn_Shared.ViewModels.ProductViewModels;

namespace Datn_Api.IServices
{
    public interface IProductDetailService
    {
        public Task<bool> CreateProductDetail(CreateProductDetail product);
        public Task<bool> UpdateProductDetail(Guid id, UpdateProductDetail product);
        public Task<bool> IncreaseProductDetail(Guid id);
        public Task<bool> ReduceProductDetail(Guid id);
        public Task<bool> DeleteProductDetail(Guid id);
        public Task<ViewProductDetail> GetProductDetailById(Guid id);
        public Task<IEnumerable<ViewProductDetail>> GetAllProductDetail();
    }
}
