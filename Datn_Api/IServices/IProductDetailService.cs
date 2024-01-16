using Datn_Shared.Models;
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
        public Task<bool> ResetQuantityProductDetail(Guid id);
        public Task<bool> DeleteProductDetail(Guid id);
        public Task<ViewProductDetail> GetProductdtByTip(Guid id,Guid tipid);
        public Task<ViewProductDetail> GetProductdtByShaft(Guid id, Guid Shaftid);
        public Task<ViewProductDetail> GetProductdtByWeight(Guid id,Guid Weightid);
        public Task<ViewProductDetail> GetProductDetailById(Guid id);
        public Task<ProductDetail> GetProductDetailFEById(Guid id);
        public Task<IEnumerable<ViewProductDetail>> GetAllProductDetail();
    }
}
