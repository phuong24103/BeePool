using Datn_Shared.Models;
using Datn_Shared.ViewModels.ProductImageViewModels;
using Datn_Shared.ViewModels.TipViewModels;

namespace Datn_Api.IServices
{
    public interface IProductImageService
    {
        public Task<bool> CreateProductImage(CreateProductImage createProductImage);

        public Task<bool> UpdateProductImage(Guid id, UpdateProductImage updateProductImage);

        public Task<bool> DeleteProductImage(Guid id);

        public Task<ProductImage> GetProductImageById(Guid id);

        public Task<IEnumerable<ProductImage>> GetAllProductImage();
    }
}
